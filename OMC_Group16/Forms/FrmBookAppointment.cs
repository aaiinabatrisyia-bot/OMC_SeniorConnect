using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmBookAppointment : Form
    {
        public FrmBookAppointment()
        {
            InitializeComponent();
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboService.Text)
            {
                case "General Check-up":
                    lblPrice.Text = "RM50";
                    break;

                case "Blood Pressure Check":
                    lblPrice.Text = "RM20";
                    break;

                case "Diabetes Consultation":
                    lblPrice.Text = "RM80";
                    break;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmClinicServices frm = new FrmClinicServices();

            frm.Show();

            this.Hide();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string service = cboService.Text;
            string date = dtpDate.Value.ToShortDateString();
            string time = cboTime.Text;
            string price = lblPrice.Text;

            FrmPayment frm = new FrmPayment(
                service,
                date,
                time,
                price
            );

            frm.Show();
            this.Hide();
        }
    }
}
