namespace FrmEmergency
{
    partial class FrmEmergency
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnClear = new Button();
            txtClinic = new TextBox();
            label6 = new Label();
            btnNearbyClinic = new Button();
            btnEmergencyContact = new Button();
            btnAmbulance = new Button();
            txtAddress = new TextBox();
            txtEmergencyContact = new TextBox();
            txtPhoneNumber = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkOliveGreen;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.DarkKhaki;
            btnExit.Location = new Point(267, 783);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(190, 64);
            btnExit.TabIndex = 24;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOliveGreen;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.DarkKhaki;
            btnClear.Location = new Point(62, 783);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 64);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtClinic
            // 
            txtClinic.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtClinic.Location = new Point(158, 649);
            txtClinic.Multiline = true;
            txtClinic.Name = "txtClinic";
            txtClinic.Size = new Size(314, 53);
            txtClinic.TabIndex = 22;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Ivory;
            label6.Location = new Point(22, 651);
            label6.Name = "label6";
            label6.Size = new Size(118, 45);
            label6.TabIndex = 21;
            label6.Text = "Nearby Clinic\r\n";
            // 
            // btnNearbyClinic
            // 
            btnNearbyClinic.BackColor = Color.Teal;
            btnNearbyClinic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNearbyClinic.ForeColor = Color.LightCyan;
            btnNearbyClinic.Location = new Point(41, 540);
            btnNearbyClinic.Name = "btnNearbyClinic";
            btnNearbyClinic.Size = new Size(431, 48);
            btnNearbyClinic.TabIndex = 20;
            btnNearbyClinic.Text = "NEARBY CLINIC";
            btnNearbyClinic.UseVisualStyleBackColor = false;
            btnNearbyClinic.Click += btnNearbyClinic_Click;
            // 
            // btnEmergencyContact
            // 
            btnEmergencyContact.BackColor = Color.DarkOrange;
            btnEmergencyContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergencyContact.ForeColor = Color.FloralWhite;
            btnEmergencyContact.Location = new Point(41, 481);
            btnEmergencyContact.Name = "btnEmergencyContact";
            btnEmergencyContact.Size = new Size(431, 48);
            btnEmergencyContact.TabIndex = 19;
            btnEmergencyContact.Text = "EMERGENCY CONTACT";
            btnEmergencyContact.UseVisualStyleBackColor = false;
            btnEmergencyContact.Click += btnEmergencyContact_Click;
            // 
            // btnAmbulance
            // 
            btnAmbulance.BackColor = Color.Red;
            btnAmbulance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmbulance.ForeColor = Color.MistyRose;
            btnAmbulance.Location = new Point(41, 417);
            btnAmbulance.Name = "btnAmbulance";
            btnAmbulance.Size = new Size(431, 48);
            btnAmbulance.TabIndex = 18;
            btnAmbulance.Text = "AMBULANCE";
            btnAmbulance.UseVisualStyleBackColor = false;
            btnAmbulance.Click += btnAmbulance_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtAddress.Location = new Point(158, 319);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 44);
            txtAddress.TabIndex = 17;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtEmergencyContact.Location = new Point(158, 252);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(314, 27);
            txtEmergencyContact.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtPhoneNumber.Location = new Point(158, 192);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(314, 27);
            txtPhoneNumber.TabIndex = 15;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtName.Location = new Point(158, 141);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 27);
            txtName.TabIndex = 14;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.Ivory;
            label5.Location = new Point(48, 320);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Ivory;
            label4.Location = new Point(48, 252);
            label4.Name = "label4";
            label4.Size = new Size(110, 68);
            label4.TabIndex = 12;
            label4.Text = "Emergency Contact";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(48, 177);
            label3.Name = "label3";
            label3.Size = new Size(91, 64);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(48, 145);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 88);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(522, 88);
            label1.TabIndex = 0;
            label1.Text = "EMERGENCY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(txtEmergencyContact);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtClinic);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnNearbyClinic);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnEmergencyContact);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnAmbulance);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 884);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // FrmEmergency
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(522, 884);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmergency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMERGENCY";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtEmergencyContact;
        private TextBox txtPhoneNumber;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNearbyClinic;
        private Button btnEmergencyContact;
        private Button btnAmbulance;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtClinic;
        private Label label6;
        private Panel panel1;
    }
}
