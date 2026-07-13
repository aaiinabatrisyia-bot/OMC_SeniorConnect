using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmGuideStepss : Form
    {
        private string currentCategory;
        private string[] tutorialSteps;
        private int currentStepIndex = 0;

        public FrmGuideStepss(string category)
        {
            InitializeComponent();
            this.currentCategory = category;
        }

        private void FrmGuideStepss_Load(object sender, EventArgs e)
        {
            // Set the header title based on what was chosen in the first form
            lblCategoryTitle.Text = currentCategory + " Guide";

            // Load the appropriate steps data
            LoadTutorialData();

            // Display the very first step
            ShowCurrentStep();
        }

        private void LoadTutorialData()
        {
            // Hardcoded mock data for your assignment submission
            // Later, Hani can connect this to the SQL database using 'currentCategory'
            if (currentCategory == "Online Banking")
            {
                tutorialSteps = new string[]
                {
                    "Step 1: Open your chosen Bank App on your smartphone screen.",
                    "Step 2: Enter your secure User ID carefully, then tap 'Next'.",
                    "Step 3: Confirm your security phrase matches yours before typing your password.",
                    "Step 4: You are now logged in! Tap 'Transfer' to send money safely."
                };
            }
            else if (currentCategory == "Healthcare")
            {
                tutorialSteps = new string[]
                {
                    "Step 1: Open your Health/Doctor Appointment App.",
                    "Step 2: Tap the large 'Book New Appointment' option.",
                    "Step 3: Choose your preferred clinic location and select an available date.",
                    "Step 4: Confirm your booking details and click 'Submit'."
                };
            }
            else
            {
                // Fallback default steps for E-Wallet, Government Services, Messages, Transport
                tutorialSteps = new string[]
                {
                    $"Welcome to the {currentCategory} helper module.",
                    "Step 1: Open the application icon from your home screen.",
                    "Step 2: Follow the large on-screen prompts carefully.",
                    "Finished! You can now use the app safely."
                };
            }
        }

        private void ShowCurrentStep()
        {
            if (tutorialSteps != null && tutorialSteps.Length > 0)
            {
                // Update your center UI text element with the step description
                lblStepDescription.Text = tutorialSteps[currentStepIndex];

                // Disable 'Previous' if we are on the very first step
                btnPrevious.Enabled = (currentStepIndex > 0);

                // Disable 'Next' if we are on the final step
                btnNext.Enabled = (currentStepIndex < tutorialSteps.Length - 1);
            }
        }

        // --- Navigation Interactions ---

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStepIndex < tutorialSteps.Length - 1)
            {
                currentStepIndex++;
                ShowCurrentStep();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentStepIndex > 0)
            {
                currentStepIndex--;
                ShowCurrentStep();
            }
        }

        private void btnBackToCategories_Click(object sender, EventArgs e)
        {
            // Find the categories window instance to show it again
            Form categoriesForm = Application.OpenForms["FrmGuideCategories"];
            if (categoriesForm != null)
            {
                categoriesForm.Show();
            }
            this.Close(); // Safely exit this step window
        }
    }
}
