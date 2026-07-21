namespace OMC_Group16
{
    partial class FrmCaregiverMenu
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
            btnReminder = new Button();
            btnEmergency = new Button();
            btnLogout = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            btnSeniorManagement = new Button();
            btnBookAppointment = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReminder
            // 
            btnReminder.BackColor = Color.OrangeRed;
            btnReminder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReminder.ForeColor = SystemColors.ButtonFace;
            btnReminder.Location = new Point(77, 203);
            btnReminder.Name = "btnReminder";
            btnReminder.Size = new Size(342, 35);
            btnReminder.TabIndex = 0;
            btnReminder.Text = "ADD REMINDER";
            btnReminder.UseVisualStyleBackColor = false;
            btnReminder.Click += btnReminder_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.BackColor = Color.Goldenrod;
            btnEmergency.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergency.ForeColor = SystemColors.ButtonFace;
            btnEmergency.Location = new Point(77, 257);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(342, 35);
            btnEmergency.TabIndex = 1;
            btnEmergency.Text = "EMERGENCY CONTACT";
            btnEmergency.UseVisualStyleBackColor = false;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Green;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ButtonFace;
            btnLogout.Location = new Point(77, 419);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(342, 35);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Green;
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.ButtonFace;
            btnBack.Location = new Point(77, 469);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(342, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnSeniorManagement);
            panel1.Controls.Add(btnBookAppointment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnEmergency);
            panel1.Controls.Add(btnReminder);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(504, 832);
            panel1.TabIndex = 4;
            // 
            // btnSeniorManagement
            // 
            btnSeniorManagement.BackColor = Color.MediumVioletRed;
            btnSeniorManagement.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeniorManagement.ForeColor = SystemColors.ButtonFace;
            btnSeniorManagement.Location = new Point(77, 362);
            btnSeniorManagement.Name = "btnSeniorManagement";
            btnSeniorManagement.Size = new Size(342, 35);
            btnSeniorManagement.TabIndex = 6;
            btnSeniorManagement.Text = "SENIOR MANAGEMENT";
            btnSeniorManagement.UseVisualStyleBackColor = false;
            btnSeniorManagement.Click += btnSeniorManagement_Click;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = Color.DarkMagenta;
            btnBookAppointment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookAppointment.ForeColor = SystemColors.ButtonFace;
            btnBookAppointment.Location = new Point(77, 312);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(342, 35);
            btnBookAppointment.TabIndex = 5;
            btnBookAppointment.Text = "BOOK APPOINTMENT";
            btnBookAppointment.UseVisualStyleBackColor = false;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(504, 73);
            label1.TabIndex = 4;
            label1.Text = "CAREGIVER MENU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCaregiverMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 832);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCaregiverMenu";
            Text = "FrmCaregiverMenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnReminder;
        private Button btnEmergency;
        private Button btnLogout;
        private Button btnBack;
        private Panel panel1;
        private Label label1;
        private Button btnBookAppointment;
        private Button btnSeniorManagement;
    }
}