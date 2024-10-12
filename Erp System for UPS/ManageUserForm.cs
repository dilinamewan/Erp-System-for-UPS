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
    public partial class ManageUserForm : Form
    {
        private readonly Dbcon db;
        public ManageUserForm()
        {
            InitializeComponent();
            db = new Dbcon();
        }
        private async void FormDrivers_Load(object sender, EventArgs e)
        {
            await LoadDriversData();
        }

        // Method to load drivers data into DataGridView
        private async Task LoadDriversData()
        {
            try
            {
                // Connect to the database
                await db.Connect();

                // Query to fetch all drivers
                string query = "SELECT DriverID, FullName, LicenseNumber, DateOfBirth, HireDate, Status FROM Drivers";

                // Execute the query and retrieve the data
                MySqlDataReader reader = await db.ExecuteQuery(query);

                // Create a DataTable to hold the drivers data
                DataTable driversTable = new DataTable();
                driversTable.Load(reader);

                // Bind the DataTable to the DataGridView
                dataGridViewDrivers.DataSource = driversTable;
                Console.WriteLine(driversTable.Rows.Count);

                // Close the reader and disconnect from the database
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.Disconnect();  // Ensure the connection is closed
            }
        }

            private void ManageUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
