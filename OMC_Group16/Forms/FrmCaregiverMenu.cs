using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16
{
    public partial class FrmCaregiverMenu : Form
    {
        public FrmCaregiverMenu()
        {
            InitializeComponent();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            FrmReminders reminder = new FrmReminders();
            reminder.Show();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            FrmEmergency emergency = new FrmEmergency();
            emergency.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmWelcome welcome = new FrmWelcome();
            welcome.Show();

        }
    }
}
