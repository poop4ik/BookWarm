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
    public partial class Login : Form
    {
        public string Username { get; private set; }
        public Login()
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
            // Закрити поточну форму реєстрації
            this.Close();

            // Створити і показати форму авторизації (передбачається, що ця форма називається "LoginForm")
            Authentication authentication = new Authentication();
            authentication.Show();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWarmDBDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWarmDBDataSet);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookWarmDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);

        }

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

        private void LoginInAccount_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordHashTextBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                emptytextbox.Visible = true;
                return;
            }
            else
            {
                emptytextbox.Visible = false;
            }

            if (IsUserValid(username, password))
            {
                this.Close();
                Success success = new Success();
                success.ShowDialog();
                
                ValidLoginAndPassword.Visible = false;
                Main mainForm = new Main(username);
                UserProfile userProfile = new UserProfile(username);
                mainForm.Show();
            }
            else
            {
                ValidLoginAndPassword.Visible = true;
            }
        }


        private bool IsUserValid(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string selectQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void RestorePassword_Click(object sender, EventArgs e)
        {
            RestorePassword RestorePassword = new RestorePassword();
            RestorePassword.Show();
            this.Close();
        }
    }
}
