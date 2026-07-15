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
            FrmBookAppointment frm = new FrmBookAppointment();
            frm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();
            frm.Show();
            this.Hide();
        }
    }
}
