using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmPaymentSuccess : Form
    {

        public FrmPaymentSuccess()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FrmHome frm = new FrmHome();

            frm.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }
    }
}
