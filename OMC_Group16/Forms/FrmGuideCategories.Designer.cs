namespace OMC_Group16.Forms
{
    partial class FrmGuideCategories
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
            label1 = new Label();
            btnBank = new Button();
            btnHealth = new Button();
            btnEWallet = new Button();
            btnMessage = new Button();
            btnGov = new Button();
            btnTransport = new Button();
            btnNextGuide = new Button();
            btnBack = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnVoiceAssist = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkOliveGreen;
            label1.Font = new Font("Calibri", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkKhaki;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(763, 248);
            label1.TabIndex = 0;
            label1.Text = "Guide Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBank
            // 
            btnBank.BackColor = Color.FromArgb(57, 166, 163);
            btnBank.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBank.Location = new Point(3, 3);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(250, 194);
            btnBank.TabIndex = 1;
            btnBank.Text = "Online Banking";
            btnBank.UseVisualStyleBackColor = false;
            btnBank.Click += btnBank_Click;
            // 
            // btnHealth
            // 
            btnHealth.BackColor = Color.FromArgb(226, 74, 50);
            btnHealth.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHealth.Location = new Point(515, 3);
            btnHealth.Name = "btnHealth";
            btnHealth.Size = new Size(250, 194);
            btnHealth.TabIndex = 2;
            btnHealth.Text = "Healthcare";
            btnHealth.UseVisualStyleBackColor = false;
            btnHealth.Click += btnHealth_Click;
            // 
            // btnEWallet
            // 
            btnEWallet.BackColor = Color.FromArgb(57, 166, 163);
            btnEWallet.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEWallet.Location = new Point(259, 3);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(250, 194);
            btnEWallet.TabIndex = 3;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.UseVisualStyleBackColor = false;
            btnEWallet.Click += btnEWallet_Click_1;
            // 
            // btnMessage
            // 
            btnMessage.BackColor = Color.FromArgb(232, 156, 51);
            btnMessage.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMessage.Location = new Point(259, 203);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(250, 194);
            btnMessage.TabIndex = 4;
            btnMessage.Text = "Messages";
            btnMessage.UseVisualStyleBackColor = false;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnGov
            // 
            btnGov.BackColor = Color.OrangeRed;
            btnGov.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGov.Location = new Point(3, 203);
            btnGov.Name = "btnGov";
            btnGov.Size = new Size(250, 194);
            btnGov.TabIndex = 5;
            btnGov.Text = "Scam Alert";
            btnGov.UseVisualStyleBackColor = false;
            btnGov.Click += btnGov_Click;
            // 
            // btnTransport
            // 
            btnTransport.BackColor = Color.Orange;
            btnTransport.Font = new Font("Calibri", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransport.Location = new Point(515, 203);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(251, 194);
            btnTransport.TabIndex = 6;
            btnTransport.Text = "Transport";
            btnTransport.UseVisualStyleBackColor = false;
            btnTransport.Click += btnTransport_Click_1;
            // 
            // btnNextGuide
            // 
            btnNextGuide.BackColor = Color.OliveDrab;
            btnNextGuide.Enabled = false;
            btnNextGuide.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNextGuide.ForeColor = Color.Khaki;
            btnNextGuide.Location = new Point(550, 779);
            btnNextGuide.Name = "btnNextGuide";
            btnNextGuide.Size = new Size(205, 62);
            btnNextGuide.TabIndex = 7;
            btnNextGuide.Text = "Next Guide -->";
            btnNextGuide.UseVisualStyleBackColor = false;
            btnNextGuide.Click += btnNextGuide_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OliveDrab;
            btnBack.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Khaki;
            btnBack.Location = new Point(12, 781);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(174, 62);
            btnBack.TabIndex = 8;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 554F));
            tableLayoutPanel1.Controls.Add(btnTransport, 2, 1);
            tableLayoutPanel1.Controls.Add(btnBank, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGov, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMessage, 1, 1);
            tableLayoutPanel1.Controls.Add(btnEWallet, 1, 0);
            tableLayoutPanel1.Controls.Add(btnHealth, 2, 0);
            tableLayoutPanel1.Location = new Point(-1, 250);
            tableLayoutPanel1.Margin = new Padding(20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1067, 400);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btnVoiceAssist
            // 
            btnVoiceAssist.BackColor = Color.FromArgb(127, 166, 122);
            btnVoiceAssist.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceAssist.ForeColor = SystemColors.ButtonHighlight;
            btnVoiceAssist.Location = new Point(12, 12);
            btnVoiceAssist.Name = "btnVoiceAssist";
            btnVoiceAssist.Size = new Size(153, 90);
            btnVoiceAssist.TabIndex = 10;
            btnVoiceAssist.Text = "🔊 Turn Voice ON";
            btnVoiceAssist.UseVisualStyleBackColor = false;
            btnVoiceAssist.Click += btnVoiceAssist_Click_1;
            // 
            // FrmGuideCategories
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(767, 1054);
            Controls.Add(btnVoiceAssist);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(btnNextGuide);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGuideCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmGuideCategories";
            Load += FrmGuideCategories_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBank;
        private Button btnHealth;
        private Button btnEWallet;
        private Button btnMessage;
        private Button btnGov;
        private Button btnTransport;
        private Button btnNextGuide;
        private Button btnBack;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnVoiceAssist;
    }
}