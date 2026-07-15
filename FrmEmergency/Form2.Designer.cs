namespace FrmEmergency
{
    partial class FrmReminder
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
            panel1 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            dtpTime = new DateTimePicker();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txtTitle = new TextBox();
            cmbPriority = new ComboBox();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            btnCheckReminders = new Button();
            btnDelete = new Button();
            lvReminders = new ListView();
            txtSearch = new TextBox();
            panel5 = new Panel();
            btnSnooze = new Button();
            btnComplete = new Button();
            btnTestAlert = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(158, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 505);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtNotes);
            panel3.Controls.Add(cmbPriority);
            panel3.Controls.Add(txtTitle);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(dtpTime);
            panel3.Controls.Add(dtpDate);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(18, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(279, 232);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.GhostWhite;
            label6.Location = new Point(22, 139);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 6;
            label6.Text = "Notes";
            label6.Click += label6_Click;
            // 
            // dtpTime
            // 
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(93, 74);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new Size(172, 25);
            dtpTime.TabIndex = 5;
            dtpTime.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(93, 43);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(172, 25);
            dtpDate.TabIndex = 4;
            dtpDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.GhostWhite;
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(37, 17);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(22, 74);
            label4.Name = "label4";
            label4.Size = new Size(39, 17);
            label4.TabIndex = 2;
            label4.Text = "Time";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.GhostWhite;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 1;
            label3.Text = "Priority";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.GhostWhite;
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 0;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(601, 78);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(196, 15);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 1;
            label1.Text = "REMINDERS";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(93, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(172, 25);
            txtTitle.TabIndex = 7;
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "High", "Medium", "Low" });
            cmbPriority.Location = new Point(93, 107);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(172, 25);
            cmbPriority.TabIndex = 8;
            cmbPriority.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(93, 139);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = ScrollBars.Vertical;
            txtNotes.Size = new Size(172, 47);
            txtNotes.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOliveGreen;
            btnSave.ForeColor = Color.DarkKhaki;
            btnSave.Location = new Point(22, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 26);
            btnSave.TabIndex = 10;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkOliveGreen;
            btnClear.ForeColor = Color.DarkKhaki;
            btnClear.Location = new Point(170, 192);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 26);
            btnClear.TabIndex = 11;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(lvReminders);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnCheckReminders);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(312, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(279, 232);
            panel4.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.GhostWhite;
            label7.Location = new Point(334, 90);
            label7.Name = "label7";
            label7.Size = new Size(99, 17);
            label7.TabIndex = 12;
            label7.Text = "Reminder Lists";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.GhostWhite;
            label8.Location = new Point(22, 18);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 13;
            label8.Text = "Search";
            // 
            // btnCheckReminders
            // 
            btnCheckReminders.BackColor = Color.DarkOliveGreen;
            btnCheckReminders.ForeColor = Color.DarkKhaki;
            btnCheckReminders.Location = new Point(22, 189);
            btnCheckReminders.Name = "btnCheckReminders";
            btnCheckReminders.Size = new Size(142, 30);
            btnCheckReminders.TabIndex = 15;
            btnCheckReminders.Text = "CHECK REMINDERS";
            btnCheckReminders.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOliveGreen;
            btnDelete.ForeColor = Color.DarkKhaki;
            btnDelete.Location = new Point(170, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 28);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lvReminders
            // 
            lvReminders.FullRowSelect = true;
            lvReminders.GridLines = true;
            lvReminders.Location = new Point(22, 56);
            lvReminders.Name = "lvReminders";
            lvReminders.Size = new Size(243, 127);
            lvReminders.TabIndex = 17;
            lvReminders.UseCompatibleStateImageBehavior = false;
            lvReminders.View = View.Details;
            lvReminders.SelectedIndexChanged += lvReminders_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(86, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(179, 25);
            txtSearch.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnComplete);
            panel5.Controls.Add(btnTestAlert);
            panel5.Controls.Add(btnSnooze);
            panel5.Location = new Point(18, 374);
            panel5.Name = "panel5";
            panel5.Size = new Size(574, 56);
            panel5.TabIndex = 13;
            // 
            // btnSnooze
            // 
            btnSnooze.BackColor = Color.FromArgb(255, 192, 192);
            btnSnooze.ForeColor = Color.FromArgb(192, 0, 0);
            btnSnooze.Location = new Point(12, 18);
            btnSnooze.Name = "btnSnooze";
            btnSnooze.Size = new Size(151, 23);
            btnSnooze.TabIndex = 0;
            btnSnooze.Text = "SNOOZE 5  MINUTES";
            btnSnooze.UseVisualStyleBackColor = false;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.FromArgb(255, 224, 192);
            btnComplete.ForeColor = Color.FromArgb(192, 64, 0);
            btnComplete.Location = new Point(213, 18);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(151, 23);
            btnComplete.TabIndex = 12;
            btnComplete.Text = "MARK COMPLETE";
            btnComplete.UseVisualStyleBackColor = false;
            // 
            // btnTestAlert
            // 
            btnTestAlert.BackColor = Color.FromArgb(255, 255, 192);
            btnTestAlert.ForeColor = Color.Olive;
            btnTestAlert.Location = new Point(408, 18);
            btnTestAlert.Name = "btnTestAlert";
            btnTestAlert.Size = new Size(151, 23);
            btnTestAlert.TabIndex = 1;
            btnTestAlert.Text = "TEST ALERT";
            btnTestAlert.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label9.ForeColor = Color.GhostWhite;
            label9.Location = new Point(41, 90);
            label9.Name = "label9";
            label9.Size = new Size(133, 17);
            label9.TabIndex = 14;
            label9.Text = "Add New Reminders";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.GhostWhite;
            label10.Location = new Point(41, 354);
            label10.Name = "label10";
            label10.Size = new Size(93, 17);
            label10.TabIndex = 15;
            label10.Text = "Quick Actions";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.GhostWhite;
            label11.Location = new Point(18, 454);
            label11.Name = "label11";
            label11.Size = new Size(448, 18);
            label11.TabIndex = 12;
            label11.Text = "Total: 0  | Completed: 0  | Upcoming: 0  | Overdue: 0  ";
            // 
            // FrmReminder
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 553);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FrmReminder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REMINDER";
            Load += FrmReminder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpTime;
        private DateTimePicker dtpDate;
        private Label label6;
        private TextBox txtTitle;
        private ComboBox cmbPriority;
        private Button btnClear;
        private Button btnSave;
        private TextBox txtNotes;
        private Panel panel4;
        private Button btnDelete;
        private Button btnCheckReminders;
        private Label label8;
        private Label label7;
        private ListView lvReminders;
        private TextBox txtSearch;
        private Label label10;
        private Label label9;
        private Panel panel5;
        private Button btnComplete;
        private Button btnTestAlert;
        private Button btnSnooze;
        private Label label11;
    }
}