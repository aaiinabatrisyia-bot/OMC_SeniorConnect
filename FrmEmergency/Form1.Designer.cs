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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(txtAdditionalNote);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnNearbyClinic);
            panel1.Controls.Add(btnEmergencyContact);
            panel1.Controls.Add(btnAmbulance);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmergencyContact);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(267, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 464);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkOliveGreen;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnExit.ForeColor = Color.DarkKhaki;
            btnExit.Location = new Point(152, 420);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(109, 27);
            btnExit.TabIndex = 24;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOliveGreen;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnClear.ForeColor = Color.DarkKhaki;
            btnClear.Location = new Point(17, 420);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 27);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtAdditionalNote
            // 
            txtAdditionalNote.Location = new Point(105, 366);
            txtAdditionalNote.Multiline = true;
            txtAdditionalNote.Name = "txtAdditionalNote";
            txtAdditionalNote.Size = new Size(158, 44);
            txtAdditionalNote.TabIndex = 22;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Ivory;
            label6.Location = new Point(17, 366);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 21;
            label6.Text = "Additional Note";
            // 
            // btnNearbyClinic
            // 
            btnNearbyClinic.BackColor = Color.Teal;
            btnNearbyClinic.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNearbyClinic.ForeColor = Color.LightCyan;
            btnNearbyClinic.Location = new Point(17, 326);
            btnNearbyClinic.Name = "btnNearbyClinic";
            btnNearbyClinic.Size = new Size(244, 30);
            btnNearbyClinic.TabIndex = 20;
            btnNearbyClinic.Text = "NEARBY CLINIC";
            btnNearbyClinic.UseVisualStyleBackColor = false;
            // 
            // btnEmergencyContact
            // 
            btnEmergencyContact.BackColor = Color.DarkOrange;
            btnEmergencyContact.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEmergencyContact.ForeColor = Color.FloralWhite;
            btnEmergencyContact.Location = new Point(17, 290);
            btnEmergencyContact.Name = "btnEmergencyContact";
            btnEmergencyContact.Size = new Size(244, 30);
            btnEmergencyContact.TabIndex = 19;
            btnEmergencyContact.Text = "EMERGENCY CONTACT";
            btnEmergencyContact.UseVisualStyleBackColor = false;
            // 
            // btnAmbulance
            // 
            btnAmbulance.BackColor = Color.Red;
            btnAmbulance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAmbulance.ForeColor = Color.MistyRose;
            btnAmbulance.Location = new Point(17, 254);
            btnAmbulance.Name = "btnAmbulance";
            btnAmbulance.Size = new Size(244, 30);
            btnAmbulance.TabIndex = 18;
            btnAmbulance.Text = "AMBULANCE";
            btnAmbulance.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(103, 204);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(158, 44);
            txtAddress.TabIndex = 17;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Location = new Point(103, 163);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(158, 23);
            txtEmergencyContact.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(103, 125);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(158, 23);
            txtPhoneNumber.TabIndex = 15;
            // 
            // txtName
            // 
            txtName.Location = new Point(103, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 23);
            txtName.TabIndex = 14;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Ivory;
            label5.Location = new Point(17, 207);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Ivory;
            label4.Location = new Point(17, 163);
            label4.Name = "label4";
            label4.Size = new Size(74, 33);
            label4.TabIndex = 12;
            label4.Text = "Emergency Contact";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(17, 116);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(17, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 10;
            label2.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 69);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(210, 45);
            label1.TabIndex = 0;
            label1.Text = "EMERGENCY";
            // 
            // FrmEmergency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(panel1);
            Name = "FrmEmergency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EMERGENCY";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
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
        private TextBox txtAdditionalNote;
        private Label label6;
    }
}
