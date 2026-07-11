using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void FrmHome_MouseEnter(object sender, EventArgs e)
        {
            // Safely handle cases where the event sender is not a Panel
            if (sender is System.Windows.Forms.Panel card)
            {
                card.BackColor = Color.AliceBlue;
            }
        }

        private void pnlGuide_MouseEnter(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.AliceBlue;
        }

        private void pnlGuide_MouseLeave(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.WhiteSmoke;
        }

        private void pnlReminder_MouseEnter(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.AliceBlue;
        }

        private void pnlReminder_MouseLeave(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.WhiteSmoke;
        }

        private void pnlEmergency_MouseEnter(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.AliceBlue;
        }

        private void pnlEmergency_MouseLeave(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.WhiteSmoke;
        }

        private void pnlVoice_MouseEnter(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.AliceBlue;
        }

        private void pnlVoice_MouseLeave(object sender, EventArgs e)
        {
            Panel card = (Panel)sender;

            card.BackColor = Color.WhiteSmoke;
        }

        private void pnlGuide_Click(object sender, EventArgs e)
        {
            FrmGuideMenu guide = new FrmGuideMenu();

            guide.Show();

            this.Hide();
        }

        private void pnlReminder_Click(object sender, EventArgs e)
        {
            FrmReminders reminder = new FrmReminders();

            reminder.Show();

            this.Hide();
        }

        private void pnlEmergency_Click(object sender, EventArgs e)
        {
            FrmEmergency emergency = new FrmEmergency();

            emergency.Show();

            this.Hide();
        }

        private void pnlVoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voice Assistant");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlGuide_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
