namespace OMC_Group16
{
    partial class FrmReminders
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
            label2 = new Label();
            label3 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            lblTotalCount = new Label();
            btnTodayReminders = new Button();
            btnEmergency = new Button();
            button2 = new Button();
            dgvReminders = new DataGridView();
            colReminderID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            btnVoiceAssistant = new Button();
            lblEmergencyCount = new Label();
            lblPendingCount = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReminders).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.Ivory;
            label2.Location = new Point(22, 129);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 0;
            label2.Text = "MY REMINDERS";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(19, 135);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 1;
            label3.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 158);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(361, 79);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.DarkKhaki;
            btnSearch.Location = new Point(346, 154);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkOliveGreen;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.DarkKhaki;
            btnRefresh.Location = new Point(346, 190);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCount.ForeColor = Color.Ivory;
            lblTotalCount.Location = new Point(33, 417);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(90, 22);
            lblTotalCount.TabIndex = 5;
            lblTotalCount.Text = "Total: 0";
            lblTotalCount.Click += label4_Click;
            // 
            // btnTodayReminders
            // 
            btnTodayReminders.BackColor = Color.FromArgb(255, 128, 0);
            btnTodayReminders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodayReminders.ForeColor = Color.White;
            btnTodayReminders.Location = new Point(44, 459);
            btnTodayReminders.Name = "btnTodayReminders";
            btnTodayReminders.Size = new Size(430, 43);
            btnTodayReminders.TabIndex = 6;
            btnTodayReminders.Text = "TODAY";
            btnTodayReminders.UseVisualStyleBackColor = false;
            btnTodayReminders.Click += btnTodayReminders_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.BackColor = Color.Red;
            btnEmergency.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergency.ForeColor = Color.White;
            btnEmergency.Location = new Point(44, 497);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(430, 43);
            btnEmergency.TabIndex = 7;
            btnEmergency.Text = "EMERGENCY";
            btnEmergency.UseVisualStyleBackColor = false;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.DarkSlateGray;
            button2.Location = new Point(40, 619);
            button2.Name = "button2";
            button2.Size = new Size(376, 32);
            button2.TabIndex = 8;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnBack_Click;
            // 
            // dgvReminders
            // 
            dgvReminders.AllowUserToAddRows = false;
            dgvReminders.AllowUserToDeleteRows = false;
            dgvReminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReminders.BackgroundColor = Color.White;
            dgvReminders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReminders.Columns.AddRange(new DataGridViewColumn[] { colReminderID, colDate, colTime, colTitle, colStatus });
            dgvReminders.Location = new Point(19, 237);
            dgvReminders.Name = "dgvReminders";
            dgvReminders.ReadOnly = true;
            dgvReminders.RowHeadersVisible = false;
            dgvReminders.RowHeadersWidth = 51;
            dgvReminders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReminders.Size = new Size(477, 216);
            dgvReminders.TabIndex = 4;
            dgvReminders.CellContentClick += dgvReminders_CellContentClick;
            // 
            // colReminderID
            // 
            colReminderID.HeaderText = "ID";
            colReminderID.MinimumWidth = 6;
            colReminderID.Name = "colReminderID";
            colReminderID.ReadOnly = true;
            colReminderID.Visible = false;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Reminder";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 99);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(150, 25);
            label1.Name = "label1";
            label1.Size = new Size(252, 54);
            label1.TabIndex = 1;
            label1.Text = "REMINDERS";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnVoiceAssistant);
            panel1.Controls.Add(lblEmergencyCount);
            panel1.Controls.Add(lblPendingCount);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEmergency);
            panel1.Controls.Add(btnTodayReminders);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotalCount);
            panel1.Controls.Add(dgvReminders);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnRefresh);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 788);
            panel1.TabIndex = 9;
            // 
            // btnVoiceAssistant
            // 
            btnVoiceAssistant.BackColor = Color.DarkOliveGreen;
            btnVoiceAssistant.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoiceAssistant.ForeColor = Color.DarkKhaki;
            btnVoiceAssistant.Location = new Point(216, 129);
            btnVoiceAssistant.Name = "btnVoiceAssistant";
            btnVoiceAssistant.Size = new Size(282, 32);
            btnVoiceAssistant.TabIndex = 11;
            btnVoiceAssistant.Text = "VOICE ASSISTANT";
            btnVoiceAssistant.UseVisualStyleBackColor = false;
            btnVoiceAssistant.Click += btnVoiceAssistant_Click;
            // 
            // lblEmergencyCount
            // 
            lblEmergencyCount.AutoSize = true;
            lblEmergencyCount.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyCount.ForeColor = Color.Ivory;
            lblEmergencyCount.Location = new Point(300, 417);
            lblEmergencyCount.Name = "lblEmergencyCount";
            lblEmergencyCount.Size = new Size(150, 22);
            lblEmergencyCount.TabIndex = 10;
            lblEmergencyCount.Text = "| Emergency: 0";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.Ivory;
            lblPendingCount.Location = new Point(155, 417);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(130, 22);
            lblPendingCount.TabIndex = 9;
            lblPendingCount.Text = "| Pending: 0";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(44, 535);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(376, 32);
            btnBack.TabIndex = 12;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // FrmReminders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(522, 788);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmReminders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReminders";
            Load += FrmReminders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReminders).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label3;
        private Button button2;
        private Button btnEmergency;
        private Button btnTodayReminders;
        private Label lblTotalCount;
        private DataGridView dgvReminders;
        private DataGridViewTextBoxColumn colReminderID;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label lblEmergencyCount;
        private Label lblPendingCount;
        private Button btnVoiceAssistant;
        private Button btnBack;
    }
}