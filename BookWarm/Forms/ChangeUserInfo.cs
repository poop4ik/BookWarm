using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BookWarm.Forms
{
    public partial class ChangeUserInfo : KryptonForm
    {
        private User user;
        public ChangeUserInfo(string username)
        {
            InitializeComponent();

            Save.MouseEnter += new EventHandler(Save_MouseEnter);
            Save.MouseLeave += new EventHandler(Save_MouseLeave);

            Change.MouseEnter += new EventHandler(Change_MouseEnter);
            Change.MouseLeave += new EventHandler(Change_MouseLeave);

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT * FROM Users WHERE Username = @username;";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = (int)reader["UserID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Age = (int)reader["Age"],
                                PasswordHash = reader["PasswordHash"].ToString(),
                                Description = reader["Description"].ToString(),
                                ProfilePhoto = (reader["ProfilePhoto"] == DBNull.Value ? null : (byte[])reader["ProfilePhoto"])
                            };
                        }
                    }
                }
            }

            // Перевірка чи користувач існує
            if (user != null)
            {
                UserNameBox.Text = user.UserName;
                LastNameBox.Text = user.LastName;
                FirstNameBox.Text = user.FirstName;
                AgeBox.Text = user.Age.ToString();
                DescriptionBox.Text = user.Description;
                EmailBox.Text = user.Email;

                if (user.ProfilePhoto != null) // User has a photo.
                {
                    using (MemoryStream ms = new MemoryStream(user.ProfilePhoto))
                    {
                        profilePhotoPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    profilePhotoPictureBox.Image = Properties.Resources.logo;
                    profilePhotoPictureBox.Border = 0;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            // Відкриття форми Main
            //Main mainForm = new Main();
            //mainForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Save_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Save.Image = Properties.Resources.savegif;
        }

        private void Save_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Save.Image = Properties.Resources.savepng;
        }

        private void Change_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Change.Image = Properties.Resources.changegif;
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Change.Image = Properties.Resources.changepng;
        }
        private void Change_Click(object sender, EventArgs e)
        {
            // Якщо хоча б одне поле увімкнено, вимкнути всі
            if (UserNameBox.Enabled || LastNameBox.Enabled || FirstNameBox.Enabled ||
                AgeBox.Enabled || DescriptionBox.Enabled || OldEmailBox.Enabled ||
                NewEmailBox.Enabled || OldPasswordBox.Enabled || NewPasswordBox.Enabled)
            {
                UserNameBox.Enabled = false;
                LastNameBox.Enabled = false;
                FirstNameBox.Enabled = false;
                AgeBox.Enabled = false;
                DescriptionBox.Enabled = false;
                OldEmailBox.Enabled = false;
                NewEmailBox.Enabled = false;
                OldPasswordBox.Enabled = false;
                NewPasswordBox.Enabled = false;
            }
            else
            {
                // Якщо всі поля вимкнені, увімкнути всі
                UserNameBox.Enabled = true;
                LastNameBox.Enabled = true;
                FirstNameBox.Enabled = true;
                AgeBox.Enabled = true;
                DescriptionBox.Enabled = true;
                OldEmailBox.Enabled = true;
                NewEmailBox.Enabled = true;
                OldPasswordBox.Enabled = true;
                NewPasswordBox.Enabled = true;
            }
        }


        private void Save_Click(object sender, EventArgs e)
        {
            // Перевірка наявності пустих полів
            if (string.IsNullOrWhiteSpace(UserNameBox.Text) ||
                string.IsNullOrWhiteSpace(FirstNameBox.Text) ||
                string.IsNullOrWhiteSpace(LastName.Text) ||
                string.IsNullOrWhiteSpace(AgeBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Якщо хоча б одне поле з поштою не пусте, виконуємо перевірки пошти
            // Якщо хоча б одне поле з поштою не пусте, виконуємо перевірки пошти
            if (!string.IsNullOrWhiteSpace(OldEmailBox.Text) || !string.IsNullOrWhiteSpace(NewEmailBox.Text))
            {
                // Перевірка наявності нової пошти
                if (string.IsNullOrWhiteSpace(NewEmailBox.Text))
                {
                    EmailEmpty.Visible = true;
                    ValidEmail.Visible = false;
                    EmailExist.Visible = false;
                    EmailCheck.Visible = false;
                    EmailRepeat.Visible = false;
                    return;
                }
                else
                {
                    EmailEmpty.Visible = false;

                    // Перевірка, чи стара пошта співпадає з новою
                    if (OldEmailBox.Text == NewEmailBox.Text)
                    {
                        EmailRepeat.Visible = true;
                        EmailCheck.Visible = false;
                        ValidEmail.Visible = false;
                        EmailExist.Visible = false;
                        return;
                    }
                    else
                    {
                        EmailRepeat.Visible = false;

                        // Перевірка валідності нової пошти
                        if (!IsValidEmail(NewEmailBox.Text))
                        {
                            ValidEmail.Visible = true;
                            EmailExist.Visible = false;
                            EmailCheck.Visible = false;
                            return;
                        }
                        else
                        {
                            ValidEmail.Visible = false;

                            // Перевірка, чи нова пошта не існує вже в базі
                            if (IsEmailExists(NewEmailBox.Text))
                            {
                                EmailExist.Visible = true;
                                EmailCheck.Visible = false;
                                return;
                            }
                            else
                            {
                                EmailExist.Visible = false;

                                // Перевірка, чи стара пошта співпадає з новою
                                if (OldEmailBox.Text != user.Email)
                                {
                                    EmailCheck.Visible = true;
                                    return;
                                }
                                else
                                {
                                    EmailCheck.Visible = false;
                                }
                            }
                        }
                    }
                }
            }

            // Перевірка стосовно паролів
            if (!string.IsNullOrWhiteSpace(OldPasswordBox.Text) || !string.IsNullOrWhiteSpace(NewPasswordBox.Text))
            {
                PasswordEmpty.Visible = false;
                PasswordRepeat.Visible = false;
                PasswordValid.Visible = false;
                // Перевірка наявності нового пароля
                if (string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                {
                    PasswordEmpty.Visible = true;
                    return;
                }
                else
                {
                    PasswordEmpty.Visible = false;

                    // Перевірка валідності старого пароля
                    if (OldPasswordBox.Text != user.PasswordHash)
                    {
                        PasswordValid.Visible = true;
                        return;
                    }
                    else
                    {
                        PasswordValid.Visible = false;

                        // Перевірка, чи старий пароль співпадає з новим
                        if (OldPasswordBox.Text == NewPasswordBox.Text)
                        {
                            PasswordRepeat.Visible = true;
                            return;
                        }
                        else
                        {
                            PasswordRepeat.Visible = false;
                        }
                    }
                }
            }



            // Перевірка наявності користувача з введеним ім'ям
            if (UserNameBox.Text != user.UserName && IsUsernameExists(UserNameBox.Text))
            {
                UserNameExist.Visible = true;
                return;
            }
            else
            {
                UserNameExist.Visible = false;
            }

            // Перевірка обмеження на кількість символів в описі
            if (DescriptionBox.Text.Length > 80)
            {
                DescriptionLimit.Visible = true;
                return;
            }
            else
            {
                DescriptionLimit.Visible = false;
            }

            // Перевірка, чи вік є числовим значенням більше 0
            if (string.IsNullOrWhiteSpace(AgeBox.Text) || !int.TryParse(AgeBox.Text, out int age) || age <= 0)
            {
                AgeValid.Visible = true;
                return;
            }
            else
            {
                AgeValid.Visible = false;
            }


            // Відключення редагування текстових полів після збереження
            UserNameBox.Enabled = false;
            LastNameBox.Enabled = false;
            FirstNameBox.Enabled = false;
            AgeBox.Enabled = false;
            DescriptionBox.Enabled = false;
            OldEmailBox.Enabled = false;
            NewEmailBox.Enabled = false;
            OldPasswordBox.Enabled = false;
            NewPasswordBox.Enabled = false;
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {
            if (NewPasswordBox.PasswordChar == '*' & OldPasswordBox.PasswordChar == '*')
            {
                // Показувати текст паролю
                NewPasswordBox.PasswordChar = '\0'; // '\0' відображає текст як звичайний текст
                OldPasswordBox.PasswordChar = '\0';
            }
            else
            {
                // Приховувати текст паролю з зірочкою '*'
                NewPasswordBox.PasswordChar = '*';
                OldPasswordBox.PasswordChar = '*';
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
    }
}
