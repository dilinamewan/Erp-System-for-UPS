using System.Collections.Generic;
using System.Windows.Forms;
using System;

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Erp_System_for_UPS
{
    public partial class TrackingForm : Form
    {
        private readonly Dbcon _dbcon;
        private Panel panelPackageDetails;

        public TrackingForm()
        {
            InitializeComponent();
            _dbcon = new Dbcon();
            InitializePackageDetailsPanel();
        }

        private void InitializePackageDetailsPanel()
        {

            panelPackageDetails = new Panel
            {
                Location = new System.Drawing.Point(15, 100),
                Size = new System.Drawing.Size(600, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };

            this.Controls.Add(panelPackageDetails);
        }

        private async void btnTrack_Click(object sender, EventArgs e)
        {
            string packageId = textBoxPackageID.Text.Trim();

            if (string.IsNullOrEmpty(packageId))
            {
                MessageBox.Show("Please enter a valid Package ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _dbcon.Connect();

                string query = "SELECT CurrentLocation, Status, Destination, Weight, Sender, Recipient, CreationDate, EstimatedDeliveryDate " +
                               "FROM Packagestracker WHERE PackageID = @PackageID";

                var parameters = new Dictionary<string, object>
        {
            { "@PackageID", packageId }
        };

                using (var reader = await _dbcon.ExecuteQuery(query, parameters))
                {
                    if (await reader.ReadAsync())
                    {
                        
                        label2.Text = string.Empty;
                        string packageDetails =
                            $"{"Current Location:",-24}          {reader["CurrentLocation"]}\n" +
                            $"{"Status:",-25}                {reader["Status"]}\n" +
                            $"{"Destination:",-25}             {reader["Destination"]}\n" +
                            $"{"Weight (kg):",-25}            {Convert.ToDouble(reader["Weight"])}\n" +
                            $"{"Sender:",-25}              {reader["Sender"]}\n" +
                            $"{"Recipient:",-25}              {reader["Recipient"]}\n" +
                            $"{"Creation Date:",-25}          {Convert.ToDateTime(reader["CreationDate"]).ToShortDateString()}\n" +
                            $"{"Estimated Delivery Date:",-25}    {Convert.ToDateTime(reader["EstimatedDeliveryDate"]).ToShortDateString()}";



                        label2.Text = packageDetails;

                        
                        label2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Package not found. Please check the Package ID and try again.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving package details:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dbcon.Disconnect();
            }
        }

        private void DisplayPackageDetail(string label, string value)
        {
         
        }


        private void textBoxPackageID_TextChanged(object sender, EventArgs e)
        {

            panelPackageDetails.Controls.Clear();
            panelPackageDetails.Visible = false;
        }

        private void btnClose_Click(object senderForClose, EventArgs e)
        {
            this.Close();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {

        }

        private void labelPackageID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPackageID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}