namespace OMC_Group16
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnSenior_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void btnCaregiver_Click(object sender, EventArgs e)
        {
            FrmCaregiverLogin loginForm = new FrmCaregiverLogin();
            loginForm.Show();
            this.Hide();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voice Assistant Coming Soon");
        }
    }
}
