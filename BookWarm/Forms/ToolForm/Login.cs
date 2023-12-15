using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Login : KryptonForm
    {
        public string Username { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (var form in openForms)
            {
                form.Close();
            }

            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

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
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);

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
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Save();

                this.Close();
                Success success = new Success();
                success.ShowDialog();


                ValidLoginAndPassword.Visible = false;
                Main mainForm = new Main(username);
                UserProfile userProfile = new UserProfile(username, mainForm);
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
