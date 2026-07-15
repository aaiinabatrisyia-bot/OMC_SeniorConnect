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
            label1.Location = new Point(-1, -1);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(895, 282);
            label1.TabIndex = 0;
            label1.Text = "Guide Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBank
            // 
            btnBank.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBank.Location = new Point(6, 6);
            btnBank.Margin = new Padding(6);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(281, 273);
            btnBank.TabIndex = 1;
            btnBank.Text = "Online Banking";
            btnBank.UseVisualStyleBackColor = true;
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
            btnHealth.Click += btnHealth_Click;
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
            btnEWallet.Click += btnEWallet_Click_1;
            // 
            // btnMessage
            // 
            btnMessage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMessage.Location = new Point(299, 291);
            btnMessage.Margin = new Padding(6);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(281, 273);
            btnMessage.TabIndex = 4;
            btnMessage.Text = "Messages";
            btnMessage.UseVisualStyleBackColor = false;
            btnMessage.Click += btnMessage_Click;
            // 
            // btnGov
            // 
            btnGov.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGov.Location = new Point(6, 291);
            btnGov.Margin = new Padding(6);
            btnGov.Name = "btnGov";
            btnGov.Size = new Size(281, 273);
            btnGov.TabIndex = 5;
            btnGov.Text = "Scam Alert";
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
            btnTransport.Click += btnTransport_Click_1;
            // 
            // btnNextGuide
            // 
            btnNextGuide.BackColor = Color.OliveDrab;
            btnNextGuide.Enabled = false;
            btnNextGuide.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNextGuide.Location = new Point(690, 1248);
            btnNextGuide.Margin = new Padding(6);
            btnNextGuide.Name = "btnNextGuide";
            btnNextGuide.Size = new Size(204, 62);
            btnNextGuide.TabIndex = 7;
            btnNextGuide.Text = "Next Guide -->";
            btnNextGuide.UseVisualStyleBackColor = false;
            btnNextGuide.Click += btnNextGuide_Click_1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.OliveDrab;
            btnBack.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(34, 1248);
            btnBack.Margin = new Padding(6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 62);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1029F));
            tableLayoutPanel1.Controls.Add(btnBank, 0, 0);
            tableLayoutPanel1.Controls.Add(btnGov, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMessage, 1, 1);
            tableLayoutPanel1.Location = new Point(-7, 542);
            tableLayoutPanel1.Margin = new Padding(37, 43, 37, 43);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1615, 570);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btnVoiceAssist
            // 
            btnVoiceAssist.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceAssist.Location = new Point(15, 15);
            btnVoiceAssist.Margin = new Padding(6);
            btnVoiceAssist.Name = "btnVoiceAssist";
            btnVoiceAssist.Size = new Size(194, 108);
            btnVoiceAssist.TabIndex = 10;
            btnVoiceAssist.Text = "🔊 Turn Voice ON";
            btnVoiceAssist.UseVisualStyleBackColor = true;
           
            // 
            // FrmGuideCategories
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 1805);
            Controls.Add(btnVoiceAssist);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(btnNextGuide);
            Controls.Add(label1);
            Margin = new Padding(6);
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