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
    public partial class DashboardForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=HospitalDB;Integrated Security=True";

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void btnPatientManagement_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm();
            patientForm.Show();
            this.Close();
        }

        private void btnDoctorManagement_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
            this.Close();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Close();
        }
    }
}
