using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;

namespace Erp_System_for_UPS
{
    public partial class DashbordElements : Form
    {
        private readonly Dbcon db;
        private Chart costChart;
        private DashboardDataFetcher dataFetcher;

        public DashbordElements()
        {
            db = new Dbcon();
            dataFetcher = new DashboardDataFetcher(db);
            InitializeComponent();
            InitializeCostChart();
            LoadDashboardData();
        }
        
        private void InitializeCostChart()
        {
            costChart = new Chart();
            costChart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            costChart.ChartAreas.Add(chartArea);

            costChart.Titles.Add("Cost Analysis");
            costChart.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);
            

            Legend legend = new Legend();
            costChart.Legends.Add(legend);

       
            Series maintenanceCostSeries = new Series("Maintenance Cost");
            Series fuelCostSeries = new Series("Fuel Cost");
            Series futureMaintSeries = new Series("Future Maintenance");

        
            maintenanceCostSeries.ChartType = SeriesChartType.Line;
            fuelCostSeries.ChartType = SeriesChartType.Line;
            futureMaintSeries.ChartType = SeriesChartType.Line;

            
            costChart.Series.Add(maintenanceCostSeries);
            costChart.Series.Add(fuelCostSeries);
            costChart.Series.Add(futureMaintSeries);

           

            chartArea.AxisX.Title = "Months";
            chartArea.AxisX.Interval = 1; 
            chartArea.AxisX.LabelStyle.Format = "MMM"; 

            
            chartArea.AxisY.Title = "Cost";
            chartArea.AxisY.Interval = 10000;


            panel4.Controls.Add(costChart);
        }


        private async void LoadDashboardData()
        {
            try
            {
                DashboardData data = await dataFetcher.FetchDashboardDataAsync();
                UpdateDashboardLabels(data);
                await LoadCostChartData();
                AlertBtn.Text = $"Maintenance Alerts : {await GetMaintenanceAlertsCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void UpdateDashboardLabels(DashboardData data)
        {
         
            TotalVehicleCount.Text = $"Total Vehicles: {data.TotalVehicleCount}";
            IncidentVehicleCount.Text = $"Incident Vehicles: {data.IncidentVehicleCount}";
            AssignedVehiclesCount.Text = $"Assigned Vehicles: {data.AssignedVehiclesCount}";
            UnassignedVehiclesCount.Text = $"Unassigned Vehicles: {data.UnassignedVehiclesCount}";
            MaintenanceAvailableVehiclesCount.Text = $"Maintenance Available: {data.MaintenanceAvailableVehiclesCount}";
            TotalDriverCount.Text = $"Total Drivers: {data.TotalDriverCount}";
            ActiveDriverCount.Text = $"Active Drivers: {data.ActiveDriverCount}";
            InactiveDriverCount.Text = $"Inactive Drivers: {data.InactiveDriverCount}";
            AssignedDriverCount.Text = $"Assigned Drivers: {data.AssignedDriverCount}";
            YearlyIncidentCount.Text = $"Yearly Incidents: {data.YearlyIncidentCount}";
            MonthlyIncidentCount.Text = $"Monthly Incidents: {data.MonthlyIncidentCount}";
            DailyIncidentCount.Text = $"Daily Incidents: {data.DailyIncidentCount}";
        }

        private async Task LoadCostChartData()
        {
            try
            {
                await db.Connect();

                string query = @"
                    SELECT 
    DATE_FORMAT(c.Date, '%Y-%m') AS Month,
    SUM(CASE WHEN c.Type = 'Fuel' THEN c.Amount ELSE 0 END) AS FuelCost,
    SUM(CASE WHEN c.Type = 'Maintenance' THEN c.Amount ELSE 0 END) AS MaintenanceCost,
    SUM(CASE 
            WHEN ma.OdometerAtAlert IS NOT NULL 
         THEN ma.OdometerAtAlert 
         ELSE 0 
        END
    ) AS FutureMaintCost
FROM 
    costs c
LEFT JOIN 
    maintenancealerts ma ON DATE_FORMAT(c.Date, '%Y-%m') = DATE_FORMAT(ma.DateGenerated, '%Y-%m')
LEFT JOIN 
    vehiclemaintenance vm ON ma.VehicleID = vm.VehicleID
GROUP BY 
    DATE_FORMAT(c.Date, '%Y-%m')
ORDER BY 
    DATE_FORMAT(c.Date, '%Y-%m')
LIMIT 12;
";

                using (MySqlDataReader reader = await db.ExecuteQuery(query))
                {
                    costChart.Series["Maintenance Cost"].Points.Clear();
                    costChart.Series["Fuel Cost"].Points.Clear();
                    costChart.Series["Future Maintenance"].Points.Clear();

                    while (await reader.ReadAsync())
                    {
                        string month = reader.GetString(0);
                        double fuelCost = reader.GetDouble(1);
                        double maintenanceCost = reader.GetDouble(2);
                        double futureMaintCost = reader.GetDouble(3);

                        costChart.Series["Maintenance Cost"].Points.AddXY(month, maintenanceCost);
                        costChart.Series["Fuel Cost"].Points.AddXY(month, fuelCost);
                        costChart.Series["Future Maintenance"].Points.AddXY(month, futureMaintCost);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cost chart data: " + ex.Message);
            }
            finally
            {
                db.Disconnect();
            }
        }

        private async Task<int> GetMaintenanceAlertsCount()
        {
            try
            {
                await db.Connect();
                string query = "SELECT COUNT(*) FROM maintenancealerts WHERE isFixed = False";
                using (MySqlDataReader reader = await db.ExecuteQuery(query))
                {
                    if (await reader.ReadAsync())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting maintenance alerts count: " + ex.Message);
            }
            finally
            {
                db.Disconnect();
            }
            return 0;
        }

     
        private void label1_Click(object sender, EventArgs e) { }
        private void metroPanel1_Paint(object sender, PaintEventArgs e) { }
        private void metroPanel3_Paint(object sender, PaintEventArgs e) { }
        private void metroPanel4_Paint(object sender, PaintEventArgs e) { }
        private void AlertBtn_Click(object sender, EventArgs e) 
        {
            MaintenanceAlertForm maf = new MaintenanceAlertForm();
            maf.Show();
        }
        private void metroPanel5_Paint(object sender, PaintEventArgs e) { }
        private void metroPanel2_Paint(object sender, PaintEventArgs e) { }
        private void DashbordElements_Load(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void Header2_Paint(object sender, PaintEventArgs e) { }
        private void metroDateTime1_ValueChanged(object sender, EventArgs e) { }
        private void h2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void TotalVehicleCount_Click(object sender, EventArgs e) { }
        private void IncidentVehicleCount_Click(object sender, EventArgs e) { }
        private void AssignedVehiclesCount_Click(object sender, EventArgs e) { }
        private void UnassignedVehiclesCount_Click(object sender, EventArgs e) { }
        private void MaintenanceAvailableVehiclesCount_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void MonthlyIncidentCount_Click(object sender, EventArgs e) { }
        private void YearlyIncidentCount_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void TotalDriverCount_Click(object sender, EventArgs e) { }
        private void InactiveDriverCount_Click(object sender, EventArgs e) { }
        private void ActiveDriverCount_Click(object sender, EventArgs e) { }
        private void AssignedDriverCount_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
