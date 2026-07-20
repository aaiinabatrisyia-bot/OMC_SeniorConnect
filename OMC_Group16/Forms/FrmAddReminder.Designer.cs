namespace OMC_Group16
{
    partial class FrmAddReminder
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
            txtTitle = new TextBox();
            label2 = new Label();
            dtpReminderDate = new DateTimePicker();
            label3 = new Label();
            txtReminderDescription = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            label4 = new Label();
            label5 = new Label();
            cboPatient = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "TITLE:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(105, 113);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(312, 38);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(26, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 2;
            label2.Text = "DATE:";
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Location = new Point(105, 172);
            dtpReminderDate.Margin = new Padding(4, 3, 4, 3);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(312, 30);
            dtpReminderDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 289);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPTION:";
            // 
            // txtReminderDescription
            // 
            txtReminderDescription.Location = new Point(61, 337);
            txtReminderDescription.Margin = new Padding(4, 3, 4, 3);
            txtReminderDescription.Multiline = true;
            txtReminderDescription.Name = "txtReminderDescription";
            txtReminderDescription.Size = new Size(314, 130);
            txtReminderDescription.TabIndex = 5;
            txtReminderDescription.TextChanged += txtReminderDescription_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(27, 492);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += button1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(262, 492);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(139, 33);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnCancel_Click_1;
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOliveGreen;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkKhaki;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(439, 61);
            label4.TabIndex = 9;
            label4.Text = "ADD REMINDER";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(28, 237);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 10;
            label5.Text = "SENIORS:";
            // 
            // cboPatient
            // 
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(121, 237);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(151, 31);
            cboPatient.TabIndex = 11;
            // 
            // FrmAddReminder
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(439, 616);
            Controls.Add(cboPatient);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtReminderDescription);
            Controls.Add(label3);
            Controls.Add(dtpReminderDate);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.MidnightBlue;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmAddReminder";
            Text = "FrmAddReminder";
            Load += FrmAddReminder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private DateTimePicker dtpReminderDate;
        private Label label3;
        private TextBox txtReminderDescription;
        private Button btnSave;
        private Button btnBack;
        private Label label4;
        private Label label5;
        private ComboBox cboPatient;
    }
}