namespace OMC_Group16.Forms
{
    partial class FrmEmergencyContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmergencyContact));
            label1 = new Label();
            lblContactName = new Label();
            label2 = new Label();
            label3 = new Label();
            lblRelationship = new Label();
            lblPhoneNumber = new Label();
            btnCall = new Button();
            btnBack = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            cmbContact = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 257);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "CONTACT NAME:";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblContactName.ForeColor = Color.White;
            lblContactName.Location = new Point(257, 257);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(0, 25);
            lblContactName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(67, 324);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "RELATIONSHIP:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 392);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 3;
            label3.Text = "PHONE NUMBER:";
            // 
            // lblRelationship
            // 
            lblRelationship.AutoSize = true;
            lblRelationship.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblRelationship.ForeColor = Color.White;
            lblRelationship.Location = new Point(257, 324);
            lblRelationship.Name = "lblRelationship";
            lblRelationship.Size = new Size(0, 25);
            lblRelationship.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPhoneNumber.ForeColor = Color.White;
            lblPhoneNumber.Location = new Point(257, 392);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(0, 25);
            lblPhoneNumber.TabIndex = 5;
            // 
            // btnCall
            // 
            btnCall.BackColor = Color.FromArgb(128, 255, 128);
            btnCall.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCall.Location = new Point(62, 462);
            btnCall.Name = "btnCall";
            btnCall.Size = new Size(187, 74);
            btnCall.TabIndex = 6;
            btnCall.Text = "CALL";
            btnCall.UseVisualStyleBackColor = false;
            btnCall.Click += btnCall_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Black;
            btnBack.Location = new Point(172, 566);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(187, 77);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOliveGreen;
            label4.Dock = DockStyle.Top;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(504, 88);
            label4.TabIndex = 8;
            label4.Text = "EMERGENCY";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(276, 462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // cmbContact
            // 
            cmbContact.FormattingEnabled = true;
            cmbContact.Location = new Point(68, 190);
            cmbContact.Name = "cmbContact";
            cmbContact.Size = new Size(151, 28);
            cmbContact.TabIndex = 10;
            cmbContact.SelectedIndexChanged += cmbContact_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 148);
            label5.Name = "label5";
            label5.Size = new Size(156, 25);
            label5.TabIndex = 11;
            label5.Text = "SELECT CONTACT";
            // 
            // FrmEmergencyContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(504, 741);
            Controls.Add(label5);
            Controls.Add(cmbContact);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnCall);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblRelationship);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblContactName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmergencyContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEmergencyContact";
            Load += FrmEmergencyContact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblContactName;
        private Label label2;
        private Label label3;
        private Label lblRelationship;
        private Label lblPhoneNumber;
        private Button btnCall;
        private Button btnBack;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox cmbContact;
        private Label label5;
    }
}