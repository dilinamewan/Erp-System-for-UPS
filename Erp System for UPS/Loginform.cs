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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxpass.Checked == true)
            {
                textBoxpass.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxpass.UseSystemPasswordChar = true;
            }
        }

        private void textBoxpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblclear_Click(object sender, EventArgs e)
        {
            textBoxname.Clear();
            textBoxpass.Clear();
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {
            // Add your code here
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Add your code here
        }
    }
}