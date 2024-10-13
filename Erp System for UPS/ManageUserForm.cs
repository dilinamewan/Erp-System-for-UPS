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
            this.Load += new EventHandler(FormDrivers_Load);
        }

        private async void FormDrivers_Load(object sender, EventArgs e)
        {
            await LoadDriversData();
            AddButtonColumn();
        }

        private async Task LoadDriversData()
        {
            try
            {
                await db.Connect();
                string query = "SELECT DriverID, FullName, LicenseNumber, DateOfBirth, HireDate, Status FROM Drivers";
                MySqlDataReader reader = await db.ExecuteQuery(query);
                if (!reader.HasRows)
                {
                    return;
                }
                DataTable driversTable = new DataTable();
                driversTable.Load(reader);
                dataGridViewDrivers.DataSource = driversTable;
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
            dataGridViewDrivers.Columns.Add(buttonColumn);
            dataGridViewDrivers.CellClick += new DataGridViewCellEventHandler(DataGridViewDrivers_CellClick);
        }

        public void DataGridViewDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                var cell = dataGridViewDrivers.Rows[e.RowIndex].Cells["DriverID"];
                var cell1 = dataGridViewDrivers.Rows[e.RowIndex].Cells["FullName"];
                if (cell != null)
                {
                    int driverId = Convert.ToInt32(cell.Value);
                    string driverName = Convert.ToString(cell1.Value);
                    DriverInfo driverInfoForm = new DriverInfo(driverId, driverName);
                    driverInfoForm.Show();
                }
            
        }
        private void ManageUserForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}