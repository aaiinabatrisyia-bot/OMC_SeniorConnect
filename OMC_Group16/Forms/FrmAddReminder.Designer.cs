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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 65);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(201, 51);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 34);
            txtTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 121);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Location = new Point(201, 114);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(250, 27);
            dtpReminderDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 177);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "Description:";
            // 
            // txtReminderDescription
            // 
            txtReminderDescription.Location = new Point(201, 174);
            txtReminderDescription.Multiline = true;
            txtReminderDescription.Name = "txtReminderDescription";
            txtReminderDescription.Size = new Size(250, 101);
            txtReminderDescription.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(181, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 317);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmAddReminder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtReminderDescription);
            Controls.Add(label3);
            Controls.Add(dtpReminderDate);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
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
        private Button button1;
        private Button button2;
    }
}