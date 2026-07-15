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
            label4 = new Label();
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
            label2.Location = new Point(19, 97);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 0;
            label2.Text = "MY REMINDERS";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Ivory;
            label3.Location = new Point(19, 142);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 1;
            label3.Text = "Search: ";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 172);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(316, 60);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightCyan;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.DarkSlateGray;
            btnSearch.Location = new Point(346, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 26);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += button1_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.LightCyan;
            btnRefresh.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.DarkSlateGray;
            btnRefresh.Location = new Point(346, 204);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 28);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Ivory;
            label4.Location = new Point(40, 475);
            label4.Name = "label4";
            label4.Size = new Size(376, 18);
            label4.TabIndex = 5;
            label4.Text = "Total: 0      | Pending: 0      | Emergency: 0";
            label4.Click += label4_Click;
            // 
            // btnTodayReminders
            // 
            btnTodayReminders.BackColor = Color.LightCyan;
            btnTodayReminders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodayReminders.ForeColor = Color.DarkSlateGray;
            btnTodayReminders.Location = new Point(40, 520);
            btnTodayReminders.Name = "btnTodayReminders";
            btnTodayReminders.Size = new Size(376, 32);
            btnTodayReminders.TabIndex = 6;
            btnTodayReminders.Text = "TODAY";
            btnTodayReminders.UseVisualStyleBackColor = false;
            // 
            // btnEmergency
            // 
            btnEmergency.BackColor = Color.LightCyan;
            btnEmergency.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergency.ForeColor = Color.DarkSlateGray;
            btnEmergency.Location = new Point(40, 570);
            btnEmergency.Name = "btnEmergency";
            btnEmergency.Size = new Size(376, 32);
            btnEmergency.TabIndex = 7;
            btnEmergency.Text = "EMERGENCY";
            btnEmergency.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.LightCyan;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.DarkSlateGray;
            btnBack.Location = new Point(40, 619);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(376, 32);
            btnBack.TabIndex = 8;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // dgvReminders
            // 
            dgvReminders.AllowUserToAddRows = false;
            dgvReminders.AllowUserToDeleteRows = false;
            dgvReminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReminders.BackgroundColor = Color.White;
            dgvReminders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReminders.Columns.AddRange(new DataGridViewColumn[] { colReminderID, colDate, colTime, colTitle, colStatus });
            dgvReminders.Location = new Point(19, 276);
            dgvReminders.Name = "dgvReminders";
            dgvReminders.ReadOnly = true;
            dgvReminders.RowHeadersVisible = false;
            dgvReminders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReminders.Size = new Size(417, 162);
            dgvReminders.TabIndex = 4;
            dgvReminders.CellContentClick += dgvReminders_CellContentClick;
            // 
            // colReminderID
            // 
            colReminderID.HeaderText = "ID";
            colReminderID.Name = "colReminderID";
            colReminderID.ReadOnly = true;
            colReminderID.Visible = false;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTime
            // 
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Reminder";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 70);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 45);
            label1.TabIndex = 1;
            label1.Text = "REMINDERS";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnEmergency);
            panel1.Controls.Add(btnTodayReminders);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dgvReminders);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnRefresh);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 663);
            panel1.TabIndex = 9;
            // 
            // FrmReminders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(457, 663);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label label4;
        private DataGridView dgvReminders;
        private DataGridViewTextBoxColumn colReminderID;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
    }
}