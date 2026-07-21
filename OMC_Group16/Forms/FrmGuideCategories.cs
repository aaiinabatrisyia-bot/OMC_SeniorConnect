using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace OMC_Group16.Forms
{
    public partial class FrmGuideCategories : Form
    {

        private SpeechSynthesizer voiceEngine = new SpeechSynthesizer();
        private bool isVoiceEnabled = false;

        public FrmGuideCategories()
        {
            InitializeComponent();
            SetupVoiceHoverEvents();
        }

        private void FrmGuideCategories_Load(object sender, EventArgs e)
        {
            SpeakText("Please select a guide category.");
        }


        private void SpeakText(string text)
        {
            if (isVoiceEnabled && !string.IsNullOrEmpty(text))
            {

                voiceEngine.SpeakAsyncCancelAll();
                voiceEngine.SpeakAsync(text);
            }
        }


        private void OpenGuideSteps(string categoryName)
        {
            FrmGuideStepss stepsForm = new FrmGuideStepss(categoryName);
            stepsForm.Show();
            this.Hide();
        }

        private void SetupVoiceHoverEvents()
        {
            btnBank.MouseEnter += (s, e) => SpeakText("Online Banking");
            btnHealth1.MouseEnter += (s, e) => SpeakText("Healthcare");
            btnEWallet1.MouseEnter += (s, e) => SpeakText("E Wallet");
            btnGov.MouseEnter += (s, e) => SpeakText("Scam Alert");
            btnMessage.MouseEnter += (s, e) => SpeakText("Messages");
            btnTransport1.MouseEnter += (s, e) => SpeakText("Transport");
            btnBack.MouseEnter += (s, e) => SpeakText("Back button");
            //btnNextGuide.MouseEnter += (s, e) => SpeakText("Select a category to move to the next steps");
        }

        private void btnGov_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Scam Alert Guide.");
            OpenGuideSteps("Scam Alert");
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Messages Guide.");
            OpenGuideSteps("Messages");
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            SpeakText("Going back to main home menu.");

            Form mainMenu = Application.OpenForms["FrmMainMenu"] ?? Application.OpenForms["FrmHome"];
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
            this.Close();
        }

        private void btnNextGuide_Click_1(object sender, EventArgs e)
        {
            string message = "Please click on one of the categories above to proceed.";
            SpeakText(message);
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVoiceAssist_Click_2(object sender, EventArgs e)
        {
            isVoiceEnabled = !isVoiceEnabled;

            if (isVoiceEnabled)
            {
                btnVoiceAssist.Text = "🔇 Mute Voice";
                btnVoiceAssist.BackColor = Color.LightGreen;
                // Speak immediately to confirm system activation
                voiceEngine.SpeakAsyncCancelAll();
                voiceEngine.SpeakAsync("Voice assistance activated.");
            }
            else
            {
                btnVoiceAssist.Text = "🔊 Turn Voice ON";
                btnVoiceAssist.BackColor = SystemColors.Control;
                voiceEngine.SpeakAsyncCancelAll();
            }
        }

        private void btnBank_Click_1(object sender, EventArgs e)
        {
            SpeakText("Opening Online Banking Guide.");
            OpenGuideSteps("Online Banking");
        }

        private void btnEWallet1_Click(object sender, EventArgs e)
        {
            SpeakText("Opening E-Wallet Guide.");
            OpenGuideSteps("E-Wallet");
        }

        private void btnHealth1_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Healthcare Guide.");
            OpenGuideSteps("Healthcare");
        }

        private void btnTransport1_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Transport Guide.");
            OpenGuideSteps("Transport");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}