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
            SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            lblCategoryTitle.AutoSize = true;
            lblCategoryTitle.Location = new Point(73, 63);
            lblCategoryTitle.Name = "lblCategoryTitle";
            lblCategoryTitle.Size = new Size(248, 32);
            lblCategoryTitle.TabIndex = 0;
            lblCategoryTitle.Text = "Online Banking Guide";
            // 
            // lblStepDescription
            // 
            lblStepDescription.Location = new Point(38, 248);
            lblStepDescription.Name = "lblStepDescription";
            lblStepDescription.Size = new Size(1475, 192);
            lblStepDescription.TabIndex = 1;
            lblStepDescription.Text = "Step 1: Open your banking app and type your username.";
           // lblStepDescription.TextChanged += lblStepDescription_TextChanged;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(83, 694);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(238, 46);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "<-- Previous Step";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnBackToCategories
            // 
            btnBackToCategories.Location = new Point(641, 694);
            btnBackToCategories.Name = "btnBackToCategories";
            btnBackToCategories.Size = new Size(278, 46);
            btnBackToCategories.TabIndex = 3;
            btnBackToCategories.Text = "Back To Categories";
            btnBackToCategories.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1321, 694);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 46);
            btnNext.TabIndex = 4;
            btnNext.Text = "Next Step -->";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // FrmGuideStepss
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 829);
            Controls.Add(btnNext);
            Controls.Add(btnBackToCategories);
            Controls.Add(btnPrevious);
            Controls.Add(lblStepDescription);
            Controls.Add(lblCategoryTitle);
            Name = "FrmGuideStepss";
            Text = "FrmGuideStepss";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryTitle;
        private RichTextBox lblStepDescription;
        private Button btnPrevious;
        private Button btnBackToCategories;
        private Button btnNext;
    }
}