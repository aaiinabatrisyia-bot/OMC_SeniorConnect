namespace OMC_Group16
{
    partial class FrmWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblSubtitle = new Label();
            btnSenior = new Button();
            btnCaregiver = new Button();
            btnVoice = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SeniorConnect;
            pictureBox1.Location = new Point(300, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(230, 205);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Connecting Seniors To Digital Services";
            // 
            // btnSenior
            // 
            btnSenior.BackColor = Color.Khaki;
            btnSenior.Cursor = Cursors.Hand;
            btnSenior.FlatStyle = FlatStyle.Flat;
            btnSenior.Font = new Font("Constantia", 15.75F);
            btnSenior.Location = new Point(252, 255);
            btnSenior.Name = "btnSenior";
            btnSenior.Size = new Size(300, 60);
            btnSenior.TabIndex = 2;
            btnSenior.Text = "👴🏻👵🏻 Continue As Senior";
            btnSenior.UseVisualStyleBackColor = false;
            btnSenior.Click += btnSenior_Click;
            // 
            // btnCaregiver
            // 
            btnCaregiver.BackColor = Color.LightPink;
            btnCaregiver.Cursor = Cursors.Hand;
            btnCaregiver.FlatStyle = FlatStyle.Flat;
            btnCaregiver.Font = new Font("Constantia", 15.75F);
            btnCaregiver.Location = new Point(252, 349);
            btnCaregiver.Name = "btnCaregiver";
            btnCaregiver.Size = new Size(300, 60);
            btnCaregiver.TabIndex = 3;
            btnCaregiver.Text = "\U0001f9d1🏻‍👩🏻‍👧🏻 Caregiver Login";
            btnCaregiver.UseVisualStyleBackColor = false;
            btnCaregiver.Click += btnCaregiver_Click;
            // 
            // btnVoice
            // 
            btnVoice.BackColor = Color.LightSteelBlue;
            btnVoice.Cursor = Cursors.Hand;
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.Font = new Font("Constantia", 15.75F);
            btnVoice.Location = new Point(252, 442);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(300, 60);
            btnVoice.TabIndex = 4;
            btnVoice.Text = "🎙Voice Assistant";
            btnVoice.UseVisualStyleBackColor = false;
            btnVoice.Click += btnVoice_Click;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 561);
            Controls.Add(btnVoice);
            Controls.Add(btnCaregiver);
            Controls.Add(btnSenior);
            Controls.Add(lblSubtitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeniorConnect";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSubtitle;
        private Button btnSenior;
        private Button btnCaregiver;
        private Button btnVoice;
    }
}
