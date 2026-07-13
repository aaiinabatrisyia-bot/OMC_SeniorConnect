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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReminder
            // 
            btnReminder.Location = new Point(97, 58);
            btnReminder.Margin = new Padding(3, 2, 3, 2);
            btnReminder.Name = "btnReminder";
            btnReminder.Size = new Size(213, 26);
            btnReminder.TabIndex = 0;
            btnReminder.Text = "Add Reminder";
            btnReminder.UseVisualStyleBackColor = true;
            btnReminder.Click += btnReminder_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Location = new Point(97, 129);
            btnEmergency.Margin = new Padding(3, 2, 3, 2);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(213, 26);
            btnEmergency.TabIndex = 1;
            btnEmergency.Text = "Emergency Contacts";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(97, 208);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(213, 26);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(97, 283);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(193, 26);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnEmergency);
            panel1.Controls.Add(btnReminder);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 624);
            panel1.TabIndex = 4;
            // 
            // FrmCaregiverMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 624);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}