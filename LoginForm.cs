using System.Data.SqlClient;
using System.Data;


namespace PatientManagementSystem
{

    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS ;Initial Catalog=HospitalDB;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                string query = "SELECT COUNT(*) FROM Admins WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login successful!", "Welcome");

                    // Show the Dashboard and hide login
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Try again.");
                }

                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus(); // Optional: Set focus to username field
        }

        private void _Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
