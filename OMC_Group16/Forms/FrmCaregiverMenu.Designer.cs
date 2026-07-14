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
            btnReminder.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReminder.Location = new Point(111, 77);
            btnReminder.Name = "btnReminder";
            btnReminder.Size = new Size(243, 35);
            btnReminder.TabIndex = 0;
            btnReminder.Text = "ADD REMINDER";
            btnReminder.UseVisualStyleBackColor = true;
            btnReminder.Click += btnReminder_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergency.Location = new Point(111, 172);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(243, 35);
            btnEmergency.TabIndex = 1;
            btnEmergency.Text = "EMERGENCY CONTACT";
            btnEmergency.UseVisualStyleBackColor = true;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(111, 277);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 35);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(111, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(221, 35);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 832);
            panel1.TabIndex = 4;
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
    }
}