namespace OMC_Group16.Forms
{
    partial class FrmBookAppointment
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
            lblClinic = new Label();
            label1 = new Label();
            label2 = new Label();
            cboService = new ComboBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            cboTime = new ComboBox();
            btnProceed = new Button();
            label4 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            txtPrice = new TextBox();
            lblCaregiverName = new Label();
            cmbElderly = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblClinic
            // 
            lblClinic.AutoSize = true;
            lblClinic.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinic.ForeColor = Color.Lime;
            lblClinic.Location = new Point(110, 94);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(77, 20);
            lblClinic.TabIndex = 0;
            lblClinic.Text = "QUALITAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 94);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "CLINIC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 177);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "SERVICE:";
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Items.AddRange(new object[] { "General Check-up", "Blood Pressure Check", "Diabetes Consultation" });
            cboService.Location = new Point(110, 175);
            cboService.Name = "cboService";
            cboService.Size = new Size(121, 23);
            cboService.TabIndex = 3;
            cboService.SelectedIndexChanged += cboService_SelectedIndexChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(41, 220);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "DATE:";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(110, 220);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(41, 278);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "TIME:";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(119, 276);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(121, 23);
            cboTime.TabIndex = 7;
            // 
            // btnProceed
            // 
            btnProceed.BackColor = Color.FromArgb(128, 255, 128);
            btnProceed.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProceed.Location = new Point(202, 423);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(138, 36);
            btnProceed.TabIndex = 9;
            btnProceed.Text = "PROCEED";
            btnProceed.UseVisualStyleBackColor = false;
            btnProceed.Click += btnProceed_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 323);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 10;
            label4.Text = "PRICE:";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(255, 128, 128);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(59, 423);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 36);
            btnBack.TabIndex = 11;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(lblCaregiverName);
            panel1.Controls.Add(cmbElderly);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnProceed);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblClinic);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboService);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboTime);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(dtpDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 624);
            panel1.TabIndex = 12;
            panel1.Paint += panel1_Paint;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(116, 328);
            txtPrice.Margin = new Padding(3, 2, 3, 2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(110, 23);
            txtPrice.TabIndex = 18;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // lblCaregiverName
            // 
            lblCaregiverName.AutoSize = true;
            lblCaregiverName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaregiverName.ForeColor = Color.White;
            lblCaregiverName.Location = new Point(122, 119);
            lblCaregiverName.Name = "lblCaregiverName";
            lblCaregiverName.Size = new Size(0, 20);
            lblCaregiverName.TabIndex = 17;
            // 
            // cmbElderly
            // 
            cmbElderly.FormattingEnabled = true;
            cmbElderly.Location = new Point(108, 146);
            cmbElderly.Margin = new Padding(3, 2, 3, 2);
            cmbElderly.Name = "cmbElderly";
            cmbElderly.Size = new Size(124, 23);
            cmbElderly.TabIndex = 16;
            cmbElderly.SelectedIndexChanged += cmbElderly_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(26, 146);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 15;
            label7.Text = "ELDERLY:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(22, 119);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 13;
            label6.Text = "CAREGIVER:";
            // 
            // label5
            // 
            label5.BackColor = Color.DarkOliveGreen;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkKhaki;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(441, 68);
            label5.TabIndex = 12;
            label5.Text = "BOOK APPOINTMENT";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmBookAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 624);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookAppointment";
            Text = "FrmBookAppointment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblClinic;
        private Label label1;
        private Label label2;
        private ComboBox cboService;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label label3;
        private ComboBox cboTime;
        private Button btnProceed;
        private Label label4;
        private Button btnBack;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private ComboBox cmbElderly;
        private Label label7;
        private Label lblCaregiverName;
        private TextBox txtPrice;
    }
}