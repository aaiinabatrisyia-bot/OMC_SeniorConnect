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
            label1.Font = new Font("Calibri", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 62);
            label1.TabIndex = 0;
            label1.Text = "Guide Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btnBank
            // 
            btnBank.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBank.Location = new Point(2, 2);
            btnBank.Margin = new Padding(2);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(299, 90);
            btnBank.TabIndex = 1;
            btnBank.Text = "Online Banking";
            btnBank.UseVisualStyleBackColor = true;
            btnBank.Click += btnBank_Click;
            // 
            // btnHealth
            // 
            btnHealth.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHealth.Location = new Point(305, 2);
            btnHealth.Margin = new Padding(2);
            btnHealth.Name = "btnHealth";
            btnHealth.Size = new Size(299, 90);
            btnHealth.TabIndex = 2;
            btnHealth.Text = "Healthcare";
            btnHealth.UseVisualStyleBackColor = true;
            // 
            // btnEWallet
            // 
            btnEWallet.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEWallet.Location = new Point(608, 2);
            btnEWallet.Margin = new Padding(2);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(295, 90);
            btnEWallet.TabIndex = 3;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            btnMessage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMessage.Location = new Point(305, 96);
            btnMessage.Margin = new Padding(2);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(299, 90);
            btnMessage.TabIndex = 4;
            btnMessage.Text = "Messages";
            btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnGov
            // 
            btnGov.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGov.Location = new Point(2, 96);
            btnGov.Margin = new Padding(2);
            btnGov.Name = "btnGov";
            btnGov.Size = new Size(299, 90);
            btnGov.TabIndex = 5;
            btnGov.Text = "Government Service";
            btnGov.UseVisualStyleBackColor = true;
            // 
            // btnTransport
            // 
            btnTransport.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransport.Location = new Point(608, 96);
            btnTransport.Margin = new Padding(2);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(295, 90);
            btnTransport.TabIndex = 6;
            btnTransport.Text = "Transport";
            btnTransport.UseVisualStyleBackColor = true;
            // 
            // btnNextGuide
            // 
            btnNextGuide.Enabled = false;
            btnNextGuide.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNextGuide.Location = new Point(764, 393);
            btnNextGuide.Margin = new Padding(2);
            btnNextGuide.Name = "btnNextGuide";
            btnNextGuide.Size = new Size(110, 29);
            btnNextGuide.TabIndex = 7;
            btnNextGuide.Text = "Next Guide -->";
            btnNextGuide.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Calibri", 10.125F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(33, 393);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 8;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 299F));
            tableLayoutPanel1.Controls.Add(btnBank, 0, 0);
            tableLayoutPanel1.Controls.Add(btnHealth, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEWallet, 2, 0);
            tableLayoutPanel1.Controls.Add(btnTransport, 2, 1);
            tableLayoutPanel1.Controls.Add(btnGov, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMessage, 1, 1);
            tableLayoutPanel1.Location = new Point(-2, 143);
            tableLayoutPanel1.Margin = new Padding(10, 9, 10, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(905, 188);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // btnVoiceAssist
            // 
            btnVoiceAssist.BackColor = SystemColors.Highlight;
            btnVoiceAssist.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVoiceAssist.ForeColor = SystemColors.ControlLightLight;
            btnVoiceAssist.Location = new Point(21, 19);
            btnVoiceAssist.Margin = new Padding(2);
            btnVoiceAssist.Name = "btnVoiceAssist";
            btnVoiceAssist.Size = new Size(194, 47);
            btnVoiceAssist.TabIndex = 10;
            btnVoiceAssist.Text = "🔊 Turn Voice ON";
            btnVoiceAssist.UseVisualStyleBackColor = false;
            // 
            // FrmGuideCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 474);
            Controls.Add(btnVoiceAssist);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(btnNextGuide);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FrmGuideCategories";
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