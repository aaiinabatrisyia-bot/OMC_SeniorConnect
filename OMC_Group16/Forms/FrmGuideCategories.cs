using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmGuideCategories : Form
    {
        public FrmGuideCategories()
        {
            InitializeComponent();
        }

        private void FrmGuideCategories_Load(object sender, EventArgs e)
        {
            // Code here runs when the form loads (currently empty)
        }

        // --- Category Button Click Events ---

        private void btnOnlineBanking_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("Online Banking");
        }

        private void btnHealthcare_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("Healthcare");
        }

        private void btnEWallet_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("E-Wallet");
        }

        private void btnGovernmentService_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("Government Service");
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("Messages");
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            OpenGuideSteps("Transport");
        }

        /// <summary>
        /// Handles passing the selected category data to the next form
        /// </summary>
        private void OpenGuideSteps(string categoryName)
        {
            // Standard WinForms logic to switch windows and pass data
          //  FrmGuideSteps stepsForm = //new FrmGuideStepss(categoryName);
          //  stepsForm.Show();
            this.Hide();
        }

        // --- Bottom Navigation Buttons ---

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Tries to locate Puteri's welcome/home menu to go back
            Form mainMenu = Application.OpenForms["FrmMainMenu"] ?? Application.OpenForms["FrmHome"];

            if (mainMenu != null)
            {
                mainMenu.Show();
            }

            this.Close();
        }

        private void btnNextGuide_Click(object sender, EventArgs e)
        {
            // Prompt the elderly user to select an explicit category option from the layout
            MessageBox.Show("Please click on one of the categories above to proceed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}