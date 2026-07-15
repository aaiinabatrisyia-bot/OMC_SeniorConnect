using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
// Imported speech synthesis framework for SeniorConnect Voice Assist
using System.Speech.Synthesis;

namespace OMC_Group16.Forms
{
    public partial class FrmGuideCategories : Form
    {
        // Initialize the local speech engine instance
        private SpeechSynthesizer voiceEngine = new SpeechSynthesizer();
        private bool isVoiceEnabled = false;

        public FrmGuideCategories()
        {
            InitializeComponent();
            SetupVoiceHoverEvents();
        }

        private void FrmGuideCategories_Load(object sender, EventArgs e)
        {
            // Initial greeting prompt if toggled active
            SpeakText("Please select a guide category.");
        }

        /// <summary>
        /// Central method to handle audio narration seamlessly without freezing the UI
        /// </summary>
        private void SpeakText(string text)
        {
            if (isVoiceEnabled && !string.IsNullOrEmpty(text))
            {
                // Cancel any ongoing speech so it doesn't overlap overlapping audio lines
                voiceEngine.SpeakAsyncCancelAll();
                voiceEngine.SpeakAsync(text);
            }
        }

        // --- Voice Control Toggle Button ---

        private void btnVoiceAssist_Click(object sender, EventArgs e)
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

        // --- Category Button Click Events ---

        private void btnOnlineBanking_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Online Banking Guide.");
            OpenGuideSteps("Online Banking");
        }

        private void btnHealthcare_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Healthcare Guide.");
            OpenGuideSteps("Healthcare");
        }

        private void btnEWallet_Click(object sender, EventArgs e)
        {
            SpeakText("Opening E-Wallet Guide.");
            OpenGuideSteps("E-Wallet");
        }

        private void btnGovernmentService_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Government Service Guide.");
            OpenGuideSteps("Government Service");
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Messages Guide.");
            OpenGuideSteps("Messages");
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            SpeakText("Opening Transport Guide.");
            OpenGuideSteps("Transport");
        }

        /// <summary>
        /// Handles passing the selected category data to the next form
        /// </summary>
        private void OpenGuideSteps(string categoryName)
        {
            // Standard WinForms logic to switch windows and pass data
            // FrmGuideSteps stepsForm = new FrmGuideStepss(categoryName);
            // stepsForm.Show();
            this.Hide();
        }

        // --- Bottom Navigation Buttons ---

        private void btnBack_Click(object sender, EventArgs e)
        {
            SpeakText("Going back to main home menu.");

            Form mainMenu = Application.OpenForms["FrmMainMenu"] ?? Application.OpenForms["FrmHome"];
            if (mainMenu != null)
            {
                mainMenu.Show();
            }
            this.Close();
        }

        private void btnNextGuide_Click(object sender, EventArgs e)
        {
            string message = "Please click on one of the categories above to proceed.";
            SpeakText(message);
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Accessibility Accessibility Enhancements (Hover Support) ---

        /// <summary>
        /// Hooks up MouseEnter events to narrate options when the cursor hovers over them
        /// </summary>
        private void SetupVoiceHoverEvents()
        {
            btnBank.MouseEnter += (s, e) => SpeakText("Online Banking");
            btnHealth.MouseEnter += (s, e) => SpeakText("Healthcare");
            btnEWallet.MouseEnter += (s, e) => SpeakText("E Wallet");
            btnGov.MouseEnter += (s, e) => SpeakText("Government Services");
            btnMessage.MouseEnter += (s, e) => SpeakText("Messages");
            btnTransport.MouseEnter += (s, e) => SpeakText("Transport");
            btnBack.MouseEnter += (s, e) => SpeakText("Back button");
        }

        private void btnBank_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}