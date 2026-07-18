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
    using OMC_Group16.Classes;
    using OMC_Group16.Forms;
    using System.Data.SqlClient;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class FrmCaregiverLogin : Form
    {
        string connectionString =
        @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";

        public static int CaregiverID;
        public static string CaregiverName;

        public FrmCaregiverLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query = "SELECT * FROM Caregivers WHERE Username=@username AND Password=@password";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                UserSession.CaregiverID = Convert.ToInt32(reader["CaregiverID"]);
                UserSession.CaregiverName = reader["CaregiverName"].ToString();
                
                MessageBox.Show("Saved name :"+UserSession.CaregiverName);

                FrmCaregiverMenu dashboard = new FrmCaregiverMenu();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();

        }


        private bool AuthenticateCareGiver(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }
            return false;

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FrmCreateAccount createAccountForm = new FrmCreateAccount();
            createAccountForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmWelcome welcomeForm = new FrmWelcome();
            welcomeForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
