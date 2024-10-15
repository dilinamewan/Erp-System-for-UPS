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
    public partial class AllVehicleForm : Form
    {
        private readonly Dbcon db;
        public AllVehicleForm()
        {
            InitializeComponent();
            db = new Dbcon();
            this.Load += new EventHandler(FormVehicles_Load);
        }
        private async void FormVehicles_Load(object sender, EventArgs e)
        {
            await LoadVehicleData();
            AddButtonColumn();
        }

        private async Task LoadVehicleData()
        {
            try
            {
                await db.Connect();
                string query = "SELECT \r\n    VehicleID,\r\n    VIN,\r\n    LicensePlate,\r\n    Make,\r\n    Model,\r\n    Year,\r\n    OdometerReading,\r\n    FuelType,\r\n    PurchaseDate,\r\n    Status\r\nFROM \r\n    vehicles";
                MySqlDataReader reader = await db.ExecuteQuery(query);
                if (!reader.HasRows)
                {
                    return;
                }
                DataTable vehiclesTable = new DataTable();
                vehiclesTable.Load(reader);
                dataGridViewVehicles.DataSource = vehiclesTable;
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
        public void AddButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Details";
            buttonColumn.Text = "View Info";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataGridViewVehicles.Columns.Add(buttonColumn);
            dataGridViewVehicles.CellClick += new DataGridViewCellEventHandler(dataGridViewVehicles_CellClick);
        }

        public void dataGridViewVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            var cell = dataGridViewVehicles.Rows[e.RowIndex].Cells["VehicleID"];
            var cell1 = dataGridViewVehicles.Rows[e.RowIndex].Cells["VIN"];
            if (cell != null)
            {
                int vehicleId = Convert.ToInt32(cell.Value);
                string VIN = Convert.ToString(cell1.Value);
                VehicleInfo vehicleInfo = new VehicleInfo(vehicleId, VIN);
                vehicleInfo.ShowDialog();

            }

        }


        private void AllVehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
