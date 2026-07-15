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
            rbCard = new RadioButton();
            rbBank = new RadioButton();
            panel1 = new Panel();
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
            panel1.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlBank.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 6);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 1;
            label2.Text = "Appointment Summary";
            // 
            // lblClinicTitle
            // 
            lblClinicTitle.AutoSize = true;
            lblClinicTitle.Location = new Point(12, 65);
            lblClinicTitle.Name = "lblClinicTitle";
            lblClinicTitle.Size = new Size(43, 15);
            lblClinicTitle.TabIndex = 2;
            lblClinicTitle.Text = "Clinic :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 65);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Qualitas";
            // 
            // lblServiceTitle
            // 
            lblServiceTitle.AutoSize = true;
            lblServiceTitle.Location = new Point(12, 94);
            lblServiceTitle.Name = "lblServiceTitle";
            lblServiceTitle.Size = new Size(50, 15);
            lblServiceTitle.TabIndex = 4;
            lblServiceTitle.Text = "Service :";
            // 
            // lblDateTitle
            // 
            lblDateTitle.AutoSize = true;
            lblDateTitle.Location = new Point(12, 124);
            lblDateTitle.Name = "lblDateTitle";
            lblDateTitle.Size = new Size(37, 15);
            lblDateTitle.TabIndex = 5;
            lblDateTitle.Text = "Date :";
            // 
            // lblTimeTitle
            // 
            lblTimeTitle.AutoSize = true;
            lblTimeTitle.Location = new Point(12, 157);
            lblTimeTitle.Name = "lblTimeTitle";
            lblTimeTitle.Size = new Size(40, 15);
            lblTimeTitle.TabIndex = 6;
            lblTimeTitle.Text = "Time :";
            // 
            // lblService
            // 
            lblService.Location = new Point(81, 94);
            lblService.Name = "lblService";
            lblService.Size = new Size(76, 15);
            lblService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(81, 124);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(76, 15);
            lblDate.TabIndex = 8;
            // 
            // lblTime
            // 
            lblTime.Location = new Point(81, 157);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(76, 15);
            lblTime.TabIndex = 9;
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(81, 194);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(76, 15);
            lblAmount.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Amount :";
            // 
            // grpPaymentMethod
            // 
            grpPaymentMethod.Controls.Add(rbCard);
            grpPaymentMethod.Controls.Add(rbBank);
            grpPaymentMethod.Location = new Point(12, 224);
            grpPaymentMethod.Name = "grpPaymentMethod";
            grpPaymentMethod.Size = new Size(402, 77);
            grpPaymentMethod.TabIndex = 12;
            grpPaymentMethod.TabStop = false;
            grpPaymentMethod.Text = "Payment Method";
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Location = new Point(214, 38);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(152, 19);
            rbCard.TabIndex = 1;
            rbCard.TabStop = true;
            rbCard.Text = "Credit Card / Debit Card";
            rbCard.UseVisualStyleBackColor = true;
            rbCard.CheckedChanged += rbCard_CheckedChanged;
            // 
            // rbBank
            // 
            rbBank.AutoSize = true;
            rbBank.Location = new Point(39, 38);
            rbBank.Name = "rbBank";
            rbBank.Size = new Size(106, 19);
            rbBank.TabIndex = 0;
            rbBank.TabStop = true;
            rbBank.Text = "Online Banking";
            rbBank.UseVisualStyleBackColor = true;
            rbBank.CheckedChanged += rbBank_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(pnlCard);
            panel1.Controls.Add(pnlBank);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 624);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(229, 520);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(139, 520);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
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
            pnlCard.Location = new Point(226, 307);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(200, 189);
            pnlCard.TabIndex = 1;
            pnlCard.Visible = false;
            // 
            // txtCVV
            // 
            txtCVV.Location = new Point(88, 98);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(100, 23);
            txtCVV.TabIndex = 10;
            txtCVV.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 98);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 9;
            label10.Text = "CVV :";
            // 
            // txtExpiry
            // 
            txtExpiry.Location = new Point(88, 58);
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(100, 23);
            txtExpiry.TabIndex = 8;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Location = new Point(88, 18);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(100, 23);
            txtCardNumber.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 63);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 7;
            label9.Text = "Expiry Date :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 21);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 6;
            label8.Text = "Card Number :";
            // 
            // pnlBank
            // 
            pnlBank.Controls.Add(txtPassword);
            pnlBank.Controls.Add(txtUsername);
            pnlBank.Controls.Add(label7);
            pnlBank.Controls.Add(label6);
            pnlBank.Controls.Add(cboBank);
            pnlBank.Controls.Add(label5);
            pnlBank.Location = new Point(14, 307);
            pnlBank.Name = "pnlBank";
            pnlBank.Size = new Size(200, 189);
            pnlBank.TabIndex = 0;
            pnlBank.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(81, 90);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(81, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 90);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 3;
            label7.Text = "Password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 58);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 2;
            label6.Text = "Username :";
            // 
            // cboBank
            // 
            cboBank.FormattingEnabled = true;
            cboBank.Items.AddRange(new object[] { "Maybank", "", "CIMB", "", "Public Bank", "", "RHB", "", "Bank Islam" });
            cboBank.Location = new Point(55, 18);
            cboBank.Name = "cboBank";
            cboBank.Size = new Size(121, 23);
            cboBank.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 21);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Bank :";
            // 
            // FrmPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 624);
            Controls.Add(grpPaymentMethod);
            Controls.Add(label4);
            Controls.Add(lblAmount);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblService);
            Controls.Add(lblTimeTitle);
            Controls.Add(lblDateTitle);
            Controls.Add(lblServiceTitle);
            Controls.Add(label3);
            Controls.Add(lblClinicTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPayment";
            Text = "FrmPayment";
            Load += FrmPayment_Load;
            grpPaymentMethod.ResumeLayout(false);
            grpPaymentMethod.PerformLayout();
            panel1.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlBank.ResumeLayout(false);
            pnlBank.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}