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
            SuspendLayout();
            // 
            // btnReminder
            // 
            btnReminder.Location = new Point(59, 36);
            btnReminder.Name = "btnReminder";
            btnReminder.Size = new Size(94, 29);
            btnReminder.TabIndex = 0;
            btnReminder.Text = "Reminder";
            btnReminder.UseVisualStyleBackColor = true;
            btnReminder.Click += btnReminder_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Location = new Point(59, 85);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(94, 29);
            btnEmergency.TabIndex = 1;
            btnEmergency.Text = "Emergency Contacts";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(59, 139);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FrmCaregiverMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnEmergency);
            Controls.Add(btnReminder);
            Name = "FrmCaregiverMenu";
            Text = "FrmCaregiverMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReminder;
        private Button btnEmergency;
        private Button btnLogout;
    }
}