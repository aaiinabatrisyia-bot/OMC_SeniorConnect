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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClinicServices));
            lblTitle = new Label();
            lblClinic = new Label();
            lblRating = new Label();
            label1 = new Label();
            btnBook = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkKhaki;
            lblTitle.Location = new Point(146, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUALITAS CLINIC";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblClinic
            // 
            lblClinic.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinic.ForeColor = Color.White;
            lblClinic.Location = new Point(55, 96);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(402, 40);
            lblClinic.TabIndex = 1;
            lblClinic.Text = "BRANCH:  BANDAR BUKIT RAJA,KLANG";
            lblClinic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRating.ForeColor = Color.Yellow;
            lblRating.Location = new Point(332, 325);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(160, 25);
            lblRating.TabIndex = 2;
            lblRating.Text = "4.6 STAR REVIEWS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 429);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 3;
            label1.Text = "GENERAL CHECKUP RM50";
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(68, 503);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(227, 31);
            btnBook.TabIndex = 4;
            btnBook.Text = "BOOK APPOINTMENT";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(322, 503);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(97, 31);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBook);
            panel1.Controls.Add(lblClinic);
            panel1.Controls.Add(lblRating);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 832);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 77);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(322, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(170, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FrmClinicServices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 832);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClinicServices";
            Text = "FrmClinicServices";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblClinic;
        private Label lblRating;
        private Label label1;
        private Button btnBook;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}