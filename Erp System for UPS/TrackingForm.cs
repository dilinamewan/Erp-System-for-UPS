using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Erp_System_for_UPS
{
    public partial class TrackingForm : Form
    {
        private readonly Dbcon _dbcon;
        private Panel panelPackageDetails; // Panel to hold the package details

        public TrackingForm()
        {
            InitializeComponent();
            _dbcon = new Dbcon(); // Initialize your database connection class
            InitializePackageDetailsPanel(); // Initialize the panel for package details
        }

        private void InitializePackageDetailsPanel()
        {
            // Initialize the panel to hold package details
            panelPackageDetails = new Panel
            {
                Location = new System.Drawing.Point(15, 100),
                Size = new System.Drawing.Size(600, 300),
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false // Hide initially until data is loaded
            };

            this.Controls.Add(panelPackageDetails);
        }

        private async void btnTrack_Click(object sender, EventArgs e)
        {
            string packageId = textBoxPackageID.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(packageId))
            {
                MessageBox.Show("Please enter a valid Package ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Connect to the database and retrieve package details
            try
            {
                await _dbcon.Connect(); // Connect to the database

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
                        // Clear any existing controls inside the panel
                        panelPackageDetails.Controls.Clear();

                        // Display package details using labels with reduced spacing
                        DisplayPackageDetail("Current Location", reader["CurrentLocation"].ToString());
                        DisplayPackageDetail("Status", reader["Status"].ToString());
                        DisplayPackageDetail("Destination", reader["Destination"].ToString());
                        DisplayPackageDetail("Weight (kg)", Convert.ToDouble(reader["Weight"]).ToString());
                        DisplayPackageDetail("Sender", reader["Sender"].ToString());
                        DisplayPackageDetail("Recipient", reader["Recipient"].ToString());
                        DisplayPackageDetail("Creation Date", Convert.ToDateTime(reader["CreationDate"]).ToShortDateString());
                        DisplayPackageDetail("Estimated Delivery Date", Convert.ToDateTime(reader["EstimatedDeliveryDate"]).ToShortDateString());

                        panelPackageDetails.Visible = true; // Show the panel with the package details
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
                _dbcon.Disconnect(); // Ensure to disconnect
            }
        }

        private void DisplayPackageDetail(string label, string value)
        {
            int currentHeight = panelPackageDetails.Controls.Count * 20; // Adjust this value to reduce the space between details

            // Create a label for the title (shorter height)
            var labelTitle = new Label
            {
                Text = $"{label}:",
                Location = new System.Drawing.Point(10, currentHeight),
                Size = new System.Drawing.Size(150, 15), // Reduced height
                Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold) // Smaller font size
            };

            // Create a label for the value (shorter height)
            var labelValue = new Label
            {
                Text = value,
                Location = new System.Drawing.Point(160, currentHeight),
                Size = new System.Drawing.Size(400, 15), // Reduced height
                Font = new System.Drawing.Font("Arial", 8) // Smaller font size
            };

            // Add the labels to the panel
            panelPackageDetails.Controls.Add(labelTitle);
            panelPackageDetails.Controls.Add(labelValue);
        }


        private void textBoxPackageID_TextChanged(object sender, EventArgs e)
        {
            // Clear the panel when the text changes
            panelPackageDetails.Controls.Clear();
            panelPackageDetails.Visible = false; // Hide the panel until there's a result
        }

        private void btnClose_Click(object senderForClose, EventArgs e)
        {
            this.Close();
        }

        private void TrackingForm_Load(object sender, EventArgs e)
        {
            // Optional: Perform any initialization needed when the form loads
        }

        private void labelPackageID_Click(object sender, EventArgs e)
        {

        }
    }
}
