using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class RestorePassword : Form
    {
        AppSettings appSettings = new AppSettings();
        string connectionString;
        public RestorePassword()
        {
            InitializeComponent();
            connectionString = appSettings.ConnectionString;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Отримуємо список всіх відкритих форм
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Закриваємо кожну з них
            foreach (var form in openForms)
            {
                form.Close();
            }

            // Завершуємо додаток
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Закрити поточну форму реєстрації
            this.Close();

            // Створити і показати форму авторизації (передбачається, що ця форма називається "LoginForm")
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
                changePasswordForm.Username = usernameTextBox.Text; // usernameTextBox - поле на формі RestorePassword
                this.Close();
                changePasswordForm.Show();

            }
            else
            {
                // Якщо логін і пошта не існують в базі даних
                ValidLoginAndEmail.Visible = true;
            }
        }

        private bool IsUserValid(string username, string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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
