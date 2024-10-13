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

        public DriverInfo()
        {
            InitializeComponent();
            db = new Dbcon();
            this.Load += new EventHandler(FormDrivers_Load);
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

                string query = "SELECT \r\n    d.DriverID,\r\n    d.FullName,\r\n    d.LicenseNumber,\r\n    d.DateOfBirth,\r\n    d.HireDate,\r\n    d.Status,\r\n    v.VehicleID,\r\n    v.Make,\r\n    v.Model,\r\n    v.Year,\r\n    v.LicensePlate,\r\n    va.AssignmentDate,\r\n    va.ReturnDate,\r\n    ir.IncidentID,\r\n    ir.IncidentDate,\r\n    ir.Description AS IncidentDescription,\r\n    ir.DamageCost\r\nFROM \r\n    drivers d\r\nLEFT JOIN vehicleassignments va ON d.DriverID = va.DriverID\r\nLEFT JOIN vehicles v ON va.VehicleID = v.VehicleID\r\nLEFT JOIN incidentreports ir ON d.DriverID = ir.DriverID\r\nWHERE \r\n    d.DriverID = 1 \r\nORDER BY \r\n    va.AssignmentDate DESC, ir.IncidentDate DESC;";


                MySqlDataReader reader = await db.ExecuteQuery(query);

                if (!reader.HasRows)
                {

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
    }
}
