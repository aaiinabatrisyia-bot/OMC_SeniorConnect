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
            panel1 = new Panel();
            btnExit = new Button();
            btnClear = new Button();
            txtAdditionalNote = new TextBox();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 616);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkOliveGreen;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.DarkKhaki;
            btnExit.Location = new Point(174, 560);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(125, 36);
            btnExit.TabIndex = 24;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOliveGreen;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.DarkKhaki;
            btnClear.Location = new Point(19, 560);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 36);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtAdditionalNote
            // 
            txtAdditionalNote.Location = new Point(174, 483);
            txtAdditionalNote.Margin = new Padding(3, 4, 3, 4);
            txtAdditionalNote.Multiline = true;
            txtAdditionalNote.Name = "txtAdditionalNote";
            txtAdditionalNote.Size = new Size(180, 57);
            txtAdditionalNote.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MistyRose;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(19, 488);
            label6.Name = "label6";
            label6.Size = new Size(120, 46);
            label6.TabIndex = 21;
            label6.Text = "ADDITIONAL \r\nNOTE:\r\n";
            // 
            // btnNearbyClinic
            // 
            btnNearbyClinic.BackColor = Color.Teal;
            btnNearbyClinic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNearbyClinic.ForeColor = Color.LightCyan;
            btnNearbyClinic.Location = new Point(50, 387);
            btnNearbyClinic.Margin = new Padding(3, 4, 3, 4);
            btnNearbyClinic.Name = "btnNearbyClinic";
            btnNearbyClinic.Size = new Size(279, 40);
            btnNearbyClinic.TabIndex = 20;
            btnNearbyClinic.Text = "NEARBY CLINIC";
            btnNearbyClinic.UseVisualStyleBackColor = false;
            // 
            // btnEmergencyContact
            // 
            btnEmergencyContact.BackColor = Color.DarkOrange;
            btnEmergencyContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergencyContact.ForeColor = Color.FloralWhite;
            btnEmergencyContact.Location = new Point(50, 348);
            btnEmergencyContact.Margin = new Padding(3, 4, 3, 4);
            btnEmergencyContact.Name = "btnEmergencyContact";
            btnEmergencyContact.Size = new Size(279, 40);
            btnEmergencyContact.TabIndex = 19;
            btnEmergencyContact.Text = "EMERGENCY CONTACT";
            btnEmergencyContact.UseVisualStyleBackColor = false;
            // 
            // btnAmbulance
            // 
            btnAmbulance.BackColor = Color.Red;
            btnAmbulance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmbulance.ForeColor = Color.MistyRose;
            btnAmbulance.Location = new Point(50, 435);
            btnAmbulance.Margin = new Padding(3, 4, 3, 4);
            btnAmbulance.Name = "btnAmbulance";
            btnAmbulance.Size = new Size(279, 40);
            btnAmbulance.TabIndex = 18;
            btnAmbulance.Text = "AMBULANCE";
            btnAmbulance.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(174, 283);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(180, 57);
            txtAddress.TabIndex = 17;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Location = new Point(174, 234);
            txtEmergencyContact.Margin = new Padding(3, 4, 3, 4);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(180, 27);
            txtEmergencyContact.TabIndex = 16;
            txtEmergencyContact.TextChanged += txtEmergencyContact_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(174, 182);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(180, 27);
            txtPhoneNumber.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 116);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 27);
            txtName.TabIndex = 14;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MistyRose;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(19, 288);
            label5.Name = "label5";
            label5.Size = new Size(98, 25);
            label5.TabIndex = 13;
            label5.Text = "ADDRESS:";
            // 
            // label4
            // 
            label4.BackColor = Color.MistyRose;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(19, 223);
            label4.Name = "label4";
            label4.Size = new Size(149, 56);
            label4.TabIndex = 12;
            label4.Text = "EMERGENCY \r\nCONTACT:\r\n";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(19, 159);
            label3.Name = "label3";
            label3.Size = new Size(95, 50);
            label3.TabIndex = 11;
            label3.Text = "PHONE \r\nNUMBER:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(19, 118);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 10;
            label2.Text = "NAME:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(txtAdditionalNote);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnNearbyClinic);
            panel2.Controls.Add(btnAmbulance);
            panel2.Controls.Add(btnEmergencyContact);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmergencyContact);
            panel2.Controls.Add(txtPhoneNumber);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 616);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 54);
            label1.TabIndex = 0;
            label1.Text = "EMERGENCY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // FrmEmergency
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmergency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMERGENCY";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private TextBox txtAdditionalNote;
        private Label label6;
        private Panel panel2;
        private Label label1;
    }
}
