using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16
{
    public partial class FrmReminders : Form
    {
        private string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=MyDatabase;Integrated Security=True;";
        private int currentUserId;

        public FrmReminders(int userId = 1)
        {
            currentUserId = userId;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmReminders_Load(object sender, EventArgs e)
        {
            // LoadReminders();
            // UpdateStatistics();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReminders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
