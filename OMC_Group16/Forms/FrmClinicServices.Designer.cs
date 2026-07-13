namespace OMC_Group16.Forms
{
    partial class FrmClinicServices
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
            lblTitle = new Label();
            lblClinic = new Label();
            lblRating = new Label();
            label1 = new Label();
            btnBook = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(146, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Partner Clinics";
            // 
            // lblClinic
            // 
            lblClinic.AutoSize = true;
            lblClinic.Location = new Point(39, 79);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(50, 15);
            lblClinic.TabIndex = 1;
            lblClinic.Text = "Qualitas";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(45, 123);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(44, 15);
            lblRating.TabIndex = 2;
            lblRating.Text = "4.7 star";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 185);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "general checkup rm50";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(78, 254);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(151, 23);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book Appointment";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(257, 254);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 624);
            panel1.TabIndex = 6;
            // 
            // FrmClinicServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 624);
            Controls.Add(btnBack);
            Controls.Add(btnBook);
            Controls.Add(label1);
            Controls.Add(lblRating);
            Controls.Add(lblClinic);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClinicServices";
            Text = "FrmClinicServices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblClinic;
        private Label lblRating;
        private Label label1;
        private Button btnBook;
        private Button btnBack;
        private Panel panel1;
    }
}