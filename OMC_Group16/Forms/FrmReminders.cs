using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Speech.Synthesis;

namespace OMC_Group16
{
    public partial class FrmReminders : Form
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OMC_SeniorConnectDB;Integrated Security=True;";
        private int currentUserId;
        private List<Reminder> _currentReminders;
        private Reminder _selectedReminders;
        private ReminderService _reminderService;
        private readonly SpeechSynthesizer voiceAssistant = new SpeechSynthesizer();

        public FrmReminders()
        {
            InitializeComponent();
            
            LoadReminders();
        }

        private void InitializeService()
        {
            var repository = new MockReminderRepository();
            _reminderService = new ReminderService(repository);
        }

        private void LoadReminders()
        {
            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT ReminderDate, Title, Description, Status FROM Reminders";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReminders.Columns.Clear();
                dgvReminders.AutoGenerateColumns = true;
                dgvReminders.DataSource = dt;   // Replace dataGridView1 with your DataGridView's name

                

                
            }
        }
        

        private void DisplayReminders(List<Reminder> reminders)
        {
            dgvReminders.DataSource = null;
            dgvReminders.Rows.Clear();

            foreach (var reminder in reminders)
            {
                dgvReminders.Rows.Add(
                    reminder.Id,
                    reminder.ReminderDate.ToShortDateString(),
                    reminder.ReminderDate.ToShortTimeString(),
                    reminder.Title,
                    reminder.StatusText
                    );
            }
        }

        private void ClearForm()
        {

        }

        private void UpdateStatusCounts()
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmReminders_Load(object sender, EventArgs e)
        {
            LoadReminders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadReminders();
                return;
            }

            _currentReminders = _reminderService.SearchReminders(keyword);
            dgvReminders.DataSource = null;
            dgvReminders.DataSource = _currentReminders;
            UpdateStatusCounts();

        }

        private void dgvReminders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReminders.Rows[e.RowIndex];

                lblDate.Text = row.Cells["ReminderDate"].Value?.ToString();
                lblTitle.Text = row.Cells["Title"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                lblStatus.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReminders();
            txtSearch.Clear();
        }

        private void btnTodayReminders_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT ReminderDate, Title, Description, Status
                         FROM Reminders
                         WHERE CAST(ReminderDate AS DATE) = CAST(GETDATE() AS DATE)";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReminders.DataSource = dt;
            }

            UpdateStatusCounts();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT ReminderDate, Title, Description, Status
                         FROM Reminders
                         WHERE Title LIKE @search
                         OR Description LIKE @search
                         OR Status LIKE @search";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text.Trim() + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReminders.DataSource = dt;
            }
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();

            frm.Show();

            this.Hide();
        }

        private void btnVoiceAssistant_Click(object sender, EventArgs e)
        {
            voiceAssistant.SpeakAsyncCancelAll();

            if (dgvReminders.Rows.Count == 0 ||
                (dgvReminders.Rows.Count == 1 && dgvReminders.Rows[0].IsNewRow))
            {
                voiceAssistant.SpeakAsync("You have no reminders for today.");
                return;
            }

            string speech = $"You have {dgvReminders.Rows.Count - 1} reminder";

            if (dgvReminders.Rows.Count - 1 > 1)
                speech += "s.";

            foreach (DataGridViewRow row in dgvReminders.Rows)
            {
                if (row.IsNewRow)
                    continue;

                speech +=
                    $" Reminder: {row.Cells[2].Value}. " +
                    $"Scheduled on {Convert.ToDateTime(row.Cells[0].Value):dddd}. " +
                    $"Time: {row.Cells[1].Value}.";
            }

            voiceAssistant.SpeakAsync(speech);

        }
    }
}
