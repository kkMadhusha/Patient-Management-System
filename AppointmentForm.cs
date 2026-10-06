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
using Microsoft.VisualBasic;


namespace PatientManagementSystem
{
    public partial class AppointmentForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=HospitalDB;Integrated Security=True";

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void LoadPatients()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT PatientID, FullName FROM Patients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbPatient.DataSource = dt;
            cmbPatient.DisplayMember = "FullName";
            cmbPatient.ValueMember = "PatientID";
        }

        private void LoadDoctors()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT DoctorID, FullName FROM Doctors", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbDoctor.DataSource = dt;
            cmbDoctor.DisplayMember = "FullName";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            LoadPatients();
            LoadDoctors();

            cmbStatus.Items.AddRange(new string[] { "Scheduled", "Completed", "Cancelled" });
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Status) VALUES (@patientId, @doctorId, @date, @status)", con);

            cmd.Parameters.AddWithValue("@patientId", cmbPatient.SelectedValue);
            cmd.Parameters.AddWithValue("@doctorId", cmbDoctor.SelectedValue);
            cmd.Parameters.AddWithValue("@date", dtpDate.Value);
            cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Appointment booked!");
            LoadAppointments();  // Refresh DataGridView
            ClearFields();       // Optional
        }

        private void LoadAppointments()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT 
            a.AppointmentID,
            p.FullName AS PatientName,
            d.FullName AS DoctorName,
            a.AppointmentDate,
            a.Status
        FROM Appointments a
        JOIN Patients p ON a.PatientID = p.PatientID
        JOIN Doctors d ON a.DoctorID = d.DoctorID
    ", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAppointments.DataSource = dt;
        }
        private void ClearFields()
        {
            cmbPatient.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
            cmbStatus.SelectedIndex = -1;
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
