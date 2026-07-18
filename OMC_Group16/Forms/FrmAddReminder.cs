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
        string connectionString = "Server=YOUR_SERVER;Database=CaregiverDB;Integrated Security=True;";
        public FrmAddReminder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Reminders (Title, ReminderTime, Priority, Description) " +
                                   "VALUES (@title, @time, @priority, @desc)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@time", dtpReminderDate.Value);
                    cmd.Parameters.AddWithValue("@desc", txtReminderDescription.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Reminder Added Successfully!");
                    this.Close(); // Close after saving
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving reminder: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoiceAssistant_Click(object sender, EventArgs e)
        {

        }
    }
}



