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
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnCreateAccount = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Constantia", 16.2F);
            txtUsername.Location = new Point(349, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 40);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Constantia", 16.2F);
            txtPassword.Location = new Point(349, 176);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 40);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = Color.FromArgb(192, 255, 192);
            btnLogin.Font = new Font("Constantia", 16.2F);
            btnLogin.Location = new Point(276, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 16.2F);
            label1.Location = new Point(207, 105);
            label1.Name = "label1";
            label1.Size = new Size(136, 35);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 16.2F);
            label2.Location = new Point(207, 176);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(246, 51);
            label3.Name = "label3";
            label3.Size = new Size(241, 32);
            label3.TabIndex = 5;
            label3.Text = "Caregiver Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SeniorConnect;
            pictureBox1.Location = new Point(-14, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 296);
            label4.Name = "label4";
            label4.Size = new Size(168, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't Have an Account?";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(298, 331);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(120, 29);
            btnCreateAccount.TabIndex = 8;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(316, 366);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmCaregiverLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreateAccount);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "FrmCaregiverLogin";
            Text = "FrmCaregiverLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Button btnCreateAccount;
        private Button btnBack;
    }
}