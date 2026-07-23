using Microsoft.VisualBasic;
using OMC_Group16.Classes;
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
    public partial class FrmAddReminder : Form
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OMC_SeniorConnectDB;Integrated Security=True;";
        public FrmAddReminder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"INSERT INTO Reminders
                        (PatientID,  CaregiverID, Title, ReminderDate, Description)
                        VALUES
                        (@PatientID, @CaregiverID, @Title, @Date, @Description)";

                SqlCommand cmd = new SqlCommand(query, con);

                int patientID = Convert.ToInt32(cboPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@PatientID", patientID);
                cmd.Parameters.AddWithValue("@CaregiverID", UserSession.CaregiverID);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Date", dtpReminderDate.Value.Date);
                cmd.Parameters.AddWithValue("@Description", txtReminderDescription.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Reminder saved successfully.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoiceAssistant_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            FrmCaregiverMenu menu = new FrmCaregiverMenu();
            menu.Show();
            this.Hide();
        }

        private void txtReminderDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadElderly()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT PatientID, FullName FROM Seniors WHERE CaregiverID = @CaregiverID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@CaregiverID", UserSession.CaregiverID);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cboPatient.DataSource = dt;
            cboPatient.DisplayMember = "FullName";
            cboPatient.ValueMember = "PatientID";





        }
        private void FrmAddReminder_Load(object sender, EventArgs e)
        {
            LoadElderly();
            
        }
       
        private void cboPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



