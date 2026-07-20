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
    public partial class FrmPayment : Form
    {
        string connectionString =
        @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";
        private int appointmentID;
        public FrmPayment(int appointmentID)
        {
            InitializeComponent();

            this.appointmentID = appointmentID;


            LoadAppointment();
        }
        private void LoadAppointment()
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query = @"SELECT ServiceName, AppointmentDate,
                            AppointmentTime, Price
                     FROM Appointments
                     WHERE AppointmentID = @AppointmentID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblService.Text = reader["ServiceName"].ToString();
                lblDate.Text = Convert.ToDateTime(reader["AppointmentDate"]).ToShortDateString();
                lblTime.Text = reader["AppointmentTime"].ToString();
                lblAmount.Text = reader["Price"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            pnlBank.Visible = false;
            pnlCard.Visible = false;

            cboBank.SelectedIndex = 0;
        }

        private void rbBank_CheckedChanged(object sender, EventArgs e)
        {
            pnlBank.Visible = rbBank.Checked;
            pnlCard.Visible = false;
        }

        private void rbCard_CheckedChanged(object sender, EventArgs e)
        {
            pnlCard.Visible = rbCard.Checked;
            pnlBank.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmBookAppointment frm = new FrmBookAppointment();

            frm.Show();

            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
         
            if (!rbBank.Checked && !rbCard.Checked)
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            FrmPaymentSuccess frm = new FrmPaymentSuccess();

            frm.Show();

            this.Hide();
         }
        
    }
}
