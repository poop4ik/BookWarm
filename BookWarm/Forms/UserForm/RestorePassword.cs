using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class RestorePassword : KryptonForm
    {
        public RestorePassword()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string email = emailTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email))
            {
                emptytextbox.Visible = true;
                return;
            }
            else
            {
                emptytextbox.Visible = false;
            }

            if (IsUserValid(username, email))
            {
                ChangePassword changePasswordForm = new ChangePassword();
                changePasswordForm.Username = usernameTextBox.Text;
                this.Close();
                changePasswordForm.Show();

            }
            else
            {
                ValidLoginAndEmail.Visible = true;
            }
        }

        private bool IsUserValid(string username, string email)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Email = @Email";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
