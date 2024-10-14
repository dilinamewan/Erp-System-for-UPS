using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erp_System_for_UPS
{
    public partial class MaintenanceAlertForm : Form
    {
        private readonly Dbcon db;

        public MaintenanceAlertForm()
        {
            InitializeComponent();
            db = new Dbcon();
            this.Load += new EventHandler(MaintenanceAlertForm_Load);
        }

        private async void MaintenanceAlertForm_Load(object sender, EventArgs e)
        {
            await LoadMaintenanceAlerts();
            AddButtonColumn();
        }

        private void AddButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Actions",
                Text = "Fixed",
                UseColumnTextForButtonValue = true
            };
            dataGridViewAlerts.Columns.Add(buttonColumn);
            dataGridViewAlerts.CellClick += new DataGridViewCellEventHandler(dataGridViewAlerts_CellClick);

            // Set initial row colors
            SetInitialRowColors();
        }

        public void SetInitialRowColors()
        {
            foreach (DataGridViewRow row in dataGridViewAlerts.Rows)
            {
                bool isFixed = Convert.ToBoolean(row.Cells["IsFixed"].Value);
                row.DefaultCellStyle.BackColor = isFixed ? Color.LightGreen : Color.LightPink;
            }
        }

        public async void dataGridViewAlerts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int alertId = Convert.ToInt32(dataGridViewAlerts.Rows[e.RowIndex].Cells["AlertID"].Value);
                bool currentStatus = Convert.ToBoolean(dataGridViewAlerts.Rows[e.RowIndex].Cells["IsFixed"].Value);
                bool newStatus = !currentStatus;

                // Prompt user for confirmation
                string message = newStatus ? "Mark this alert as Fixed?" : "Undo the Fixed status for this alert?";
                DialogResult result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Update the database
                    if (await UpdateAlertStatus(alertId, newStatus))
                    {
                        // Update the DataGridView
                        dataGridViewAlerts.Rows[e.RowIndex].Cells["IsFixed"].Value = newStatus;
                        dataGridViewAlerts.Rows[e.RowIndex].DefaultCellStyle.BackColor = newStatus ? Color.LightGreen : Color.LightPink;
                        //dataGridViewAlerts.Rows[e.RowIndex].Cells["Actions"].Value = newStatus ? "Undo" : "Fixed"; // Toggle button text
                    }
                }
            
        }

        public async Task<bool> UpdateAlertStatus(int alertId, bool isFixed)
        {
            try
            {
                await db.Connect();

                string query = "UPDATE maintenancealerts SET IsFixed = @IsFixed WHERE AlertID = @AlertID";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@IsFixed", isFixed },
                    { "@AlertID", alertId }
                };

                int rowsAffected = await db.ExecuteNonQuery(query, parameters);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating alert status: " + ex.Message);
                return false;
            }
            finally
            {
                db.Disconnect();
            }
        }

        private async Task LoadMaintenanceAlerts()
        {
            try
            {
                await db.Connect();

                string query = @"
                    SELECT 
                        ma.AlertID,
                        v.VehicleID,
                        v.Make,
                        v.Model,
                        v.Year,
                        v.LicensePlate,
                        ma.AlertType,
                        ma.OdometerAtAlert,
                        ma.DateGenerated,
                        ma.IsFixed
                    FROM 
                        maintenancealerts ma
                    JOIN
                        vehicles v ON ma.VehicleID = v.VehicleID
                    ORDER BY 
                        ma.DateGenerated DESC";

                MySqlDataReader reader = await db.ExecuteQuery(query);

                if (!reader.HasRows)
                {
                    MessageBox.Show("No maintenance alerts found.");
                    return;
                }

                DataTable alertsTable = new DataTable();
                alertsTable.Load(reader);
                dataGridViewAlerts.DataSource = alertsTable;

                reader.Close();

                // Set initial row colors after loading data
                SetInitialRowColors();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
