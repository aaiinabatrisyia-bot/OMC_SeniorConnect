namespace OMC_Group16
{
    partial class FrmCaregiverLogin
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCreateAccount = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Constantia", 16.2F);
            txtUsername.Location = new Point(153, 143);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 34);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Constantia", 16.2F);
            txtPassword.Location = new Point(153, 244);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 34);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Font = new Font("Constantia", 16.2F);
            btnLogin.Location = new Point(171, 321);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F);
            label1.Location = new Point(26, 143);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 3;
            label1.Text = "Username :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F);
            label2.Location = new Point(26, 244);
            label2.Name = "label2";
            label2.Size = new Size(113, 27);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 10);
            label3.Name = "label3";
            label3.Size = new Size(192, 25);
            label3.TabIndex = 5;
            label3.Text = "Caregiver Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 444);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 7;
            label4.Text = "Don't Have an Account?";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(98, 494);
            btnCreateAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(254, 60);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(98, 576);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(254, 59);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCreateAccount);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 663);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(173, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmCaregiverLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 663);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCaregiverLogin";
            Text = "FrmCaregiverLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCreateAccount;
        private Button btnBack;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}