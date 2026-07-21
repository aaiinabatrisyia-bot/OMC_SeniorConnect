namespace OMC_Group16.Forms
{
    partial class FrmSeniorManagement
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
            Button button1;
            Button btnBack;
            label5 = new Label();
            panel1 = new Panel();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            label6 = new Label();
            txtAddress = new TextBox();
            txtPhoneNumber2 = new TextBox();
            txtSeniorAge = new TextBox();
            txtSeniorName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            btnBack = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(222, 290);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(151, 28);
            button1.TabIndex = 8;
            button1.Text = "ADD SENIOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.PaleTurquoise;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(88, 290);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 28);
            btnBack.TabIndex = 12;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOliveGreen;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(467, 68);
            label5.TabIndex = 13;
            label5.Text = "SENIOR ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(rdoFemale);
            panel1.Controls.Add(rdoMale);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtPhoneNumber2);
            panel1.Controls.Add(txtSeniorAge);
            panel1.Controls.Add(txtSeniorName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 68);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 560);
            panel1.TabIndex = 14;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoFemale.ForeColor = Color.White;
            rdoFemale.Location = new Point(277, 176);
            rdoFemale.Margin = new Padding(3, 2, 3, 2);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(77, 23);
            rdoFemale.TabIndex = 11;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "FEMALE";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoMale.ForeColor = Color.White;
            rdoMale.Location = new Point(188, 175);
            rdoMale.Margin = new Padding(3, 2, 3, 2);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 23);
            rdoMale.TabIndex = 10;
            rdoMale.TabStop = true;
            rdoMale.Text = "MALE";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(69, 175);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 9;
            label6.Text = "GENDER:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(198, 222);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtPhoneNumber2
            // 
            txtPhoneNumber2.Location = new Point(198, 131);
            txtPhoneNumber2.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber2.Name = "txtPhoneNumber2";
            txtPhoneNumber2.Size = new Size(164, 23);
            txtPhoneNumber2.TabIndex = 6;
            // 
            // txtSeniorAge
            // 
            txtSeniorAge.Location = new Point(198, 72);
            txtSeniorAge.Margin = new Padding(3, 2, 3, 2);
            txtSeniorAge.Name = "txtSeniorAge";
            txtSeniorAge.Size = new Size(160, 23);
            txtSeniorAge.TabIndex = 5;
            // 
            // txtSeniorName
            // 
            txtSeniorName.Location = new Point(198, 23);
            txtSeniorName.Margin = new Padding(3, 2, 3, 2);
            txtSeniorName.Name = "txtSeniorName";
            txtSeniorName.Size = new Size(160, 23);
            txtSeniorName.TabIndex = 4;
            txtSeniorName.TextChanged += txtSeniorName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(69, 224);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "ADDRESS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 122);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "PHONE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 71);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "AGE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "SENIOR NAME:";
            // 
            // FrmSeniorManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 628);
            Controls.Add(panel1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmSeniorManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSeniorManagement";
            Load += FrmSeniorManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber2;
        private TextBox txtSeniorAge;
        private TextBox txtSeniorName;
        private Label label6;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
    }
}