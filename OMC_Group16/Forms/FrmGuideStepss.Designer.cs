namespace OMC_Group16.Forms
{
    partial class FrmGuideStepss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCategoryTitle = new Label();
            lblStepDescription = new RichTextBox();
            btnPrevious = new Button();
            btnBackToCategories = new Button();
            btnNext = new Button();
            btnVoiceToggleSteps = new Button();
            btnZoomIn = new Button();
            btnZoomOut = new Button();
            SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Font = new Font("Calibri", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.Location = new Point(73, 63);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(659, 85);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Online Banking Guide";
            // 
            // lblStepDescription
            // 
            lblStepDescription.Font = new Font("Calibri", 19.85F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepDescription.Location = new Point(38, 248);
            lblStepDescription.Name = "lblStepDescription";
            lblStepDescription.Size = new Size(1475, 192);
            lblStepDescription.TabIndex = 1;
            lblStepDescription.Text = "Step 1: Open your banking app and type your username.";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(83, 643);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(238, 97);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<-- Previous Step";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBackToCategories
            // 
            btnBackToCategories.BackColor = SystemColors.ActiveCaption;
            btnBackToCategories.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackToCategories.Location = new Point(641, 643);
            btnBackToCategories.Name = "btnBackToCategories";
            btnBackToCategories.Size = new Size(278, 97);
            btnBackToCategories.TabIndex = 3;
            btnBackToCategories.Text = "Back To Categories";
            btnBackToCategories.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1253, 643);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(218, 97);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Step -->";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnVoiceToggleSteps
            // 
            btnVoiceToggleSteps.Location = new Point(1304, 27);
            btnVoiceToggleSteps.Name = "btnVoiceToggleSteps";
            btnVoiceToggleSteps.Size = new Size(224, 90);
            btnVoiceToggleSteps.TabIndex = 5;
            btnVoiceToggleSteps.Text = "🔊 Voice is ON";
            btnVoiceToggleSteps.UseVisualStyleBackColor = true;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(1304, 461);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(73, 60);
            btnZoomIn.TabIndex = 6;
            btnZoomIn.Text = "A+";
            btnZoomIn.UseVisualStyleBackColor = true;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(1400, 461);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(71, 60);
            btnZoomOut.TabIndex = 7;
            btnZoomOut.Text = "A-";
            btnZoomOut.UseVisualStyleBackColor = true;
            // 
            // FrmGuideStepss
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 829);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            Controls.Add(btnVoiceToggleSteps);
            Controls.Add(btnNext);
            Controls.Add(btnBackToCategories);
            Controls.Add(btnPrevious);
            Controls.Add(lblStepDescription);
            Controls.Add(lblCategoryTitle);
            Name = "FrmGuideStepss";
            Text = "FrmGuideStepss";
            this.Load += new System.EventHandler(this.FrmGuideStepss_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryTitle;
        private RichTextBox lblStepDescription;
        private Button btnPrevious;
        private Button btnBackToCategories;
        private Button btnNext;
        private Button btnVoiceToggleSteps;
        private Button btnZoomIn;
        private Button btnZoomOut;
    }
}