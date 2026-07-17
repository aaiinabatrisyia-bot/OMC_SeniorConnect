namespace OMC_Group16.Forms
{
    partial class FrmCreateAccount
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
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            cmbRelationship = new ComboBox();
            label7 = new Label();
            txtCaregiverName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(25, 385);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 0;
            label1.Text = "USERNAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(22, 427);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(230, 381);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(230, 427);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(230, 475);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(259, 27);
            txtConfirmPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(19, 479);
            label3.Name = "label3";
            label3.Size = new Size(193, 23);
            label3.TabIndex = 5;
            label3.Text = "CONFIRM PASSWORD:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Green;
            btnRegister.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonFace;
            btnRegister.Location = new Point(156, 549);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(204, 56);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCaregiverName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbRelationship);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 832);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(205, 111);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOliveGreen;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(504, 95);
            label4.TabIndex = 7;
            label4.Text = "CREATE ACCOUNT";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(22, 305);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 12;
            label5.Text = "PHONE NUMBER:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(230, 301);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(259, 27);
            txtPhoneNumber.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(25, 344);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 14;
            label6.Text = "RELATIONSHIP:";
            // 
            // cmbRelationship
            // 
            cmbRelationship.FormattingEnabled = true;
            cmbRelationship.Items.AddRange(new object[] { "Son", "", "Daughter", "Spouse", "", "Brother", "", "Sister", "", "Grandchild", "", "Relative", "", "Friend", "", "Neighbour", "", "Guardian", "", "Other" });
            cmbRelationship.Location = new Point(230, 339);
            cmbRelationship.Name = "cmbRelationship";
            cmbRelationship.Size = new Size(259, 28);
            cmbRelationship.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(22, 259);
            label7.Name = "label7";
            label7.Size = new Size(65, 23);
            label7.TabIndex = 16;
            label7.Text = "NAME:";
            // 
            // txtCaregiverName
            // 
            txtCaregiverName.Location = new Point(230, 259);
            txtCaregiverName.Name = "txtCaregiverName";
            txtCaregiverName.Size = new Size(259, 27);
            txtCaregiverName.TabIndex = 17;
            // 
            // FrmCreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(504, 832);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCreateAccount";
            Text = "FrmCreateAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label label3;
        private Button btnRegister;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox cmbRelationship;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtCaregiverName;
        private Label label7;
    }
}