using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm
{
    public partial class Registration : KryptonForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWarmDBDataSet);

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookWarmDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);
            usernameTextBox.Clear();
            firstNameTextBox.Clear();
            passwordHashTextBox.Clear();
            lastNameTextBox.Clear();
            emailTextBox.Clear();
            AgeTextBox.Clear();
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
            Authentication authentication = new Authentication();
            authentication.Show();
        }

        private bool isDataInserted = false; // Булева змінна для слідкування стану

        private void RegAuth_Click(object sender, EventArgs e)
        {
            // Перевірка, чи дані вже вставлені
            if (!isDataInserted)
            {
                // Отримайте дані з текстових полів
                string username = usernameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string passwordHash = passwordHashTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string email = emailTextBox.Text;
                string age = AgeTextBox.Text;

/*                if (System.Text.RegularExpressions.Regex.IsMatch(AgeTextBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Для того щоб вказати вік, використовуйте тільки цифри.");
                    AgeTextBox.Text = AgeTextBox.Text.Remove(AgeTextBox.Text.Length - 1);
                }*/

                // Перевірка, чи всі дані введені
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(passwordHash) ||
                    string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(age))
                {
                    MessageBox.Show("Будь ласка, введіть всі дані");
                    return;
                }

                // Перевірка існування користувача з вже наявним username та email
                bool isUsernameExists = IsUsernameExists(username);
                bool isEmailExists = IsEmailExists(email);

                if (isUsernameExists && isEmailExists)
                {
                    // Якщо ім'я і пошта збігаються з існуючими користувачами, вивести відповідні помилки
                    UsernameExist.Visible = true;
                    EmailExist.Visible = true;
                    return;
                }
                else if (isUsernameExists)
                {
                    // Якщо тільки ім'я збігається
                    UsernameExist.Visible = true;
                    EmailExist.Visible = false;
                    return;
                }
                else if (isEmailExists)
                {
                    // Якщо тільки пошта збігається
                    UsernameExist.Visible = false;
                    EmailExist.Visible = true;
                    return;
                }
                else if (!IsValidEmail(email))
                {
                    // Якщо пошта не має правильного формату
                    EmailExist.Visible = true;
                    return;
                }
                else
                {
                    // Тут виконайте вставку даних у вашу базу даних
                    int userId;

                    using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                    {
                        connection.Open();

                        // Додайте користувача до таблиці Users та отримайте ідентифікатор вставленого запису
                        string insertUserQuery = "INSERT INTO Users (Username, FirstName, PasswordHash, LastName, Email, Age) " +
                            "OUTPUT INSERTED.UserID " +
                            "VALUES (@Username, @FirstName, @PasswordHash, @LastName, @Email, @Age)";

                        using (SqlCommand userCommand = new SqlCommand(insertUserQuery, connection))
                        {
                            userCommand.Parameters.AddWithValue("@Username", username);
                            userCommand.Parameters.AddWithValue("@FirstName", firstName);
                            userCommand.Parameters.AddWithValue("@PasswordHash", passwordHash);
                            userCommand.Parameters.AddWithValue("@LastName", lastName);
                            userCommand.Parameters.AddWithValue("@Email", email);
                            userCommand.Parameters.AddWithValue("@Age", age);

                            // Отримайте ідентифікатор вставленого користувача
                            userId = (int)userCommand.ExecuteScalar();
                        }

                        // Додайте користувача до таблиці UserStatistics
                        string insertUserStatisticsQuery = "INSERT INTO UserStatistics (UserID, TotalReads, TotalViews) " +
                            "VALUES (@UserID, 0, 0)";

                        using (SqlCommand userStatisticsCommand = new SqlCommand(insertUserStatisticsQuery, connection))
                        {
                            userStatisticsCommand.Parameters.AddWithValue("@UserID", userId);

                            userStatisticsCommand.ExecuteNonQuery();
                        }
                    }


                    UsernameExist.Visible = false;
                    EmailExist.Visible = false;

                    // Очистіть дані після вставки
                    usernameTextBox.Clear();
                    firstNameTextBox.Clear();
                    passwordHashTextBox.Clear();
                    lastNameTextBox.Clear();
                    emailTextBox.Clear();
                    AgeTextBox.Clear();

                    // Оновлення даних
                    usersBindingSource.EndEdit();

                    // Встановіть флаг, що дані вставлені
                    isDataInserted = true;
                    Success success = new Success();
                    success.Show();
                    this.Close();
                    Main mainForm = new Main(username); // Передайте username в конструктор головної форми
                    mainForm.Show();
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    // Визначаємо параметр @Username
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private bool IsEmailExists(string email)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email"; 
                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        //private void LOGIN_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    // Відкриття форми Main
        //    Success success = new Success(username);
        //    success.Show();
        //}

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (passwordHashTextBox.PasswordChar == '*')
            {
                // Показувати текст паролю
                passwordHashTextBox.PasswordChar = '\0'; // '\0' відображає текст як звичайний текст
            }
            else
            {
                // Приховувати текст паролю з зірочкою '*'
                passwordHashTextBox.PasswordChar = '*';
            }
        }
    }
}

