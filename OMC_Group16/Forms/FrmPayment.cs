using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmPayment : Form
    {
        public FrmPayment(string service, string date, string time, string price)
        {
            InitializeComponent();

            lblService.Text = service;
            lblDate.Text = date;
            lblTime.Text = time;
            lblAmount.Text = price;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            pnlBank.Visible = false;
            pnlCard.Visible = false;

            cboBank.SelectedIndex = 0;
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            pnlBank.Visible = rbBank.Checked;
            pnlCard.Visible = false;
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            pnlCard.Visible = rbCard.Checked;
            pnlBank.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBookAppointment frm = new FrmBookAppointment();

            frm.Show();

            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
         
            if (!rbBank.Checked && !rbCard.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            FrmPaymentSuccess frm = new FrmPaymentSuccess();

            frm.Show();

            this.Hide();
         }
        
    }
}
