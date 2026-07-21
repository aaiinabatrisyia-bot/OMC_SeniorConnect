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
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkKhaki;
            lblTitle.Location = new Point(137, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUALITAS CLINIC";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblClinic
            // 
            lblClinic.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinic.ForeColor = Color.White;
            lblClinic.Location = new Point(54, 126);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(403, 51);
            lblClinic.TabIndex = 1;
            lblClinic.Text = "BRANCH:  BANDAR BUKIT RAJA,KLANG";
            lblClinic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRating.ForeColor = Color.Yellow;
            lblRating.Location = new Point(317, 399);
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
            label1.Location = new Point(193, 532);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 3;
            label1.Text = "GENERAL CHECKUP RM50";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.PaleGreen;
            btnBook.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(28, 630);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(227, 46);
            btnBook.TabIndex = 4;
            btnBook.Text = "BOOK APPOINTMENT";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Khaki;
            btnBack.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(293, 630);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(164, 47);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox3);
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(65, 503);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(108, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 80);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 227);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 261);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(160, 111);
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
            Load += FrmClinicServices_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox3;
    }
}