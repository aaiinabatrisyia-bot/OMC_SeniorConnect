namespace FrmEmergency
{
    public partial class FrmEmergency2 : Form
    {
        public FrmEmergency2()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // test
        }

        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter your address first!", "Address Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                $" Call AMBULANCE (999)? \n\n" +
                $" Address: {txtAddress.Text}\n\n" +
                "Only use in real emergencies!",
                "Emergency Call",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Calling AMBULANCE (999)...\n\n" +
                    $"Location: {txtAddress.Text}\n" +
                    $"Name: {txtName.Text}\n\n" +
                    "Please stay on the line.",
                    "Ambulance dispatched",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEmergencyContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmergencyContact.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show(
                    "Please fill in Emergency Contact Name and Phone Number first.",
                    "Contact required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
           $"Call Emergency Contact?\n\n" +
           $"Name: {txtEmergencyContact.Text}\n" +
           $"Phone: {txtPhoneNumber.Text}\n\n" +
           "Do you want to call this contact?",
           "Emergency Contact",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Calling {txtEmergencyContact.Text} at {txtPhoneNumber.Text}...",
                    "Calling Emergency Contact",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnNearbyClinic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClinic.Text))
            {
                MessageBox.Show(
                    "Please enter the nearby Clinic name first.",
                    "Clinic Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtClinic.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Call nearby Clinic?\n\n" +
                $"Clinic: {txtClinic.Text}\n\n" +
                "Do you want to call this clinic?",
                "Nearby clinic",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"Calling {txtClinic.Text}...\n\n" +
                    "Please ask fornearest available doctor.",
                    "Calling clinic",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear all fields?",
                "Confirm clear",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtName.Clear();
                txtPhoneNumber.Clear();
                txtEmergencyContact.Clear();
                txtAddress.Clear();
                txtClinic.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm exit.",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string input = txtPhoneNumber.Text;
            string digitsOnly = new string(input.Where(char.IsDigit).ToArray());

            if (input != digitsOnly)
            {
                txtPhoneNumber.Text = digitsOnly;
                txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
