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
    public partial class ChangePassword : Form
    {
        public string Username { get; set; }
        public ChangePassword()
        {
            InitializeComponent();
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
            // Закрити поточну форму 
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
                ValidPassword.Visible = true; // Паролі не співпадають, відображаємо повідомлення про помилку
            }
            else
            {
                // Паролі співпадають, оновлюємо пароль в базі даних для користувача з іменем username
                if (UpdatePasswordInDatabase(username, newPassword))
                {
                    this.Close();
                    Success success = new Success();
                    success.Show();
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
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\BookWarm;Initial Catalog=BookWarmDB;Integrated Security=True"))
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
                // Обробка помилок
                return false;
            }
        }
    }
}
