namespace OMC_Group16.Forms
{
    partial class FrmGuideStepss
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


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
            lblCategoryTitle.BackColor = Color.DarkOliveGreen;
            lblCategoryTitle.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.DarkKhaki;
            lblCategoryTitle.Location = new Point(2, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(453, 225);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Online Banking Guide";
            lblCategoryTitle.TextAlign = ContentAlignment.MiddleCenter;
            //lblCategoryTitle.Click += lblCategoryTitle_Click;
            // 
            // lblStepDescription
            // 
            lblStepDescription.Font = new Font("Calibri", 10.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepDescription.Location = new Point(2, 204);
            lblStepDescription.Name = "lblStepDescription";
            lblStepDescription.Size = new Size(453, 212);
            lblStepDescription.TabIndex = 1;
            lblStepDescription.Text = "";
            //lblStepDescription.TextChanged += lblStepDescription_TextChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.OliveDrab;
            btnPrevious.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.Khaki;
            btnPrevious.Location = new Point(12, 559);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(180, 51);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<-- Previous Step";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnBackToCategories
            // 
            btnBackToCategories.BackColor = SystemColors.ActiveCaption;
            btnBackToCategories.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackToCategories.Location = new Point(110, 484);
            btnBackToCategories.Name = "btnBackToCategories";
            btnBackToCategories.Size = new Size(234, 46);
            btnBackToCategories.TabIndex = 3;
            btnBackToCategories.Text = "Back To Categories";
            btnBackToCategories.UseVisualStyleBackColor = false;
            btnBackToCategories.Click += btnBackToCategories_Click_1;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.OliveDrab;
            btnNext.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Khaki;
            btnNext.Location = new Point(256, 559);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(189, 51);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Step -->";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnVoiceToggleSteps
            // 
            btnVoiceToggleSteps.BackColor = Color.FromArgb(127, 166, 122);
            btnVoiceToggleSteps.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceToggleSteps.ForeColor = SystemColors.ButtonHighlight;
            btnVoiceToggleSteps.Location = new Point(12, 12);
            btnVoiceToggleSteps.Name = "btnVoiceToggleSteps";
            btnVoiceToggleSteps.Size = new Size(254, 45);
            btnVoiceToggleSteps.TabIndex = 5;
            btnVoiceToggleSteps.Text = "🔊 Turn Voice ON";
            btnVoiceToggleSteps.UseVisualStyleBackColor = false;
            btnVoiceToggleSteps.Click += btnVoiceToggleSteps_Click_1;
            // 
            // btnZoomIn
            // 
            btnZoomIn.BackColor = Color.FromArgb(127, 166, 122);
            btnZoomIn.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZoomIn.ForeColor = SystemColors.ButtonHighlight;
            btnZoomIn.Location = new Point(325, 358);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(60, 47);
            btnZoomIn.TabIndex = 6;
            btnZoomIn.Text = "A+";
            btnZoomIn.UseVisualStyleBackColor = false;
            btnZoomIn.Click += btnZoomIn_Click_1;
            // 
            // btnZoomOut
            // 
            btnZoomOut.BackColor = Color.FromArgb(127, 166, 122);
            btnZoomOut.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZoomOut.ForeColor = SystemColors.ButtonHighlight;
            btnZoomOut.Location = new Point(391, 358);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(54, 47);
            btnZoomOut.TabIndex = 7;
            btnZoomOut.Text = "A-";
            btnZoomOut.UseVisualStyleBackColor = false;
            btnZoomOut.Click += btnZoomOut_Click_1;
            // 
            // FrmGuideStepss
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(457, 663);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            Controls.Add(btnVoiceToggleSteps);
            Controls.Add(btnNext);
            Controls.Add(btnBackToCategories);
            Controls.Add(btnPrevious);
            Controls.Add(lblStepDescription);
            Controls.Add(lblCategoryTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGuideStepss";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGuideStepss";
            Load += FrmGuideStepss_Load;
            ResumeLayout(false);
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