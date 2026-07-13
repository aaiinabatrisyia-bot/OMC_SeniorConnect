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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(624, 86);
            label1.Name = "label1";
            label1.Size = new Size(426, 108);
            label1.TabIndex = 0;
            label1.Text = "Guide Categories";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBank
            // 
            btnBank.Location = new Point(3, 3);
            btnBank.Name = "btnBank";
            btnBank.Size = new Size(557, 194);
            btnBank.TabIndex = 1;
            btnBank.Text = "Online Banking";
            btnBank.UseVisualStyleBackColor = true;
          //  btnBank.Click += btnBank_Click;
            // 
            // btnHealth
            // 
            btnHealth.Location = new Point(566, 3);
            btnHealth.Name = "btnHealth";
            btnHealth.Size = new Size(557, 194);
            btnHealth.TabIndex = 2;
            btnHealth.Text = "Healthcare";
            btnHealth.UseVisualStyleBackColor = true;
            // 
            // btnEWallet
            // 
            btnEWallet.Location = new Point(1129, 3);
            btnEWallet.Name = "btnEWallet";
            btnEWallet.Size = new Size(548, 194);
            btnEWallet.TabIndex = 3;
            btnEWallet.Text = "E-Wallet";
            btnEWallet.UseVisualStyleBackColor = true;
            // 
            // btnMessage
            // 
            btnMessage.Location = new Point(566, 203);
            btnMessage.Name = "btnMessage";
            btnMessage.Size = new Size(557, 194);
            btnMessage.TabIndex = 4;
            btnMessage.Text = "Messages";
            btnMessage.UseVisualStyleBackColor = true;
            // 
            // btnGov
            // 
            btnGov.Location = new Point(3, 203);
            btnGov.Name = "btnGov";
            btnGov.Size = new Size(557, 194);
            btnGov.TabIndex = 5;
            btnGov.Text = "Government Service";
            btnGov.UseVisualStyleBackColor = true;
            // 
            // btnTransport
            // 
            btnTransport.Location = new Point(1129, 203);
            btnTransport.Name = "btnTransport";
            btnTransport.Size = new Size(548, 194);
            btnTransport.TabIndex = 6;
            btnTransport.Text = "Transport";
            btnTransport.UseVisualStyleBackColor = true;
            // 
            // btnNextGuide
            // 
            btnNextGuide.Enabled = false;
            btnNextGuide.Location = new Point(1419, 839);
            btnNextGuide.Name = "btnNextGuide";
            btnNextGuide.Size = new Size(205, 46);
            btnNextGuide.TabIndex = 7;
            btnNextGuide.Text = "Next Guide -->";
            btnNextGuide.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(62, 839);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 46);
            btnBack.TabIndex = 8;
            btnBack.Text = "<-- Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 554F));
            tableLayoutPanel1.Controls.Add(btnBank, 0, 0);
            tableLayoutPanel1.Controls.Add(btnHealth, 1, 0);
            tableLayoutPanel1.Controls.Add(btnEWallet, 2, 0);
            tableLayoutPanel1.Controls.Add(btnTransport, 2, 1);
            tableLayoutPanel1.Controls.Add(btnGov, 0, 1);
            tableLayoutPanel1.Controls.Add(btnMessage, 1, 1);
            tableLayoutPanel1.Location = new Point(-4, 305);
            tableLayoutPanel1.Margin = new Padding(20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1680, 400);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // FrmGuideCategories
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 1011);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnBack);
            Controls.Add(btnNextGuide);
            Controls.Add(label1);
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
    }
}