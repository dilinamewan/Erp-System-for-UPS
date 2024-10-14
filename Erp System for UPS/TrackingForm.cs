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

                        panelPackageDetails.Controls.Clear();


                        DisplayPackageDetail("Current Location", reader["CurrentLocation"].ToString());
                        DisplayPackageDetail("Status", reader["Status"].ToString());
                        DisplayPackageDetail("Destination", reader["Destination"].ToString());
                        DisplayPackageDetail("Weight (kg)", Convert.ToDouble(reader["Weight"]).ToString());
                        DisplayPackageDetail("Sender", reader["Sender"].ToString());
                        DisplayPackageDetail("Recipient", reader["Recipient"].ToString());
                        DisplayPackageDetail("Creation Date", Convert.ToDateTime(reader["CreationDate"]).ToShortDateString());
                        DisplayPackageDetail("Estimated Delivery Date", Convert.ToDateTime(reader["EstimatedDeliveryDate"]).ToShortDateString());

                        panelPackageDetails.Visible = true;
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
            int currentHeight = panelPackageDetails.Controls.Count * 20;


            var labelTitle = new Label
            {
                Text = $"{label}:",
                Location = new System.Drawing.Point(10, currentHeight),
                Size = new System.Drawing.Size(150, 15), // Reduced height
                Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold)
            };


            var labelValue = new Label
            {
                Text = value,
                Location = new System.Drawing.Point(160, currentHeight),
                Size = new System.Drawing.Size(400, 15),
                Font = new System.Drawing.Font("Arial", 8)
            };

            panelPackageDetails.Controls.Add(labelTitle);
            panelPackageDetails.Controls.Add(labelValue);
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

        private void textBoxPackageID_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
