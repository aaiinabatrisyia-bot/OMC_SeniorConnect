using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OMC_Group16
{
    public partial class FrmReminders : Form
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OMC_SeniorConnectDB;Integrated Security=True;";
        private int currentUserId;
        private List<Reminder> _currentReminders;
        private Reminder _selectedReminders;
        private ReminderService _reminderService;

        public FrmReminders()
        {
            InitializeComponent();
            InitializeService();
            LoadReminders();
        }

        private void InitializeService()
        {
            var repository = new MockReminderRepository();
            _reminderService = new ReminderService(repository);
        }

        private void LoadReminders()
        {
            //string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=OMC_SeniorConnectDB;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT ReminderDate, Title, Description, Status FROM Reminders";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReminders.DataSource = dt;   // Replace dataGridView1 with your DataGridView's name
            }
        }
        

        private void DisplayReminders(List<Reminder> reminders)
        {
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
            if (_reminderService != null)
            {
                int pending = _reminderService.GetPendingCount();
                int total = _currentReminders?.Count ?? 0;
                int emergency = _reminderService.GetEmergencyReminders().Count;

                lblTotalCount.Text = $"Total: {total}";
                lblPendingCount.Text = $"Pending: {pending}";
                lblEmergencyCount.Text = $"Emergency: {emergency}";
            }
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
            if (dgvReminders.SelectedRows.Count > 0)
            {
                _selectedReminders = dgvReminders.SelectedRows[0].DataBoundItem as Reminder;
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
            _currentReminders = _reminderService.GetTodayReminders();
            DisplayReminders(_currentReminders);
            UpdateStatusCounts();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            _currentReminders = _reminderService.GetEmergencyReminders();
            DisplayReminders(_currentReminders);
            UpdateStatusCounts();
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
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                LoadReminders();
                return;
            }
            _currentReminders = _reminderService.SearchReminders(keyword);

            DisplayReminders(_currentReminders);
            UpdateStatusCounts();
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoiceAssistant_Click(object sender, EventArgs e)
        {


        }
    }
}
