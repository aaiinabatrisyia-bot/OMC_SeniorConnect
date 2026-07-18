using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmClinicServices : Form
    {
        public FrmClinicServices()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmBookAppointment appointment = new FrmBookAppointment();
            appointment.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCaregiverMenu frm = new FrmCaregiverMenu();

            frm.Show();

            this.Hide();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
