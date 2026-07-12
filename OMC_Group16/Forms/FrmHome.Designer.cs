namespace OMC_Group16
{
    partial class FrmHome
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
            pnlGuide = new Panel();
            lblGuide = new Label();
            picGuide = new PictureBox();
            pnlReminder = new Panel();
            lblReminder = new Label();
            picReminder = new PictureBox();
            pnlEmergency = new Panel();
            lblEmergency = new Label();
            picEmergency = new PictureBox();
            pnlVoice = new Panel();
            lblVoice = new Label();
            picVoice = new PictureBox();
            btnExit = new Button();
            pnlGuide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).BeginInit();
            pnlReminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picReminder).BeginInit();
            pnlEmergency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEmergency).BeginInit();
            pnlVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVoice).BeginInit();
            SuspendLayout();
            // 
            // pnlGuide
            // 
            pnlGuide.BackColor = Color.WhiteSmoke;
            pnlGuide.BorderStyle = BorderStyle.FixedSingle;
            pnlGuide.Controls.Add(lblGuide);
            pnlGuide.Controls.Add(picGuide);
            pnlGuide.Location = new Point(154, 105);
            pnlGuide.Margin = new Padding(3, 4, 3, 4);
            pnlGuide.Name = "pnlGuide";
            pnlGuide.Size = new Size(251, 226);
            pnlGuide.TabIndex = 0;
            pnlGuide.Click += pnlGuide_Click;
            pnlGuide.Paint += pnlGuide_Paint;
            pnlGuide.MouseEnter += pnlGuide_MouseEnter;
            pnlGuide.MouseLeave += pnlGuide_MouseLeave;
            // 
            // lblGuide
            // 
            lblGuide.AutoSize = true;
            lblGuide.Location = new Point(59, 175);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(140, 20);
            lblGuide.TabIndex = 1;
            lblGuide.Text = "Step-by-Step Guide";
            // 
            // picGuide
            // 
            picGuide.Image = Properties.Resources.icons8_book_96;
            picGuide.Location = new Point(64, 20);
            picGuide.Margin = new Padding(3, 4, 3, 4);
            picGuide.Name = "picGuide";
            picGuide.Size = new Size(114, 133);
            picGuide.TabIndex = 0;
            picGuide.TabStop = false;
            picGuide.Click += pnlGuide_Click;
            // 
            // pnlReminder
            // 
            pnlReminder.BackColor = Color.WhiteSmoke;
            pnlReminder.BorderStyle = BorderStyle.FixedSingle;
            pnlReminder.Controls.Add(lblReminder);
            pnlReminder.Controls.Add(picReminder);
            pnlReminder.Location = new Point(665, 105);
            pnlReminder.Margin = new Padding(3, 4, 3, 4);
            pnlReminder.Name = "pnlReminder";
            pnlReminder.Size = new Size(251, 226);
            pnlReminder.TabIndex = 1;
            pnlReminder.Click += pnlReminder_Click;
            pnlReminder.MouseEnter += pnlReminder_MouseEnter;
            pnlReminder.MouseLeave += pnlReminder_MouseLeave;
            // 
            // lblReminder
            // 
            lblReminder.AutoSize = true;
            lblReminder.Location = new Point(98, 175);
            lblReminder.Name = "lblReminder";
            lblReminder.Size = new Size(79, 20);
            lblReminder.TabIndex = 2;
            lblReminder.Text = "Reminders";
            // 
            // picReminder
            // 
            picReminder.Image = Properties.Resources.icons8_bell_96;
            picReminder.Location = new Point(73, 20);
            picReminder.Margin = new Padding(3, 4, 3, 4);
            picReminder.Name = "picReminder";
            picReminder.Size = new Size(114, 133);
            picReminder.TabIndex = 1;
            picReminder.TabStop = false;
            picReminder.Click += pnlReminder_Click;
            // 
            // pnlEmergency
            // 
            pnlEmergency.BackColor = Color.WhiteSmoke;
            pnlEmergency.BorderStyle = BorderStyle.FixedSingle;
            pnlEmergency.Controls.Add(lblEmergency);
            pnlEmergency.Controls.Add(picEmergency);
            pnlEmergency.Location = new Point(154, 413);
            pnlEmergency.Margin = new Padding(3, 4, 3, 4);
            pnlEmergency.Name = "pnlEmergency";
            pnlEmergency.Size = new Size(251, 226);
            pnlEmergency.TabIndex = 2;
            pnlEmergency.Click += pnlEmergency_Click;
            pnlEmergency.MouseEnter += pnlEmergency_MouseEnter;
            pnlEmergency.MouseLeave += pnlEmergency_MouseLeave;
            // 
            // lblEmergency
            // 
            lblEmergency.AutoSize = true;
            lblEmergency.Location = new Point(53, 172);
            lblEmergency.Name = "lblEmergency";
            lblEmergency.Size = new Size(143, 20);
            lblEmergency.TabIndex = 3;
            lblEmergency.Text = "Emergency Contacts";
            // 
            // picEmergency
            // 
            picEmergency.Image = Properties.Resources.icons8_emergency_96;
            picEmergency.Location = new Point(64, 19);
            picEmergency.Margin = new Padding(3, 4, 3, 4);
            picEmergency.Name = "picEmergency";
            picEmergency.Size = new Size(114, 125);
            picEmergency.TabIndex = 2;
            picEmergency.TabStop = false;
            picEmergency.Click += pnlEmergency_Click;
            // 
            // pnlVoice
            // 
            pnlVoice.BackColor = Color.WhiteSmoke;
            pnlVoice.BorderStyle = BorderStyle.FixedSingle;
            pnlVoice.Controls.Add(lblVoice);
            pnlVoice.Controls.Add(picVoice);
            pnlVoice.Location = new Point(665, 413);
            pnlVoice.Margin = new Padding(3, 4, 3, 4);
            pnlVoice.Name = "pnlVoice";
            pnlVoice.Size = new Size(251, 226);
            pnlVoice.TabIndex = 3;
            pnlVoice.Click += pnlVoice_Click;
            pnlVoice.MouseEnter += pnlVoice_MouseEnter;
            pnlVoice.MouseLeave += pnlVoice_MouseLeave;
            // 
            // lblVoice
            // 
            lblVoice.AutoSize = true;
            lblVoice.Location = new Point(73, 172);
            lblVoice.Name = "lblVoice";
            lblVoice.Size = new Size(107, 20);
            lblVoice.TabIndex = 4;
            lblVoice.Text = "Voice Assistant";
            // 
            // picVoice
            // 
            picVoice.Image = Properties.Resources.icons8_audio_96;
            picVoice.Location = new Point(73, 19);
            picVoice.Margin = new Padding(3, 4, 3, 4);
            picVoice.Name = "picVoice";
            picVoice.Size = new Size(114, 125);
            picVoice.TabIndex = 3;
            picVoice.TabStop = false;
            picVoice.Click += pnlVoice_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(489, 705);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 4;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1125, 815);
            Controls.Add(btnExit);
            Controls.Add(pnlVoice);
            Controls.Add(pnlEmergency);
            Controls.Add(pnlReminder);
            Controls.Add(pnlGuide);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHome";
            Load += FrmHome_Load;
            MouseEnter += FrmHome_MouseEnter;
            pnlGuide.ResumeLayout(false);
            pnlGuide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGuide).EndInit();
            pnlReminder.ResumeLayout(false);
            pnlReminder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picReminder).EndInit();
            pnlEmergency.ResumeLayout(false);
            pnlEmergency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEmergency).EndInit();
            pnlVoice.ResumeLayout(false);
            pnlVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlGuide;
        private Panel pnlReminder;
        private Panel pnlEmergency;
        private Panel pnlVoice;
        private Button btnExit;
        private Label lblGuide;
        private PictureBox picGuide;
        private Label lblReminder;
        private PictureBox picReminder;
        private PictureBox picEmergency;
        private PictureBox picVoice;
        private Label lblEmergency;
        private Label lblVoice;
    }
}