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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            btnTodayReminders = new Button();
            dgvReminders = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            lblStatus = new Label();
            lblTitle = new Label();
            lblDate = new Label();
            txtDescription = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnBack = new Button();
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
            label2.Location = new Point(22, 110);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 0;
            label2.Text = "MY REMINDERS";
            label2.Click += label2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(21, 212);
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
            btnSearch.Location = new Point(395, 212);
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
            btnRefresh.Location = new Point(395, 254);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(103, 37);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnTodayReminders
            // 
            btnTodayReminders.BackColor = Color.FromArgb(255, 128, 0);
            btnTodayReminders.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodayReminders.ForeColor = Color.White;
            btnTodayReminders.Location = new Point(45, 766);
            btnTodayReminders.Name = "btnTodayReminders";
            btnTodayReminders.Size = new Size(430, 43);
            btnTodayReminders.TabIndex = 6;
            btnTodayReminders.Text = "TODAY";
            btnTodayReminders.UseVisualStyleBackColor = false;
            btnTodayReminders.Click += btnTodayReminders_Click;
            // 
            // dgvReminders
            // 
            dgvReminders.AllowUserToAddRows = false;
            dgvReminders.AllowUserToDeleteRows = false;
            dgvReminders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReminders.BackgroundColor = Color.White;
            dgvReminders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReminders.Location = new Point(22, 313);
            dgvReminders.Name = "dgvReminders";
            dgvReminders.ReadOnly = true;
            dgvReminders.RowHeadersVisible = false;
            dgvReminders.RowHeadersWidth = 51;
            dgvReminders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReminders.Size = new Size(477, 216);
            dgvReminders.TabIndex = 4;
            dgvReminders.CellContentClick += dgvReminders_CellContentClick;
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
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnVoiceAssistant);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnTodayReminders);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(132, 657);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 25);
            lblStatus.TabIndex = 21;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(118, 602);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 25);
            lblTitle.TabIndex = 20;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(118, 550);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(0, 25);
            lblDate.TabIndex = 19;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(313, 578);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(185, 115);
            txtDescription.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(47, 657);
            label8.Name = "label8";
            label8.Size = new Size(79, 25);
            label8.TabIndex = 17;
            label8.Text = "STATUS:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(313, 550);
            label7.Name = "label7";
            label7.Size = new Size(129, 25);
            label7.TabIndex = 16;
            label7.Text = "DESCRIPTION:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 602);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 15;
            label6.Text = "TITLE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(45, 550);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 14;
            label5.Text = "DATE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.Ivory;
            label4.Location = new Point(21, 184);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 13;
            label4.Text = "SEARCH";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 192, 192);
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(45, 815);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(430, 40);
            btnBack.TabIndex = 12;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnVoiceAssistant
            // 
            btnVoiceAssistant.BackColor = Color.DarkOliveGreen;
            btnVoiceAssistant.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoiceAssistant.ForeColor = Color.DarkKhaki;
            btnVoiceAssistant.Location = new Point(216, 129);
            btnVoiceAssistant.Name = "btnVoiceAssistant";
            btnVoiceAssistant.Size = new Size(282, 43);
            btnVoiceAssistant.TabIndex = 11;
            btnVoiceAssistant.Text = "VOICE ASSISTANT";
            btnVoiceAssistant.UseVisualStyleBackColor = false;
            btnVoiceAssistant.Click += btnVoiceAssistant_Click;
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
        private Button btnTodayReminders;
        private DataGridView dgvReminders;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Button btnVoiceAssistant;
        private Button btnBack;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lblStatus;
        private Label lblTitle;
        private Label lblDate;
        private TextBox txtDescription;
        private Label label8;
        private Label label7;
    }
}