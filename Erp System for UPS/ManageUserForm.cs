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
        private void ManageUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
