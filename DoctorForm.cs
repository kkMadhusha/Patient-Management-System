using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientManagementSystem
{
    public partial class DoctorForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=HospitalDB;Integrated Security=True";

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Doctors (FullName, Specialization, PhoneNumber) VALUES (@name, @specialization, @phone)", con);

            cmd.Parameters.AddWithValue("@name", txtDocName.Text);
            cmd.Parameters.AddWithValue("@specialization", txtSpecial.Text);
            cmd.Parameters.AddWithValue("@phone", txtDocPhone.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Doctor added successfully!");
            LoadDoctors();   // Refresh table
            //ClearFields();   // Reset inputs
        }
        private void LoadDoctors()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Doctors", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDoctors.DataSource = dt;
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDocName.Clear();
            txtSpecial.Clear();
            txtDocPhone.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to return to the dashboard?", "Back to Dashboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Close();
            }
        }
    }
}
