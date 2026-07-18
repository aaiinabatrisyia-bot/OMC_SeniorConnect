using System.Speech.Synthesis;

namespace OMC_Group16
{
   

    public partial class FrmWelcome : Form
    {
        private readonly SpeechSynthesizer voiceAssistant =
       new SpeechSynthesizer();
        private bool isSpeaking = false;

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
            if (!isSpeaking)
            {
                voiceAssistant.SpeakAsyncCancelAll();

                voiceAssistant.SpeakAsync(
                    "Welcome to Senior Connect. " +
                    "Select Continue as Senior to access senior services. " +
                    "Select Caregiver Login to access the caregiver account."
                );

                btnVoice.Text = "🔇 STOP VOICE";
                isSpeaking = true;
            }
            else
            {
                voiceAssistant.SpeakAsyncCancelAll();

                btnVoice.Text = "🎙 VOICE ASSISTANT";
                isSpeaking = false;
            }
        }
    }
}
