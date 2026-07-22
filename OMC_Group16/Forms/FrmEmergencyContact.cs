using OMC_Group16.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmEmergencyContact : Form
    {
        string connectionString =
         @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";
        public FrmEmergencyContact()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if (cmbContact.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an emergency contact first.",
                    "Reminder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            string phoneNumber = lblPhoneNumber.Text;


            // Put your calling code here
            MessageBox.Show(
                "Calling " + phoneNumber,
                "Call",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );


        }
        private void LoadEmergencyContact()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT EmergencyContactID,
                                ContactName,
                                Relationship,
                                PhoneNumber
                         FROM EmergencyContacts";
                        // WHERE PatientID = @PatientID";



                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@PatientID", UserSession.PatientID);

                DataTable dt = new DataTable();
                da.Fill(dt);


                

                cmbContact.DataSource = dt;
                cmbContact.DisplayMember = "ContactName";
                cmbContact.ValueMember = "EmergencyContactID";
            }
        }
        private void FrmEmergencyContact_Load(object sender, EventArgs e)
        {
            LoadEmergencyContact();
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbContact.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cmbContact.SelectedItem;

                lblContactName.Text = row["ContactName"].ToString();
                lblRelationship.Text = row["Relationship"].ToString();
                lblPhoneNumber.Text = row["PhoneNumber"].ToString();
            }
        }
    }
}
