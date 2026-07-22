namespace OMC_Group16.Forms
{
    partial class FrmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayment));
            label1 = new Label();
            label2 = new Label();
            lblClinicTitle = new Label();
            label3 = new Label();
            lblServiceTitle = new Label();
            lblDateTitle = new Label();
            lblTimeTitle = new Label();
            lblService = new Label();
            lblDate = new Label();
            lblTime = new Label();
            lblAmount = new Label();
            label4 = new Label();
            grpPaymentMethod = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rbCard = new RadioButton();
            rbBank = new RadioButton();
            panel1 = new Panel();
            label11 = new Label();
            btnPay = new Button();
            btnCancel = new Button();
            pnlCard = new Panel();
            txtCVV = new TextBox();
            label10 = new Label();
            txtExpiry = new TextBox();
            txtCardNumber = new TextBox();
            label9 = new Label();
            label8 = new Label();
            pnlBank = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            label6 = new Label();
            cboBank = new ComboBox();
            label5 = new Label();
            grpPaymentMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlBank.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 47);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.MidnightBlue;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(306, 40);
            label2.TabIndex = 1;
            label2.Text = "APPOINTMENT SUMMARY\r\n";
            // 
            // lblClinicTitle
            // 
            lblClinicTitle.AutoSize = true;
            lblClinicTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicTitle.ForeColor = Color.White;
            lblClinicTitle.Location = new Point(18, 149);
            lblClinicTitle.Name = "lblClinicTitle";
            lblClinicTitle.Size = new Size(71, 25);
            lblClinicTitle.TabIndex = 2;
            lblClinicTitle.Text = "CLINIC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(117, 147);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 3;
            label3.Text = "QUALITAS";
            // 
            // lblServiceTitle
            // 
            lblServiceTitle.AutoSize = true;
            lblServiceTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblServiceTitle.ForeColor = Color.White;
            lblServiceTitle.Location = new Point(19, 192);
            lblServiceTitle.Name = "lblServiceTitle";
            lblServiceTitle.Size = new Size(83, 25);
            lblServiceTitle.TabIndex = 4;
            lblServiceTitle.Text = "SERVICE:";
            // 
            // lblDateTitle
            // 
            lblDateTitle.AutoSize = true;
            lblDateTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTitle.ForeColor = Color.White;
            lblDateTitle.Location = new Point(19, 231);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(59, 25);
            lblDateTitle.TabIndex = 5;
            lblDateTitle.Text = "DATE:";
            // 
            // lblTimeTitle
            // 
            lblTimeTitle.AutoSize = true;
            lblTimeTitle.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimeTitle.ForeColor = Color.White;
            lblTimeTitle.Location = new Point(18, 268);
            lblTimeTitle.Name = "lblTimeTitle";
            lblTimeTitle.Size = new Size(57, 25);
            lblTimeTitle.TabIndex = 6;
            lblTimeTitle.Text = "TIME:";
            // 
            // lblService
            // 
            lblService.BackColor = Color.White;
            lblService.Location = new Point(120, 192);
            lblService.Name = "lblService";
            lblService.Size = new Size(143, 20);
            lblService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.White;
            lblDate.Location = new Point(120, 231);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(143, 20);
            lblDate.TabIndex = 8;
            // 
            // lblTime
            // 
            lblTime.BackColor = Color.White;
            lblTime.Location = new Point(120, 268);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(143, 20);
            lblTime.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.BackColor = Color.White;
            lblAmount.Location = new Point(120, 309);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(143, 20);
            lblAmount.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 304);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 11;
            label4.Text = "AMOUNT:";
            // 
            // grpPaymentMethod
            // 
            grpPaymentMethod.Controls.Add(pictureBox2);
            grpPaymentMethod.Controls.Add(pictureBox1);
            grpPaymentMethod.Controls.Add(rbCard);
            grpPaymentMethod.Controls.Add(rbBank);
            grpPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpPaymentMethod.ForeColor = Color.White;
            grpPaymentMethod.Location = new Point(16, 341);
            grpPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            grpPaymentMethod.Name = "grpPaymentMethod";
            grpPaymentMethod.Padding = new Padding(3, 4, 3, 4);
            grpPaymentMethod.Size = new Size(459, 103);
            grpPaymentMethod.TabIndex = 12;
            grpPaymentMethod.TabStop = false;
            grpPaymentMethod.Text = "PAYMENT METHOD";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(258, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Location = new Point(202, 67);
            rbCard.Margin = new Padding(3, 4, 3, 4);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(230, 27);
            rbCard.TabIndex = 1;
            rbCard.TabStop = true;
            rbCard.Text = "Credit Card / Debit Card";
            rbCard.UseVisualStyleBackColor = true;
            rbCard.CheckedChanged += rbCard_CheckedChanged;
            // 
            // rbBank
            // 
            rbBank.AutoSize = true;
            rbBank.Location = new Point(27, 67);
            rbBank.Margin = new Padding(3, 4, 3, 4);
            rbBank.Name = "rbBank";
            rbBank.Size = new Size(154, 27);
            rbBank.TabIndex = 0;
            rbBank.TabStop = true;
            rbBank.Text = "Online Banking";
            rbBank.UseVisualStyleBackColor = true;
            rbBank.CheckedChanged += rbBank_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(grpPaymentMethod);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(lblService);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(lblAmount);
            panel1.Controls.Add(pnlCard);
            panel1.Controls.Add(pnlBank);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblClinicTitle);
            panel1.Controls.Add(lblTimeTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblDateTitle);
            panel1.Controls.Add(lblServiceTitle);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 832);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label11
            // 
            label11.BackColor = Color.DarkOliveGreen;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.DarkKhaki;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(504, 91);
            label11.TabIndex = 13;
            label11.Text = "PAYMENT";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(128, 255, 128);
            btnPay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(272, 713);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(115, 55);
            btnPay.TabIndex = 3;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(109, 713);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 55);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlCard
            // 
            pnlCard.Controls.Add(txtCVV);
            pnlCard.Controls.Add(label10);
            pnlCard.Controls.Add(txtExpiry);
            pnlCard.Controls.Add(txtCardNumber);
            pnlCard.Controls.Add(label9);
            pnlCard.Controls.Add(label8);
            pnlCard.Location = new Point(251, 453);
            pnlCard.Margin = new Padding(3, 4, 3, 4);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(229, 252);
            pnlCard.TabIndex = 1;
            pnlCard.Visible = false;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(101, 131);
            txtCVV.Margin = new Padding(3, 4, 3, 4);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(114, 27);
            txtCVV.TabIndex = 10;
            txtCVV.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 131);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 9;
            label10.Text = "CVV :";
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(101, 77);
            txtExpiry.Margin = new Padding(3, 4, 3, 4);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(114, 27);
            txtExpiry.TabIndex = 8;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(101, 24);
            txtCardNumber.Margin = new Padding(3, 4, 3, 4);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(114, 27);
            txtCardNumber.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 84);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 7;
            label9.Text = "EXPIRY DATE:";
            // 
            // label8
            // 
            label8.Enabled = false;
            label8.ForeColor = Color.White;
            label8.Location = new Point(5, 24);
            label8.Name = "label8";
            label8.Size = new Size(111, 45);
            label8.TabIndex = 6;
            label8.Text = "CARD NUMBER:";
            // 
            // pnlBank
            // 
            pnlBank.Controls.Add(txtPassword);
            pnlBank.Controls.Add(txtUsername);
            pnlBank.Controls.Add(label7);
            pnlBank.Controls.Add(label6);
            pnlBank.Controls.Add(cboBank);
            pnlBank.Controls.Add(label5);
            pnlBank.Location = new Point(16, 453);
            pnlBank.Margin = new Padding(3, 4, 3, 4);
            pnlBank.Name = "pnlBank";
            pnlBank.Size = new Size(229, 252);
            pnlBank.TabIndex = 0;
            pnlBank.Visible = false;
            pnlBank.Paint += pnlBank_Paint;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 120);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 27);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(93, 73);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(114, 27);
            txtUsername.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 123);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 3;
            label7.Text = "PASSWORD:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 77);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 2;
            label6.Text = "USERNAME:";
            // 
            // cboBank
            // 
            cboBank.FormattingEnabled = true;
            cboBank.Items.AddRange(new object[] { "Maybank", "", "CIMB", "", "Public Bank", "", "RHB", "", "Bank Islam" });
            cboBank.Location = new Point(69, 24);
            cboBank.Margin = new Padding(3, 4, 3, 4);
            cboBank.Name = "cboBank";
            cboBank.Size = new Size(138, 28);
            cboBank.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 28);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 0;
            label5.Text = "BANK:";
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 832);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            grpPaymentMethod.ResumeLayout(false);
            grpPaymentMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlBank.ResumeLayout(false);
            pnlBank.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblClinicTitle;
        private Label label3;
        private Label lblServiceTitle;
        private Label lblDateTitle;
        private Label lblTimeTitle;
        private Label lblService;
        private Label lblDate;
        private Label lblTime;
        private Label lblAmount;
        private Label label4;
        private GroupBox grpPaymentMethod;
        private RadioButton rbCard;
        private RadioButton rbBank;
        private Panel panel1;
        private Panel pnlCard;
        private Panel pnlBank;
        private Label label5;
        private TextBox txtCardNumber;
        private Label label9;
        private Label label8;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
        private Label label6;
        private ComboBox cboBank;
        private Button btnPay;
        private Button btnCancel;
        private TextBox txtCVV;
        private Label label10;
        private TextBox txtExpiry;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label11;
    }
}