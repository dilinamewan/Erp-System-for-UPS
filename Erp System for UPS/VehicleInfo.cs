using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace Erp_System_for_UPS
{
    public partial class VehicleInfo : Form
    {
        private readonly Dbcon db;
        public int vehicleId;
        public string vehicleName;

        // Create a WebView2 control
        private WebView2 webViewMap;

        public VehicleInfo(int vehicleId, string vehicleName)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;
            db = new Dbcon();
            this.Load += new EventHandler(FormVehicle_Load);
            this.vehicleName = vehicleName;
            VehicleVIN.Text = vehicleName;

            // Initialize WebView2
            InitializeWebView2();
        }

        private async void FormVehicle_Load(object sender, EventArgs e)
        {
            await LoadVehicleData();
        }

        private async Task LoadVehicleData()
        {
            try
            {
                await db.Connect();
                string query = @"
                SELECT 
                    v.VehicleID,
                    v.VIN,
                    v.LicensePlate,
                    v.Make,
                    v.Model,
                    v.Year,
                    v.OdometerReading,
                    v.FuelType,
                    v.PurchaseDate,
                    v.Status,
                    d.FullName AS AssignedDriver,
                    va.AssignmentDate,
                    va.ReturnDate,
                    c.InspectionDate,
                    c.InspectionType,
                    c.InsuranceExpiryDate,
                    c.RegistrationExpiryDate,
                    c.Passed AS CompliancePassed,
                    co.Type AS CostType,
                    co.Amount AS CostAmount,
                    co.Date AS CostDate,
                    f.Date AS FuelUsageDate,
                    f.FuelConsumed,
                    f.DistanceTraveled,
                    f.FuelCost,
                    ir.IncidentDate,
                    ir.Description AS IncidentDescription,
                    ir.DamageCost,
                    ir.InsuranceClaimSubmitted,
                    ma.AlertType,
                    ma.DateGenerated AS AlertDate,
                    rl.Timestamp AS LastLocationTimestamp,
                    rl.Latitude,
                    rl.Longitude,
                    rl.Speed,
                    vm.ServiceType,
                    vm.ServiceDate,
                    vm.Cost AS MaintenanceCost,
                    vm.NextServiceMileage,
                    vm.Notes AS MaintenanceNotes
                FROM 
                    vehicles v
                LEFT JOIN vehicleassignments va ON v.VehicleID = va.VehicleID
                LEFT JOIN drivers d ON va.DriverID = d.DriverID
                LEFT JOIN compliance c ON v.VehicleID = c.VehicleID
                LEFT JOIN costs co ON v.VehicleID = co.VehicleID
                LEFT JOIN fuelusage f ON v.VehicleID = f.VehicleID
                LEFT JOIN incidentreports ir ON v.VehicleID = ir.VehicleID
                LEFT JOIN maintenancealerts ma ON v.VehicleID = ma.VehicleID
                LEFT JOIN realtimelocation rl ON v.VehicleID = rl.VehicleID
                LEFT JOIN vehiclemaintenance vm ON v.VehicleID = vm.VehicleID
                WHERE 
                    v.VehicleID = @VehicleID 
                ORDER BY 
                    va.AssignmentDate DESC, 
                    c.InspectionDate DESC, 
                    co.Date DESC, 
                    f.Date DESC, 
                    ir.IncidentDate DESC, 
                    ma.DateGenerated DESC, 
                    rl.Timestamp DESC, 
                    vm.ServiceDate DESC;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@VehicleID", vehicleId }
                };

                MySqlDataReader reader = await db.ExecuteQuery(query, parameters);

                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found for the selected vehicle.");
                    return;
                }

                DataTable vehicleTable = new DataTable();
                vehicleTable.Load(reader);
                dataGridViewVehicle.DataSource = vehicleTable;
                
                

                if (vehicleTable.Rows.Count > 0)
                {
                    // Extract latitude and longitude values
                    if (double.TryParse(vehicleTable.Rows[0]["Latitude"].ToString(), out double latitude) &&
                        double.TryParse(vehicleTable.Rows[0]["Longitude"].ToString(), out double longitude))
                    {
                        // Load Google Maps with the latitude and longitude
                        LoadGoogleMap(latitude, longitude);
                    }
                    else
                    {
                        MessageBox.Show("Invalid latitude or longitude values.");
                    }
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Disconnect();
            }
        }

        private void LoadGoogleMap(double latitude, double longitude)
        {
            // Construct the Google Maps URL
            string url = $"https://www.google.com/maps/@{latitude},{longitude},15z";

            // Load the URL in the WebView2 control
            webViewMap.Source = new Uri(url);
        }

        private async void InitializeWebView2()
        {
            // Create and initialize WebView2 control
            webViewMap = new WebView2
            {
                Dock = DockStyle.Bottom, // Dock at the bottom
                Height = 350,
                Width = 200// Set a fixed height for the map
            };

            // Add WebView2 to the form
            this.Controls.Add(webViewMap);

            // Ensure the WebView2 is properly initialized
            await webViewMap.EnsureCoreWebView2Async(null);
        }

        private void VehicleInfo_Load(object sender, EventArgs e)
        {
            // You can add any additional load logic here
        }

        private void VehicleName_Click(object sender, EventArgs e)
        {
            // Event handler if needed
        }

        private void dataGridViewVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}