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
    public partial class PatientForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=HospitalDB;Integrated Security=True";

        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Patients (FullName, Gender, DOB, PhoneNumber, Address) VALUES (@name, @gender, @dob, @phone, @address)", con);

            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Value);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Patient added successfully.");
            LoadPatients(); // Refresh DataGridView
            ClearFields();  // Optional
        }

        private void LoadPatients()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPatients.DataSource = dt;
        }

        private void ClearFields()
        {
            txtName.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnBack_Click(object sender, EventArgs e)
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
