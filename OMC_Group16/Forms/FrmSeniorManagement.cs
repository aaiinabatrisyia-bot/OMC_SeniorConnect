using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OMC_Group16.Forms
{
    public partial class FrmSeniorManagement : Form
    {
        string connectionString =
        @"Data Source = (localdb)\MSSQLLocalDB;
        Initial Catalog = OMC_SeniorConnectDB; 
        Integrated Security = True;";
        public FrmSeniorManagement()
        {
            InitializeComponent();
        }

        private void txtSeniorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rdoMale.Checked)
                gender = "Male";
            else if (rdoFemale.Checked)
                gender = "Female";

            SqlConnection con = new SqlConnection(connectionString);

            string query = @"INSERT INTO Seniors
                    (FullName,Age, PhoneNumber, Address, Gender)
                    VALUES
                    (@name,@age, @phone, @address, @gender)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@name", txtSeniorName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtSeniorAge.Text));
            cmd.Parameters.AddWithValue("@phone", txtPhoneNumber2.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@gender", gender);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Senior added successfully.");
        }

        private void FrmSeniorManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmCaregiverMenu menu = new FrmCaregiverMenu();
            menu.Show();
            this.Close();
        }
    }
}
