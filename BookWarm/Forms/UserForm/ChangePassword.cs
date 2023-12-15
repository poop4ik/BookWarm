using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BookWarm
{
    public partial class ChangePassword : KryptonForm
    {
        public string Username { get; set; }

        public ChangePassword()
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
            RestorePassword restorepassword = new RestorePassword();
            restorepassword.Show();
        }

        private void ConfirmChange_Click(object sender, EventArgs e)
        {
            string newPassword = passwordHashTextBox.Text;
            string confirmPassword = confirmPasswordHashTextBox.Text;
            string username = Username;

            if (newPassword != confirmPassword)
            {
                ValidPassword.Visible = true;
            }
            else
            {
                if (UpdatePasswordInDatabase(username, newPassword))
                {
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Оновлення паролю було відхилено.");
                    return;
                }
            }
        }

        private bool UpdatePasswordInDatabase(string username, string newPassword)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Users SET PasswordHash = @NewPassword WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@NewPassword", newPassword);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void ShowConfirmPassword_Click(object sender, EventArgs e)
        {
            if (confirmPasswordHashTextBox.PasswordChar == '*')
            {
                confirmPasswordHashTextBox.PasswordChar = '\0';
            }
            else
            {
                confirmPasswordHashTextBox.PasswordChar = '*';
            }
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (passwordHashTextBox.PasswordChar == '*')
            {
                passwordHashTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordHashTextBox.PasswordChar = '*';
            }
        }
    }
}
