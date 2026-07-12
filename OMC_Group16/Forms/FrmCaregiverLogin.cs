using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16
{
    using System.Data.SqlClient;
    public partial class FrmCaregiverLogin : Form
    {
        string connectionString = "Server=YOUR_SERVER;Database=CaregiverDB;Integrated Security=True;";
        public FrmCaregiverLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateCareGiver(username, password))
            {
                MessageBox.Show("Login Successful!");

                FrmCaregiverMenu dashboard = new FrmCaregiverMenu();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Password or Username. Please Try Again.");
            }
        }


        private bool AuthenticateCareGiver(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Caregivers WHERE Username = @user AND Password = @pass";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", password);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
