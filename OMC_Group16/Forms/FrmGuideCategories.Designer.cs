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
            btnEWallet1 = new Button();
            btnTransport1 = new Button();
            btnHealth1 = new Button();
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
            label1.Size = new Size(459, 75);
            label1.TabIndex = 0;
            label1.Text = "Guide Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBank
            // 
            btnBank.BackColor = Color.FromArgb(57, 166, 163);
            btnBank.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBank.ForeColor = Color.White;
            btnBank.Location = new Point(3, 3);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(136, 99);
            btnBank.TabIndex = 1;
            btnBank.Text = "ONLINE BANKING";
            btnBank.UseVisualStyleBackColor = false;
            btnBank.Click += btnBank_Click_1;
            // 
            // btnHealth
            // 
            btnHealth.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHealth.Location = new Point(566, 3);
            btnHealth.Name = "btnHealth";
            btnHealth.Size = new Size(557, 194);
            btnHealth.TabIndex = 2;
            btnHealth.Text = "Healthcare";
            btnHealth.UseVisualStyleBackColor = false;
            // 
            // btnEWallet
            // 
            btnEWallet.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEWallet.Location = new Point(1129, 3);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(548, 194);
            btnEWallet.TabIndex = 3;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.UseVisualStyleBackColor = false;
            // 
            // btnMessage
            // 
            btnMessage.BackColor = Color.FromArgb(232, 156, 51);
            btnMessage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMessage.ForeColor = Color.White;
            btnMessage.Location = new Point(155, 182);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(136, 100);
            btnMessage.TabIndex = 4;
            btnMessage.Text = "MESSAGES";
            btnMessage.UseVisualStyleBackColor = false;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnGov
            // 
            btnGov.BackColor = Color.FromArgb(226, 74, 50);
            btnGov.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGov.ForeColor = Color.White;
            btnGov.Location = new Point(3, 182);
            btnGov.Name = "btnGov";
            btnGov.Size = new Size(136, 100);
            btnGov.TabIndex = 5;
            btnGov.Text = "SCAM ALERT";
            btnGov.UseVisualStyleBackColor = false;
            btnGov.Click += btnGov_Click;
            // 
            // btnTransport
            // 
            btnTransport.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransport.Location = new Point(1129, 203);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(548, 194);
            btnTransport.TabIndex = 6;
            btnTransport.Text = "Transport";
            btnTransport.UseVisualStyleBackColor = false;
            // 
            // btnNextGuide
            // 
            btnNextGuide.BackColor = Color.OliveDrab;
            btnNextGuide.Enabled = false;
            btnNextGuide.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextGuide.ForeColor = Color.Khaki;
            btnNextGuide.Location = new Point(261, 517);
            btnNextGuide.Name = "btnNextGuide";
            btnNextGuide.Size = new Size(154, 37);
            btnNextGuide.TabIndex = 7;
            btnNextGuide.Text = "Next Guide -->";
            btnNextGuide.UseVisualStyleBackColor = false;
            btnNextGuide.Click += btnNextGuide_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OliveDrab;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Khaki;
            btnBack.Location = new Point(49, 519);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 35);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 555F));
            tableLayoutPanel1.Controls.Add(btnEWallet1, 1, 0);
            tableLayoutPanel1.Controls.Add(btnTransport1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnHealth1, 2, 0);
            tableLayoutPanel1.Controls.Add(btnBank, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGov, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMessage, 1, 1);
            tableLayoutPanel1.Location = new Point(-1, 155);
            tableLayoutPanel1.Margin = new Padding(20, 20, 20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(860, 359);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btnEWallet1
            // 
            btnEWallet1.BackColor = Color.FromArgb(57, 166, 163);
            btnEWallet1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEWallet1.ForeColor = Color.White;
            btnEWallet1.Location = new Point(154, 1);
            btnEWallet1.Margin = new Padding(2, 1, 2, 1);
            btnEWallet1.Name = "btnEWallet1";
            btnEWallet1.Size = new Size(139, 102);
            btnEWallet1.TabIndex = 11;
            btnEWallet1.Text = "E-WALLET";
            btnEWallet1.UseVisualStyleBackColor = false;
            btnEWallet1.Click += btnEWallet1_Click;
            // 
            // btnTransport1
            // 
            btnTransport1.BackColor = Color.FromArgb(232, 156, 51);
            btnTransport1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransport1.ForeColor = Color.White;
            btnTransport1.Location = new Point(306, 180);
            btnTransport1.Margin = new Padding(2, 1, 2, 1);
            btnTransport1.Name = "btnTransport1";
            btnTransport1.Size = new Size(128, 103);
            btnTransport1.TabIndex = 12;
            btnTransport1.Text = "TRANSPORT";
            btnTransport1.UseVisualStyleBackColor = false;
            btnTransport1.Click += btnTransport1_Click;
            // 
            // btnHealth1
            // 
            btnHealth1.BackColor = Color.FromArgb(226, 74, 50);
            btnHealth1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHealth1.ForeColor = Color.White;
            btnHealth1.Location = new Point(306, 1);
            btnHealth1.Margin = new Padding(2, 1, 2, 1);
            btnHealth1.Name = "btnHealth1";
            btnHealth1.Size = new Size(128, 102);
            btnHealth1.TabIndex = 13;
            btnHealth1.Text = "HEALTHCARE";
            btnHealth1.UseVisualStyleBackColor = false;
            btnHealth1.Click += btnHealth1_Click;
            // 
            // btnVoiceAssist
            // 
            btnVoiceAssist.BackColor = Color.FromArgb(127, 166, 122);
            btnVoiceAssist.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceAssist.ForeColor = Color.White;
            btnVoiceAssist.Location = new Point(270, 101);
            btnVoiceAssist.Name = "btnVoiceAssist";
            btnVoiceAssist.Size = new Size(163, 31);
            btnVoiceAssist.TabIndex = 10;
            btnVoiceAssist.Text = "VOICE ASSISTANT";
            btnVoiceAssist.UseVisualStyleBackColor = false;
            btnVoiceAssist.Click += btnVoiceAssist_Click_2;
            // 
            // FrmGuideCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(457, 633);
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
        private Button btnEWallet1;
        private Button btnTransport1;
        private Button btnHealth1;
    }
}