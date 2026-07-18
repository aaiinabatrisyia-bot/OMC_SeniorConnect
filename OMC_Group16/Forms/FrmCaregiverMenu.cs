using FrmEmergency;
using OMC_Group16.Forms;
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
            FrmAddReminder reminder = new FrmAddReminder();
            reminder.Show();
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
           FrmEmergency2 emergency  = new FrmEmergency2();
            emergency.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmWelcome welcome = new FrmWelcome();
            welcome.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCaregiverLogin login = new FrmCaregiverLogin();
            login.Show();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            FrmClinicServices frm = new FrmClinicServices();

            frm.Show();

            this.Hide();
        }

        private void btnSeniorManagement_Click(object sender, EventArgs e)
        {
            FrmSeniorManagement senior = new FrmSeniorManagement();

            senior.Owner = this;
            senior.Show();

            this.Hide();
        }
    }
}
