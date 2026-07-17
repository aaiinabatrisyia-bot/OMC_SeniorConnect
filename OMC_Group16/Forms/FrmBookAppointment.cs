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
            this.Load += FrmBookAppointment_Load;
        }
        private void FrmBookAppointment_Load(object sender, EventArgs e)
        {
            lblCaregiverName.Text = FrmCaregiverLogin.CaregiverName;

            LoadElderly();
            
        }
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboService.Text)
            {
                case "General Check-up":
                    lblPrice.Text = "RM50";
                    break;

                case "Blood Pressure Check":
                    lblPrice.Text = "RM20";
                    break;

                case "Diabetes Consultation":
                    lblPrice.Text = "RM80";
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
            string service = cboService.Text;
            string date = dtpDate.Value.ToShortDateString();
            string time = cboTime.Text;
            string price = lblPrice.Text;

            FrmPayment frm = new FrmPayment(
                service,
                date,
                time,
                price
            );

            frm.Show();
            this.Hide();
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
        
    }
}
