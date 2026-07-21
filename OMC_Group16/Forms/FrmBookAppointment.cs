using OMC_Group16.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OMC_Group16.Forms
{
    public partial class FrmBookAppointment : Form
    {
        string connectionString =
        @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";

        SqlConnection con;
        public FrmBookAppointment(string caregiverName)
        {
            InitializeComponent();

            con = new SqlConnection(caregiverName);
            lblCaregiverName.Text = caregiverName;
           
            
        }


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
            lblCaregiverName.Text = UserSession.CaregiverName;

        }
        private void LoadElderly()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT PatientID, FullName FROM seniors";
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbElderly.DataSource = dt;
            cmbElderly.DisplayMember = "FullName";
            cmbElderly.ValueMember = "PatientID";





        }
        

        private void FrmBookAppointment_Load(object sender, EventArgs e)
        {
            LoadElderly();
            LoadTime();
            
            //MessageBox.Show("Form Loaded");
            //MessageBox.Show("Name received" + UserSession.CaregiverName);
            lblCaregiverName.Text = UserSession.CaregiverName;
            txtPrice.ReadOnly = true;
            dtpDate.MinDate = DateTime.Today;
            

            
            



        }
        
        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboService.Text)
            {
                case "General Check-up":
                    txtPrice.Text = "50";
                    break;

                case "Blood Pressure Check":
                    txtPrice.Text = "20";
                    break;

                case "Diabetes Consultation":
                    txtPrice.Text = "80";
                    break;

                case "Immediate Consultation":
                    txtPrice.Text = "100";
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
            if (cmbElderly.SelectedIndex == -1)
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

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                INSERT INTO Appointments
                (
                         PatientID, AppointmentDate, AppointmentTime,
                         Status, CaregiverID, ServiceID
                )
                VALUES
                (        @PatientID, @Date, @Time,
                         @Status, @CaregiverID,@ServiceID
                 );
                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                 ";


                
                

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(cmbElderly.SelectedValue));
                cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                cmd.Parameters.AddWithValue("@Time", cboTime.Text);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                cmd.Parameters.AddWithValue("@CaregiverID", UserSession.CaregiverID);
                cmd.Parameters.AddWithValue("@ServiceID", cboService.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));

                con.Open();
                int appointmentID = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show("Appointment booked successfully.");

                FrmPayment payment = new FrmPayment(appointmentID);
                payment.Show();

                this.Hide();
            }
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
        

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbElderly_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadTime()
        {
            cboTime.Items.Clear();

            cboTime.Items.Add("09:00 AM");
            cboTime.Items.Add("10:00 AM");
            cboTime.Items.Add("11:00 AM");
            cboTime.Items.Add("12:00 PM");
            cboTime.Items.Add("01:00 PM");
            cboTime.Items.Add("02:00 PM");
            cboTime.Items.Add("03:00 PM");
        }


    }
}
