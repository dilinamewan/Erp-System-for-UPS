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
    public partial class Dashbord : Form
    {

        public Dashbord()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alert_Click(object sender, EventArgs e)
        {
            LoadForm(new MaintenanceAlertForm());
        }
        bool MenueExpand = false;
        private void MenuTransision_Tick(object sender, EventArgs e)
        {
            if (MenueExpand == true)
            {
                PackageTracking.Location = new Point(PackageTracking.Location.X, PackageTracking.Location.Y + 10);
                VehicleMenu.Height += 10;
                if (VehicleMenu.Height >= 210)
                {
                    MenuTransision.Stop();
                    MenueExpand = false;
                }
            }
            else
            {
                VehicleMenu.Height -= 10;
                PackageTracking.Location = new Point(PackageTracking.Location.X, PackageTracking.Location.Y - 10);
                if (VehicleMenu.Height <= 60)
                {
                    MenuTransision.Stop();
                    MenueExpand = true;
                }
            }


        }
        private void ManageVehicles_Click(object sender, EventArgs e)
        {
            MenuTransision.Start();
        }

        private void ManageDrivers_Click(object sender, EventArgs e)
        {
            LoadForm(new ManageUserForm());
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Show a message indicating successful logout
                MessageBox.Show("Logged out successfully!", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open the login form
                Form1 loginForm = new Form1();
                loginForm.Show();

                // Close the current form (main dashboard or the form where logout is being triggered)
                this.Close();
            }
        }

        private void VehicleMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(fh);
            this.MainPanel.Tag = fh;
            fh.Show();
        }

        private void AllVehicles_Click(object sender, EventArgs e)
        {
            LoadForm(new AllVehicleForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrackingForm trackingForm = new TrackingForm();
            trackingForm.Show();
        }
    }
}
