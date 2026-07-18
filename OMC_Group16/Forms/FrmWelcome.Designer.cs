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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.Image = Properties.Resources.SeniorConnect;
            pictureBox1.Location = new Point(130, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Lime;
            lblSubtitle.Location = new Point(37, 227);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(375, 49);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Connecting Seniors To Digital Services";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSenior
            // 
            btnSenior.BackColor = Color.Khaki;
            btnSenior.Cursor = Cursors.Hand;
            btnSenior.FlatStyle = FlatStyle.Flat;
            btnSenior.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSenior.ForeColor = Color.MidnightBlue;
            btnSenior.Location = new Point(72, 317);
            btnSenior.Name = "btnSenior";
            btnSenior.Size = new Size(300, 86);
            btnSenior.TabIndex = 2;
            btnSenior.Text = "👴🏻👵🏻 CONTINUE AS SENIOR";
            btnSenior.UseVisualStyleBackColor = false;
            btnSenior.Click += btnSenior_Click;
            // 
            // btnCaregiver
            // 
            btnCaregiver.BackColor = Color.LightPink;
            btnCaregiver.Cursor = Cursors.Hand;
            btnCaregiver.FlatStyle = FlatStyle.Flat;
            btnCaregiver.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCaregiver.ForeColor = Color.MidnightBlue;
            btnCaregiver.Location = new Point(72, 435);
            btnCaregiver.Name = "btnCaregiver";
            btnCaregiver.Size = new Size(300, 60);
            btnCaregiver.TabIndex = 3;
            btnCaregiver.Text = "\U0001f9d1🏻‍👩🏻‍👧🏻 CAREGIVER LOGIN";
            btnCaregiver.UseVisualStyleBackColor = false;
            btnCaregiver.Click += btnCaregiver_Click;
            // 
            // btnVoice
            // 
            btnVoice.BackColor = Color.LightSteelBlue;
            btnVoice.Cursor = Cursors.Hand;
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.Font = new Font("Constantia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoice.ForeColor = Color.MidnightBlue;
            btnVoice.Location = new Point(72, 529);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(300, 60);
            btnVoice.TabIndex = 4;
            btnVoice.Text = "🎙VOICE ASSISTANT";
            btnVoice.UseVisualStyleBackColor = false;
            btnVoice.Click += btnVoice_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnVoice);
            panel1.Controls.Add(btnCaregiver);
            panel1.Controls.Add(btnSenior);
            panel1.Controls.Add(lblSubtitle);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 663);
            panel1.TabIndex = 5;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(457, 663);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SeniorConnect";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblSubtitle;
        private Button btnSenior;
        private Button btnCaregiver;
        private Button btnVoice;
        private Panel panel1;
    }
}
