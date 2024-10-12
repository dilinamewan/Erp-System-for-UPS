using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erp_System_for_UPS
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=localhost;Database=ups;Uid=root;Pwd=;";
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
            string username = textBoxname.Text;
            string password = textBoxpass.Text;
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // You can redirect to the main dashboard here
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to authenticate the user by checking the SQL Server database
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (var db = new DbConnection(connectionString))
                {
                    db.Open();
                    string query = "SELECT COUNT(1) FROM users WHERE UserName = @UserName AND Password = @Password";

                    // Define parameters
                    SqlParameter[] parameters = {
                        new SqlParameter("@UserName", username),
                        new SqlParameter("@Password", password)
                    };

                    // Execute the query
                    DataTable result = db.ExecuteQuery(query, parameters);

                    // Check if any record was returned
                    if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) == 1)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
            

        
    

