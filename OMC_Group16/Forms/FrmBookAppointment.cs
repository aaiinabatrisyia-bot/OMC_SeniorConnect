using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OMC_Group16.Forms
{
    public partial class FrmBookAppointment : Form
    {
        public FrmBookAppointment(string caregiverName)
        {
            InitializeComponent();
            lblCaregiverName.Text = caregiverName;
        }
        string connectionString =
        @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";

        private int caregiverID;

        public FrmBookAppointment(int id)
        {
            InitializeComponent();
            caregiverID = id;

        }
        public FrmBookAppointment()
        {
            InitializeComponent();
            //this.Load += FrmBookAppointment_Load;
        }
        private void FrmBookAppointment_Load(object sender, EventArgs e)
        {
            lblCaregiverName.Text = FrmCaregiverLogin.CaregiverName;
            txtPrice.ReadOnly = true;
            dtpDate.MinDate = DateTime.Today;


        }
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboService.Text)
            {
                case "General Check-up":
                    txtPrice.Text = "RM50";
                    break;

                case "Blood Pressure Check":
                    txtPrice.Text = "RM20";
                    break;

                case "Diabetes Consultation":
                    txtPrice.Text = "RM80";
                    break;

                default:
                    txtPrice.Clear();
                    break;


            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmClinicServices frm = new FrmClinicServices();

            frm.Show();

            this.Hide();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if(cmbElderly.SelectedIndex == -1)
    {
                MessageBox.Show("Please select an elderly patient.");
                return;
            }

            if (cboService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service.");
                return;
            }

            if (cboTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment time.");
                return;
            }

            // Save appointment here

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"INSERT INTO Appointments
           (CaregiverID, CaregiverName, ElderlyName, Service, AppointmentDate, AppointmentTime, Price)
          VALUES
           (@CaregiverID, @CaregiverName, @ElderlyName, @Service, @Date, @Time, @Price)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@CaregiverID", FrmCaregiverLogin.CaregiverID);
            cmd.Parameters.AddWithValue("@CaregiverName", FrmCaregiverLogin.CaregiverName);
            cmd.Parameters.AddWithValue("@ElderlyName", cmbElderly.Text);
            cmd.Parameters.AddWithValue("@Service", cboService.Text);
            cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
            cmd.Parameters.AddWithValue("@Time", cboTime.Text);
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Appointment booked successfully!");
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            string service = cboService.Text; service = service.ToUpper();
        }

        private void lblCaregiverName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadElderly()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
             SELECT DISTINCT p.PatientID, p.Name AS FullName
             FROM Patients p
             INNER JOIN Appointments a
             ON p.PatientID = a.PatientID
             WHERE a.CaregiverID = @CaregiverID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CaregiverID", FrmCaregiverLogin.CaregiverID);

                con.Open();

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                cmbElderly.DataSource = dt;
                cmbElderly.DisplayMember = "FullName";
                cmbElderly.ValueMember = "PatientID";
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
