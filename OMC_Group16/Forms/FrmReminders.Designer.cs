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
            btnBack = new Button();
            dgvReminders = new DataGridView();
            colReminderID = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lblEmergencyCount = new Label();
            lblPendingCount = new Label();
            btnVoiceAssistant = new Button();
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
            label3.Location = new Point(22, 189);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 1;
            label3.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 229);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(361, 79);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkOliveGreen;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.DarkKhaki;
            btnSearch.Location = new Point(346, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 35);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DarkOliveGreen;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.DarkKhaki;
            btnRefresh.Location = new Point(346, 204);
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
            lblTotalCount.Location = new Point(19, 475);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(72, 18);
            lblTotalCount.TabIndex = 5;
            lblTotalCount.Text = "Total: 0";
            lblTotalCount.Click += label4_Click;
            // 
            // btnTodayReminders
            // 
            btnTodayReminders.BackColor = Color.LightCyan;
            btnTodayReminders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodayReminders.ForeColor = Color.DarkSlateGray;
            btnTodayReminders.Location = new Point(46, 693);
            btnTodayReminders.Margin = new Padding(3, 4, 3, 4);
            btnTodayReminders.Name = "btnTodayReminders";
            btnTodayReminders.Size = new Size(430, 43);
            btnTodayReminders.TabIndex = 6;
            btnTodayReminders.Text = "TODAY";
            btnTodayReminders.UseVisualStyleBackColor = false;
            btnTodayReminders.Click += btnTodayReminders_Click;
            // 
            // btnEmergency
            // 
            btnEmergency.BackColor = Color.LightCyan;
            btnEmergency.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergency.ForeColor = Color.DarkSlateGray;
            btnEmergency.Location = new Point(46, 760);
            btnEmergency.Margin = new Padding(3, 4, 3, 4);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(430, 43);
            btnEmergency.TabIndex = 7;
            btnEmergency.Text = "EMERGENCY";
            btnEmergency.UseVisualStyleBackColor = false;
            btnEmergency.Click += btnEmergency_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCyan;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.DarkSlateGray;
            btnBack.Location = new Point(46, 825);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(430, 43);
            btnBack.TabIndex = 8;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // dgvReminders
            // 
            dgvReminders.AllowUserToAddRows = false;
            dgvReminders.AllowUserToDeleteRows = false;
            dgvReminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReminders.BackgroundColor = Color.White;
            dgvReminders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReminders.Columns.AddRange(new DataGridViewColumn[] { colReminderID, colDate, colTime, colTitle, colStatus });
            dgvReminders.Location = new Point(22, 368);
            dgvReminders.Margin = new Padding(3, 4, 3, 4);
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
            label1.Location = new Point(131, 24);
            label1.Name = "label1";
            label1.Size = new Size(252, 54);
            label1.TabIndex = 1;
            label1.Text = "REMINDERS";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVoiceAssistant);
            panel1.Controls.Add(lblEmergencyCount);
            panel1.Controls.Add(lblPendingCount);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBack);
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
            panel1.Size = new Size(522, 884);
            panel1.TabIndex = 9;
            // 
            // lblEmergencyCount
            // 
            lblEmergencyCount.AutoSize = true;
            lblEmergencyCount.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyCount.ForeColor = Color.Ivory;
            lblEmergencyCount.Location = new Point(316, 475);
            lblEmergencyCount.Name = "lblEmergencyCount";
            lblEmergencyCount.Size = new Size(120, 18);
            lblEmergencyCount.TabIndex = 10;
            lblEmergencyCount.Text = "| Emergency: 0";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.Ivory;
            lblPendingCount.Location = new Point(154, 475);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(104, 18);
            lblPendingCount.TabIndex = 9;
            lblPendingCount.Text = "| Pending: 0";
            // 
            // btnVoiceAssistant
            // 
            btnVoiceAssistant.BackColor = Color.DarkOliveGreen;
            btnVoiceAssistant.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoiceAssistant.ForeColor = Color.DarkKhaki;
            btnVoiceAssistant.Location = new Point(154, 97);
            btnVoiceAssistant.Name = "btnVoiceAssistant";
            btnVoiceAssistant.Size = new Size(282, 32);
            btnVoiceAssistant.TabIndex = 11;
            btnVoiceAssistant.Text = "VOICE ASSISTANT";
            btnVoiceAssistant.UseVisualStyleBackColor = false;
            // 
            // FrmReminders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(522, 884);
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
        private Button btnBack;
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
    }
}