using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erp_System_for_UPS
{
    

    public partial class DriverInfo : Form
    {
        private readonly Dbcon db;
        public int driverId;
        public string driverName;

        public DriverInfo(int driverId, string driverName)
        {
            InitializeComponent();
            this.driverId = driverId;
            db = new Dbcon();
            this.Load += new EventHandler(FormDrivers_Load);
            this.driverName = driverName;
            DriverName.Text = driverName;
        }
        

        private async void FormDrivers_Load(object sender, EventArgs e)
        {
            await LoadDriversData();
        }

        private async Task LoadDriversData()
        {
            try
            {
                await db.Connect();
                string query = @"
                SELECT 
                    d.DriverID,
                    d.FullName,
                    d.LicenseNumber,
                    d.DateOfBirth,
                    d.HireDate,
                    d.Status,
                    v.VehicleID,
                    v.Make,
                    v.Model,
                    v.Year,
                    v.LicensePlate,
                    va.AssignmentDate,
                    va.ReturnDate,
                    ir.IncidentID,
                    ir.IncidentDate,
                    ir.Description AS IncidentDescription,
                    ir.DamageCost
                FROM 
                    drivers d
                LEFT JOIN vehicleassignments va ON d.DriverID = va.DriverID
                LEFT JOIN vehicles v ON va.VehicleID = v.VehicleID
                LEFT JOIN incidentreports ir ON d.DriverID = ir.DriverID
                WHERE 
                    d.DriverID = @DriverID 
                ORDER BY 
                    va.AssignmentDate DESC, ir.IncidentDate DESC;";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@DriverID", driverId }
                };
                MySqlDataReader reader = await db.ExecuteQuery(query, parameters);
                if (!reader.HasRows)
                {
                    MessageBox.Show("No data found for the selected driver.");
                    return;
                }
                DataTable driversTable = new DataTable();
                driversTable.Load(reader);
                dataGridViewDriver.DataSource = driversTable;
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

        private void DriverInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void DriverName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDriver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}