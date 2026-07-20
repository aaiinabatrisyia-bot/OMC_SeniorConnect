using Microsoft.VisualBasic;
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
                        (Title, ReminderDate, Description)
                        VALUES
                        (@Title,@Date,@Description)";

                SqlCommand cmd = new SqlCommand(query, con);

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
    }
}



