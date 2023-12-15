using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Registration : KryptonForm
    {
        private bool isDataInserted = false;

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
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

            Authentication authentication = new Authentication();
            authentication.Show();
        }

        private void RegAuth_Click(object sender, EventArgs e)
        {
            if (!isDataInserted)
            {
                string username = usernameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string passwordHash = passwordHashTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string email = emailTextBox.Text;
                string age = AgeTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(passwordHash) ||
                    string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(age))
                {
                    MessageBox.Show("Будь ласка, введіть всі дані");
                    return;
                }

                bool isUsernameExists = IsUsernameExists(username);
                bool isEmailExists = IsEmailExists(email);

                if (isUsernameExists && isEmailExists)
                {
                    UsernameExist.Visible = true;
                    EmailExist.Visible = true;
                    return;
                }
                else if (isUsernameExists)
                {
                    UsernameExist.Visible = true;
                    EmailExist.Visible = false;
                    return;
                }
                else if (isEmailExists)
                {
                    UsernameExist.Visible = false;
                    EmailExist.Visible = true;
                    return;
                }
                else if (!IsValidEmail(email))
                {
                    EmailExist.Visible = true;
                    return;
                }
                else
                {
                    int userId;

                    using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                    {
                        connection.Open();

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

                            userId = (int)userCommand.ExecuteScalar();
                        }

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

                    usernameTextBox.Clear();
                    firstNameTextBox.Clear();
                    passwordHashTextBox.Clear();
                    lastNameTextBox.Clear();
                    emailTextBox.Clear();
                    AgeTextBox.Clear();

                    usersBindingSource.EndEdit();


                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Save();

                    isDataInserted = true;

                    Success success = new Success();
                    success.ShowDialog();

                    this.Close();

                    Main mainForm = new Main(username);
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

