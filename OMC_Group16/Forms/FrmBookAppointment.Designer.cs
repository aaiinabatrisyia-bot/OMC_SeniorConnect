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
            lblPrice = new Label();
            btnProceed = new Button();
            label4 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblClinic
            // 
            lblClinic.AutoSize = true;
            lblClinic.Location = new Point(50, 81);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(50, 15);
            lblClinic.TabIndex = 0;
            lblClinic.Text = "Qualitas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Clinic";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 149);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Service :";
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Items.AddRange(new object[] { "General Check-up", "Blood Pressure Check", "Diabetes Consultation" });
            cboService.Location = new Point(118, 146);
            cboService.Name = "cboService";
            cboService.Size = new Size(121, 23);
            cboService.TabIndex = 3;
            cboService.SelectedIndexChanged += cboService_SelectedIndexChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(50, 218);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(37, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date :";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(119, 220);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 300);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Time :";
            // 
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Location = new Point(96, 297);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(121, 23);
            cboTime.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.LightCoral;
            lblPrice.Location = new Point(119, 346);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(152, 40);
            lblPrice.TabIndex = 8;
            // 
            // btnProceed
            // 
            btnProceed.Location = new Point(183, 470);
            btnProceed.Name = "btnProceed";
            btnProceed.Size = new Size(75, 23);
            btnProceed.TabIndex = 9;
            btnProceed.Text = "Proceed";
            btnProceed.UseVisualStyleBackColor = true;
            btnProceed.Click += btnProceed_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 359);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 10;
            label4.Text = "Price :";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(91, 470);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 624);
            panel1.TabIndex = 12;
            // 
            // FrmBookAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 624);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(btnProceed);
            Controls.Add(lblPrice);
            Controls.Add(cboTime);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(cboService);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblClinic);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBookAppointment";
            Text = "FrmBookAppointment";
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblPrice;
        private Button btnProceed;
        private Label label4;
        private Button btnBack;
        private Panel panel1;
    }
}