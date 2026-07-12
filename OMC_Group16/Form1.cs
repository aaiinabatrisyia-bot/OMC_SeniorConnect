namespace OMC_Group16
{
    using System;
    using System.Windows.Forms;
    public partial class frmEmergency : Form
    {
        public frmEmergency()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAmbulance_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name first. ", "Infomartion needed. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"Are you sure you want to call an Ambulance for {name}?", "Emergency confirmation. ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The Ambulance has been called!! Please wait. ", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Inaccurate information.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string data = $"Name = {txtName.Text}\n" + $"Phone Number = {txtPhone.Text}\n" + $"Emergency Contact = {txtEmergencyContact.Text}\n" + $"Address = {txtAddress.Text}\n" + $"Additional Note = {txtNote.Text}\n";

            MessageBox.Show($"Emergency Information saved : \n\n{data}", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnContactFamily_Click(object sender, EventArgs e)
        {
            string contact = txtEmergencyContact.Text.Trim();

            if (string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("Please enter your Emergency Contact.", "Information needed. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Calling Emergency Contact {contact}...", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeComponent()
        {

        }

        private void btnNearbyClinic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finding nearby clinic..", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Panel panel1;
    }
}
