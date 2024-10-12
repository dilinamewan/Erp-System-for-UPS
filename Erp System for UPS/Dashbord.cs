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

        }
        bool MenueExpand = false;
        private void MenuTransision_Tick(object sender, EventArgs e)
        {
            if (MenueExpand == true)
            {
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

        }

        private void LogOut_Click(object sender, EventArgs e)
        {

        }

        private void VehicleMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
