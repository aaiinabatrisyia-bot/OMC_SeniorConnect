namespace OMC_Group16
{
<<<<<<< HEAD:OMC_Group16/Form1.Designer.cs
    partial class frmEmergency
=======
    partial class FrmEmergency
>>>>>>> 472a24c1f2d47f069ee400d79b13a5bfd1763a2c:OMC_Group16/Forms/FrmEmergency.Designer.cs
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
<<<<<<< HEAD:OMC_Group16/Form1.Designer.cs
            panel1 = new Panel();
            btnClear = new Button();
            btnSubmit = new Button();
            txtNote = new TextBox();
            lblNote = new Label();
            txtAddress = new TextBox();
            txtEmergencyContact = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            lblAddress = new Label();
            lblEmergencyContact = new Label();
            lblPhone = new Label();
            lblName = new Label();
            btnNearbyClinic = new Button();
            btnContactFamily = new Button();
            btnAmbulance = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSubmit);
            panel1.Controls.Add(txtNote);
            panel1.Controls.Add(lblNote);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtEmergencyContact);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(lblEmergencyContact);
            panel1.Controls.Add(lblPhone);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(btnNearbyClinic);
            panel1.Controls.Add(btnContactFamily);
            panel1.Controls.Add(btnAmbulance);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(64, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 521);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(0, 64, 0);
            btnClear.ForeColor = Color.DarkKhaki;
            btnClear.Location = new Point(198, 464);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(163, 33);
            btnClear.TabIndex = 16;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(0, 64, 0);
            btnSubmit.ForeColor = Color.DarkKhaki;
            btnSubmit.Location = new Point(15, 464);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(163, 33);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(166, 415);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(173, 27);
            txtNote.TabIndex = 14;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.ForeColor = Color.FromArgb(128, 128, 255);
            lblNote.Location = new Point(39, 418);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(109, 20);
            lblNote.TabIndex = 13;
            lblNote.Text = "Addional Note";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(166, 229);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 37);
            txtAddress.TabIndex = 12;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.Location = new Point(166, 174);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(173, 27);
            txtEmergencyContact.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(166, 134);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(173, 27);
            txtPhone.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 96);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 27);
            txtName.TabIndex = 9;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.ForeColor = Color.FromArgb(128, 128, 255);
            lblAddress.Location = new Point(37, 232);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(63, 20);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Address";
            // 
            // lblEmergencyContact
            // 
            lblEmergencyContact.ForeColor = Color.FromArgb(128, 128, 255);
            lblEmergencyContact.Location = new Point(37, 177);
            lblEmergencyContact.Name = "lblEmergencyContact";
            lblEmergencyContact.Size = new Size(116, 55);
            lblEmergencyContact.TabIndex = 7;
            lblEmergencyContact.Text = "Emergency Contact";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.ForeColor = Color.FromArgb(128, 128, 255);
            lblPhone.Location = new Point(39, 137);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(114, 20);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone Number";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.FromArgb(128, 128, 255);
            lblName.Location = new Point(37, 99);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 20);
            lblName.TabIndex = 5;
            lblName.Text = "Name ";
            // 
            // btnNearbyClinic
            // 
            btnNearbyClinic.BackColor = Color.Teal;
            btnNearbyClinic.ForeColor = Color.FromArgb(128, 255, 255);
            btnNearbyClinic.Location = new Point(27, 362);
            btnNearbyClinic.Name = "btnNearbyClinic";
            btnNearbyClinic.Size = new Size(324, 33);
            btnNearbyClinic.TabIndex = 4;
            btnNearbyClinic.Text = "FIND NEARBY CLINIC";
            btnNearbyClinic.UseVisualStyleBackColor = false;
            btnNearbyClinic.Click += btnNearbyClinic_Click;
            // 
            // btnContactFamily
            // 
            btnContactFamily.BackColor = Color.FromArgb(255, 128, 0);
            btnContactFamily.ForeColor = Color.FromArgb(255, 192, 128);
            btnContactFamily.Location = new Point(27, 323);
            btnContactFamily.Name = "btnContactFamily";
            btnContactFamily.Size = new Size(324, 33);
            btnContactFamily.TabIndex = 3;
            btnContactFamily.Text = "CONTACT FAMILY";
            btnContactFamily.UseVisualStyleBackColor = false;
            btnContactFamily.Click += btnContactFamily_Click;
            // 
            // btnAmbulance
            // 
            btnAmbulance.BackColor = Color.Red;
            btnAmbulance.ForeColor = Color.Maroon;
            btnAmbulance.Location = new Point(27, 284);
            btnAmbulance.Name = "btnAmbulance";
            btnAmbulance.Size = new Size(324, 33);
            btnAmbulance.TabIndex = 2;
            btnAmbulance.Text = "AMBULANCE";
            btnAmbulance.UseVisualStyleBackColor = false;
            btnAmbulance.Click += btnAmbulance_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 46);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkKhaki;
            label2.Location = new Point(112, 10);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 0;
            label2.Text = "Emergency";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "SeniorConnect";
            label1.Click += label1_Click;
            // 
            // frmEmergency
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 585);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmEmergency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Emergency Form";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
=======
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FrmEmergency";
>>>>>>> 472a24c1f2d47f069ee400d79b13a5bfd1763a2c:OMC_Group16/Forms/FrmEmergency.Designer.cs
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button btnAmbulance;
        private TextBox txtAddress;
        private TextBox txtEmergencyContact;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label lblAddress;
        private Label lblEmergencyContact;
        private Label lblPhone;
        private Label lblName;
        private Button btnNearbyClinic;
        private Button btnContactFamily;
        private TextBox txtNote;
        private Label lblNote;
        private Button btnClear;
        private Button btnSubmit;
    }
}