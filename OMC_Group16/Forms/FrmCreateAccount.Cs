using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmCreateAccount : Form
    {
        SqlConnection con = new SqlConnection(
        @"Data Source=(localdb)\MSSQLLocalDB;
         Initial Catalog=OMC_SeniorConnectDB;
         Integrated Security=True");
        public FrmCreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

           using (SqlConnection conn = new SqlConnection(
             @"Data Source=(localdb)\MSSQLLocalDB;
             Initial Catalog=OMC_SeniorConnectDB;
             Integrated Security=True"))
            {
                string query = "INSERT INTO Caregivers (CaregiverName,PhoneNumber3,Relationship,Username,Password) VALUES (@name,@phone,@relation,@user,@password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@id",1);
                cmd.Parameters.AddWithValue("@name", txtCaregiverName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@relation", cmbRelationship.Text);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account created successfully! You can now log in.");

                    FrmCaregiverLogin login = new FrmCaregiverLogin();
                    login.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
    }

