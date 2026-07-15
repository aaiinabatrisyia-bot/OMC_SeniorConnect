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
            lblCategoryTitle.Location = new Point(45, 39);
            lblCategoryTitle.Margin = new Padding(2, 0, 2, 0);
            lblCategoryTitle.BackColor = Color.DarkOliveGreen;
            lblCategoryTitle.Font = new Font("Calibri", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryTitle.ForeColor = Color.DarkKhaki;
            lblCategoryTitle.Location = new Point(1, 0);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(422, 54);
            lblCategoryTitle.Size = new Size(737, 265);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Online Banking Guide";
            lblCategoryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStepDescription
            // 
            lblStepDescription.Font = new Font("Calibri", 19.85F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepDescription.Location = new Point(23, 155);
            lblStepDescription.Margin = new Padding(2, 2, 2, 2);
            lblStepDescription.Font = new Font("Calibri", 10.85F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepDescription.Location = new Point(1, 268);
            lblStepDescription.Name = "lblStepDescription";
            lblStepDescription.Size = new Size(909, 89);
            lblStepDescription.Size = new Size(737, 201);
            lblStepDescription.TabIndex = 1;
            lblStepDescription.Text = "Step 1: Open your banking app and type your username.";
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(51, 402);
            btnPrevious.Margin = new Padding(2, 2, 2, 2);
            btnPrevious.BackColor = Color.OliveDrab;
            btnPrevious.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrevious.ForeColor = Color.Khaki;
            btnPrevious.Location = new Point(12, 664);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(146, 61);
            btnPrevious.Size = new Size(187, 55);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<-- Previous Step";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click_1;
            // 
            // btnBackToCategories
            // 
            btnBackToCategories.BackColor = SystemColors.ActiveCaption;
            btnBackToCategories.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBackToCategories.Location = new Point(394, 402);
            btnBackToCategories.Margin = new Padding(2, 2, 2, 2);
            btnBackToCategories.Location = new Point(241, 666);
            btnBackToCategories.Name = "btnBackToCategories";
            btnBackToCategories.Size = new Size(171, 61);
            btnBackToCategories.Size = new Size(237, 55);
            btnBackToCategories.TabIndex = 3;
            btnBackToCategories.Text = "Back To Categories";
            btnBackToCategories.UseVisualStyleBackColor = false;
            btnBackToCategories.Click += btnBackToCategories_Click_1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(771, 402);
            btnNext.Margin = new Padding(2, 2, 2, 2);
            btnNext.BackColor = Color.OliveDrab;
            btnNext.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.Khaki;
            btnNext.Location = new Point(532, 664);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(134, 61);
            btnNext.Size = new Size(190, 55);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Step -->";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnVoiceToggleSteps
            // 
            btnVoiceToggleSteps.Location = new Point(802, 17);
            btnVoiceToggleSteps.Margin = new Padding(2, 2, 2, 2);
            btnVoiceToggleSteps.BackColor = Color.FromArgb(127, 166, 122);
            btnVoiceToggleSteps.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceToggleSteps.ForeColor = SystemColors.ButtonHighlight;
            btnVoiceToggleSteps.Location = new Point(12, 12);
            btnVoiceToggleSteps.Name = "btnVoiceToggleSteps";
            btnVoiceToggleSteps.Size = new Size(138, 56);
            btnVoiceToggleSteps.Size = new Size(152, 89);
            btnVoiceToggleSteps.TabIndex = 5;
            btnVoiceToggleSteps.Text = "🔊 Turn Voice ON";
            btnVoiceToggleSteps.UseVisualStyleBackColor = false;
            btnVoiceToggleSteps.Click += btnVoiceToggleSteps_Click_1;
            // 
            // btnZoomIn
            // 
            btnZoomIn.Location = new Point(802, 288);
            btnZoomIn.Margin = new Padding(2, 2, 2, 2);
            btnZoomIn.BackColor = Color.FromArgb(127, 166, 122);
            btnZoomIn.ForeColor = SystemColors.ButtonHighlight;
            btnZoomIn.Location = new Point(600, 486);
            btnZoomIn.Name = "btnZoomIn";
            btnZoomIn.Size = new Size(45, 38);
            btnZoomIn.Size = new Size(54, 46);
            btnZoomIn.TabIndex = 6;
            btnZoomIn.Text = "A+";
            btnZoomIn.UseVisualStyleBackColor = false;
            btnZoomIn.Click += btnZoomIn_Click_1;
            // 
            // btnZoomOut
            // 
            btnZoomOut.Location = new Point(862, 288);
            btnZoomOut.Margin = new Padding(2, 2, 2, 2);
            btnZoomOut.BackColor = Color.FromArgb(127, 166, 122);
            btnZoomOut.ForeColor = SystemColors.ButtonHighlight;
            btnZoomOut.Location = new Point(674, 486);
            btnZoomOut.Name = "btnZoomOut";
            btnZoomOut.Size = new Size(44, 38);
            btnZoomOut.Size = new Size(48, 46);
            btnZoomOut.TabIndex = 7;
            btnZoomOut.Text = "A-";
            btnZoomOut.UseVisualStyleBackColor = false;
            btnZoomOut.Click += btnZoomOut_Click_1;
            // 
            // FrmGuideStepss
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 518);
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(741, 979);
            Controls.Add(btnZoomOut);
            Controls.Add(btnZoomIn);
            Controls.Add(btnVoiceToggleSteps);
            Controls.Add(btnNext);
            Controls.Add(btnBackToCategories);
            Controls.Add(btnPrevious);
            Controls.Add(lblStepDescription);
            Controls.Add(lblCategoryTitle);
            Margin = new Padding(2, 2, 2, 2);
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