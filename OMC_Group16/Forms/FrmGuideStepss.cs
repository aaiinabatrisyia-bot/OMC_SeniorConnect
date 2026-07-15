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
    public partial class FrmGuideStepss : Form
    {
        private string currentCategory;
        private string[] tutorialSteps;
        private int currentStepIndex = 0;


        private SpeechSynthesizer voiceEngine = new SpeechSynthesizer();
        private bool isVoiceEnabled = true;
        private float currentFontSize = 20.0f;

        public FrmGuideStepss(string category)
        {
            InitializeComponent();
            this.currentCategory = category;
        }

        private void FrmGuideStepss_Load(object sender, EventArgs e)
        {
            lblCategoryTitle.Text = currentCategory + " Guide";

            LoadTutorialData();
            ShowCurrentStep();
        }

        private void ShowCurrentStep()
        {
            if (tutorialSteps != null && currentStepIndex >= 0 && currentStepIndex < tutorialSteps.Length)
            {

                string stepText = tutorialSteps[currentStepIndex];
                lblStepDescription.Text = stepText;


                SpeakText($"Step {currentStepIndex + 1}. {stepText}");
            }
        }

        private void SpeakText(string text)
        {
            if (isVoiceEnabled && !string.IsNullOrEmpty(text))
            {
                voiceEngine.SpeakAsyncCancelAll();
                voiceEngine.SpeakAsync(text);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStepIndex < tutorialSteps.Length - 1)
            {
                currentStepIndex++;
                ShowCurrentStep();
            }
            else
            {
                SpeakText("You have reached the final step of this guide.");
                MessageBox.Show("You have reached the end of the tutorial!", "Guide Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                ShowCurrentStep();
            }
            else
            {
                SpeakText("This is the first step.");
            }
        }

        private void btnBackToCategories_Click(object sender, EventArgs e)
        {
            voiceEngine.SpeakAsyncCancelAll();


            Form categoriesForm = Application.OpenForms["FrmGuideCategories"];
            if (categoriesForm != null)
            {
                categoriesForm.Show();
            }
            this.Close();
        }


        private void btnVoiceToggleSteps_Click(object sender, EventArgs e)
        {
            isVoiceEnabled = !isVoiceEnabled;
            if (isVoiceEnabled)
            {
                btnVoiceToggleSteps.Text = "重 Voice is ON";
                btnVoiceToggleSteps.BackColor = Color.LightGreen;
                SpeakText("Voice narration resumed.");
            }
            else
            {
                btnVoiceToggleSteps.Text = "🔇 Voice is MUTED";
                btnVoiceToggleSteps.BackColor = SystemColors.Control;
                voiceEngine.SpeakAsyncCancelAll();
            }
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (currentFontSize < 36.0f) // Cap size to prevent breaking the layout bounding box
            {
                currentFontSize += 2.0f;
                lblStepDescription.Font = new Font(lblStepDescription.Font.FontFamily, currentFontSize, lblStepDescription.Font.Style);
                SpeakText("Text size increased");
            }
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (currentFontSize > 14.0f)
            {
                currentFontSize -= 2.0f;
                lblStepDescription.Font = new Font(lblStepDescription.Font.FontFamily, currentFontSize, lblStepDescription.Font.Style);
                SpeakText("Text size decreased");
            }
        }


        private void LoadTutorialData()
        {
            if (currentCategory == "Online Banking")
            {
                tutorialSteps = new string[]
                {
                    "Open your chosen Bank App on your smartphone screen.",
                    "Enter your secure User ID carefully, then tap Next.",
                    "Verify your security image matches your account profile.",
                    "Type your password password securely and tap Login to proceed."
                };
            }
            else if (currentCategory == "Healthcare")
            {
                tutorialSteps = new string[]
                {
                    "Open the MySejahtera or public health application.",
                    "Tap on the Appointments section from the main display layout.",
                    "Select your nearby clinic branch and pick an available morning time slot.",
                    "Confirm the booking submission details and save the generated screen ticket."
                };
            }
            else
            {
                tutorialSteps = new string[]
                {
                    "Look at the interface instructions carefully.",
                    "Follow your group framework modules step by step."
                };
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (currentStepIndex < tutorialSteps.Length - 1)
            {
                currentStepIndex++;
                ShowCurrentStep();
            }
            else
            {
                SpeakText("You have reached the final step of this guide.");
                MessageBox.Show("You have reached the end of the tutorial!", "Guide Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVoiceToggleSteps_Click_1(object sender, EventArgs e)
        {
            isVoiceEnabled = !isVoiceEnabled;
            if (isVoiceEnabled)
            {
                btnVoiceToggleSteps.Text = "重 Voice is ON";
                btnVoiceToggleSteps.BackColor = Color.LightGreen;
                SpeakText("Voice narration resumed.");
            }
            else
            {
                btnVoiceToggleSteps.Text = "🔇 Voice is MUTED";
                btnVoiceToggleSteps.BackColor = SystemColors.Control;
                voiceEngine.SpeakAsyncCancelAll();
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                ShowCurrentStep();
            }
            else
            {
                SpeakText("This is the first step.");
            }
        }

        private void btnBackToCategories_Click_1(object sender, EventArgs e)
        {
            voiceEngine.SpeakAsyncCancelAll();


            Form categoriesForm = Application.OpenForms["FrmGuideCategories"];
            if (categoriesForm != null)
            {
                categoriesForm.Show();
            }
            this.Close();
        }

        private void btnZoomIn_Click_1(object sender, EventArgs e)
        {
            if (currentFontSize < 36.0f) // Cap size to prevent breaking the layout bounding box
            {
                currentFontSize += 2.0f;
                lblStepDescription.Font = new Font(lblStepDescription.Font.FontFamily, currentFontSize, lblStepDescription.Font.Style);
                SpeakText("Text size increased");
            }
        }

        private void btnZoomOut_Click_1(object sender, EventArgs e)
        {
            if (currentFontSize > 14.0f)
            {
                currentFontSize -= 2.0f;
                lblStepDescription.Font = new Font(lblStepDescription.Font.FontFamily, currentFontSize, lblStepDescription.Font.Style);
                SpeakText("Text size decreased");
            }
        }
    }
}