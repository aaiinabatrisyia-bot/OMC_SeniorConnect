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
            btnCancel = new Button();
            btnVoiceAssistant = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(28, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "TITLE:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(106, 70);
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
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(27, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 2;
            label2.Text = "DATE:";
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Location = new Point(106, 129);
            dtpReminderDate.Margin = new Padding(4, 3, 4, 3);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(312, 30);
            dtpReminderDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(27, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 4;
            label3.Text = "DESCRIPTION:";
            // 
            // txtReminderDescription
            // 
            txtReminderDescription.Location = new Point(67, 214);
            txtReminderDescription.Margin = new Padding(4, 3, 4, 3);
            txtReminderDescription.Multiline = true;
            txtReminderDescription.Name = "txtReminderDescription";
            txtReminderDescription.Size = new Size(314, 130);
            txtReminderDescription.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(27, 382);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 33);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(254, 382);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 33);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnVoiceAssistant
            // 
            btnVoiceAssistant.Location = new Point(106, 450);
            btnVoiceAssistant.Margin = new Padding(4, 3, 4, 3);
            btnVoiceAssistant.Name = "btnVoiceAssistant";
            btnVoiceAssistant.Size = new Size(220, 33);
            btnVoiceAssistant.TabIndex = 8;
            btnVoiceAssistant.Text = "VOICE ASSISTANT";
            btnVoiceAssistant.UseVisualStyleBackColor = true;
            // 
            // FrmAddReminder
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(439, 616);
            Controls.Add(btnVoiceAssistant);
            Controls.Add(btnCancel);
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
        private Button btnCancel;
        private Button btnVoiceAssistant;
    }
}