using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Erp_System_for_UPS
{
    public partial class Form1 : Form
    {
        private readonly Dbcon db;
        public Form1()
        {
            InitializeComponent();
            db = new Dbcon();
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
            if (checkBoxpass.Checked)
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
        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            string username = textBoxname.Text;
            string password = textBoxpass.Text;
            if (await AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Redirect to Dashboard
                Dashbord dashboard = new Dashbord();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to authenticate the user by checking the MySQL database
        private async Task<bool> AuthenticateUser(string username, string password)
        {
            try
            {
                await db.Connect();

                string query = "SELECT COUNT(1) FROM users WHERE UserName = @UserName AND Password = @Password";

                // Define parameters
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@UserName", username },
                    { "@Password", password }
                };

                // Execute the query using ExecuteScalar to get a single value (the count)
                object result = await db.ExecuteScalar(query, parameters);

                // Convert the result to an integer and check if it's equal to 1
                if (result != null && Convert.ToInt32(result) == 1)
                {
                    return true;
                }
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
            return false;
        }
    }
}
