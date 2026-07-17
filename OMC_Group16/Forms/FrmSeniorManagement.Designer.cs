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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(170, 403);
            button1.Name = "button1";
            button1.Size = new Size(173, 38);
            button1.TabIndex = 8;
            button1.Text = "ADD SENIOR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOliveGreen;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(534, 90);
            label5.TabIndex = 13;
            label5.Text = "SENIOR ";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
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
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 747);
            panel1.TabIndex = 14;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoFemale.ForeColor = Color.White;
            rdoFemale.Location = new Point(317, 235);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 27);
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
            rdoMale.Location = new Point(215, 233);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 27);
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
            label6.Location = new Point(79, 233);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 9;
            label6.Text = "GENDER:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(226, 296);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(201, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtPhoneNumber2
            // 
            txtPhoneNumber2.Location = new Point(226, 175);
            txtPhoneNumber2.Name = "txtPhoneNumber2";
            txtPhoneNumber2.Size = new Size(187, 27);
            txtPhoneNumber2.TabIndex = 6;
            // 
            // txtSeniorAge
            // 
            txtSeniorAge.Location = new Point(226, 96);
            txtSeniorAge.Name = "txtSeniorAge";
            txtSeniorAge.Size = new Size(182, 27);
            txtSeniorAge.TabIndex = 5;
            // 
            // txtSeniorName
            // 
            txtSeniorName.Location = new Point(226, 31);
            txtSeniorName.Name = "txtSeniorName";
            txtSeniorName.Size = new Size(182, 27);
            txtSeniorName.TabIndex = 4;
            txtSeniorName.TextChanged += txtSeniorName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 298);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 3;
            label4.Text = "ADDRESS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 162);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "PHONE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 95);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 1;
            label2.Text = "AGE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 30);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 0;
            label1.Text = "SENIOR NAME:";
            // 
            // FrmSeniorManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 837);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "FrmSeniorManagement";
            Text = "FrmSeniorManagement";
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