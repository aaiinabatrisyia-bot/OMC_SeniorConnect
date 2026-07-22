using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OMC_Group16.Forms;
using System.Speech.Synthesis;
using FrmEmergency;

namespace OMC_Group16
{
    public partial class FrmHome : Form
    {
        private readonly SpeechSynthesizer voiceEngine = new SpeechSynthesizer();

        private bool isVoicePlaying = false;

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

        private void pnlGuide_Click(object sender, EventArgs e)
        {
            FrmGuideCategories guide = new FrmGuideCategories();

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
            FrmEmergencyContact emergency = new FrmEmergencyContact();

            emergency.Show();

            this.Hide();
        }

        private void pnlVoice_Click(object sender, EventArgs e)
        {
            voiceEngine.SpeakAsyncCancelAll();

            voiceEngine.SpeakAsync(
                "Welcome to the SeniorConnect home menu. " +
                "Select Step by Step Guide for digital guidance. " +
                "Select Reminders to view your daily reminders. " +
                "Select Emergency Contacts for urgent assistance."
            );
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlGuide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlReminder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlVoice_Paint(object sender, PaintEventArgs e)
        {
            if (!isVoicePlaying)
            {
                voiceEngine.SpeakAsyncCancelAll();

                voiceEngine.SpeakAsync(
                    "Welcome to the SeniorConnect home menu. " +
                    "Select Step by Step Guide for digital guidance. " +
                    "Select Reminders to view your daily reminders. " +
                    "Select Emergency Contacts for urgent assistance."
                );

                lblVoice.Text = "Stop Voice";
                isVoicePlaying = true;
            }
            else
            {
                voiceEngine.SpeakAsyncCancelAll();

                lblVoice.Text = "Voice Assistant";
                isVoicePlaying = false;
            }
        }

        private void pnlEmergency_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEmergency_Click(object sender, EventArgs e)
        {

        }
    }
}
