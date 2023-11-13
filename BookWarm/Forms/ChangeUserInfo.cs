using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm.Forms
{
    public partial class ChangeUserInfo : KryptonForm
    {
        private User user;
        private Image currentImage;
        private string selectedImagePath;
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public ChangeUserInfo(string username)
        {
            InitializeComponent();

            DescriptionBox.TextChanged += DescriptionBox_TextChanged;

            Save.MouseEnter += new EventHandler(Save_MouseEnter);
            Save.MouseLeave += new EventHandler(Save_MouseLeave);

            Change.MouseEnter += new EventHandler(Change_MouseEnter);
            Change.MouseLeave += new EventHandler(Change_MouseLeave);

            ChangePhoto.MouseEnter += new EventHandler(ChangePhoto_MouseEnter);
            ChangePhoto.MouseLeave += new EventHandler(ChangePhoto_MouseLeave);

            Reset.MouseEnter += new EventHandler(Reset_MouseEnter);
            Reset.MouseLeave += new EventHandler(Reset_MouseLeave);

            Delete.MouseEnter += new EventHandler(Delete_MouseEnter);
            Delete.MouseLeave += new EventHandler(Delete_MouseLeave);

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

        private void ChangePhoto_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            ChangePhoto.Image = Properties.Resources.changephotogif;
        }

        private void ChangePhoto_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            ChangePhoto.Image = Properties.Resources.changephotopng;
        }

        private void Reset_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Reset.Image = Properties.Resources.resetgif;
        }

        private void Reset_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Reset.Image = Properties.Resources.reset;
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Delete.Image = Properties.Resources.deletegif;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Delete.Image = Properties.Resources.deletepng;
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
            ClearAllLabels();
            if (string.IsNullOrWhiteSpace(UserNameBox.Text) ||
                string.IsNullOrWhiteSpace(FirstNameBox.Text) ||
                string.IsNullOrWhiteSpace(LastName.Text) ||
                string.IsNullOrWhiteSpace(AgeBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Перевірка наявності нової пошти
            if (!string.IsNullOrWhiteSpace(OldEmailBox.Text) || !string.IsNullOrWhiteSpace(NewEmailBox.Text))
            {
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

            // Перевірка обмеження на кількість символів в описі
            if (DescriptionBox.Text.Length >= 80)
            {
                DescriptionLimit.Visible = true;
                return;
            }
            else
            {
                DescriptionLimit.Visible = false;
            }


            bool success = SaveProfileDataToDatabase(user.UserName);

            if (success)
            {
                ClearAllLabels();
                MessageBox.Show("Дані профілю успішно збережено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка при збереженні даних профілю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Відключення редагування текстових полів після збереження
        private void ClearAllLabels()
        {
            ValidEmail.Visible = false;
            EmailExist.Visible = false;
            EmailCheck.Visible = false;
            EmailRepeat.Visible = false;
            EmailEmpty.Visible = false;

            PasswordEmpty.Visible = false;
            PasswordRepeat.Visible = false;
            PasswordValid.Visible = false;

            UserNameExist.Visible = false;
            DescriptionLimit.Visible = false;
            AgeValid.Visible = false;
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

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            // Встановлення максимальної довжини для опису (наприклад, 80)
            int maxLength = 80;

            // Перевірка, чи кількість символів перевищує максимальну довжину
            if (DescriptionBox.Text.Length >= maxLength)
            {
                DescriptionLimit.Visible = true;
            }
            else
            {
                DescriptionLimit.Visible = false;
            }
        }
        private bool SaveProfileDataToDatabase(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    // Assuming you have a table named 'Users' with columns 'UserName', 'FirstName', 'LastName', 'Age', 'Email', 'Description', 'PasswordHash', etc.
                    string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Description = @Description";

                    // Include email update only if NewEmailBox is not empty
                    if (!string.IsNullOrWhiteSpace(NewEmailBox.Text))
                    {
                        updateQuery += ", Email = @Email";
                    }

                    // Include password update only if NewPasswordBox is not empty
                    if (!string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                    {
                        updateQuery += ", PasswordHash = @PasswordHash";
                    }

                    updateQuery += " WHERE UserName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(AgeBox.Text)); // Assuming Age is an integer
                        cmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);
                        cmd.Parameters.AddWithValue("@UserName", username);

                        // Add parameters for email and password only if not empty
                        if (!string.IsNullOrWhiteSpace(NewEmailBox.Text))
                        {
                            cmd.Parameters.AddWithValue("@Email", NewEmailBox.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                        {
                            // Hash the password or apply your password storage mechanism here
                            cmd.Parameters.AddWithValue("@PasswordHash", NewPasswordBox.Text);
                        }

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool SaveProfileImageToDatabase(string username)
        {

            // Визначити формат зображення на основі розширення файлу
            ImageFormat imageFormat = ImageFormat.Png; // за замовчуванням - PNG

            string extension = Path.GetExtension(selectedImagePath);
            if (!string.IsNullOrEmpty(extension))
            {
                switch (extension.ToLower())
                {
                    case ".jpg":
                    case ".jpeg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                    // Додайте інші можливі розширення за необхідності
                    default:
                        MessageBox.Show("Непідтримуване розширення файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false; // Повертаємо false, щоб показати, що збереження не вдалося
                }
            }

            using (MemoryStream ms = new MemoryStream())
            {
                // Зберегти зображення у визначений формат у пам'яті
                profilePhotoPictureBox.Image.Save(ms, imageFormat);

                // Оновити зображення в базі даних
                byte[] imageBytes = ms.ToArray();

                try
                {
                    using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                    {
                        connection.Open();

                        // SQL-запит для оновлення зображення профілю
                        string updateQuery = "UPDATE Users SET ProfilePhoto = @ProfilePhoto WHERE UserName = @Username";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            // Параметри
                            command.Parameters.AddWithValue("@ProfilePhoto", imageBytes);
                            command.Parameters.AddWithValue("@Username", username);

                            // Виконати SQL-запит
                            command.ExecuteNonQuery();
                        }
                    }

                    // Присвоїти null поточному зображенню (currentImage), оскільки нове зображення тепер є актуальним
                    currentImage = null;

                    return true; // Збереження пройшло успішно
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка збереження фотографії в базі даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Збереження не вдалося через помилку
                }
            }
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Виберіть зображення";
                openFileDialog.Filter = "Зображення|*.jpg;*.jpeg;*.png;|Всі файли|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Зберегти поточне зображення
                    currentImage = profilePhotoPictureBox.Image;

                    // Отримати шлях до обраного файлу
                    selectedImagePath = openFileDialog.FileName;

                    // Встановити зображення у profilePhotoPictureBox
                    profilePhotoPictureBox.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // Перевірити, чи є збережене зображення
            if (currentImage != null)
            {
                // Повернути до попереднього зображення
                profilePhotoPictureBox.Image = currentImage;

                // Приховати кнопку SavePhoto, оскільки зображення не змінено
                SavePhoto.Visible = false;
            }
            // Якщо currentImage == null, нічого не робити
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Зберегти поточне зображення
            currentImage = profilePhotoPictureBox.Image;
            // Зміна зображення у profilePhotoPictureBox на logo
            profilePhotoPictureBox.Image = Properties.Resources.logo;
        }

        private void SavePhoto_Click(object sender, EventArgs e)
        {
            // Перевірка, чи обрано нове зображення перед збереженням
            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Будь ласка, виберіть нове зображення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження фотографії профілю в базі даних
            bool success = SaveProfileImageToDatabase(user.UserName);

            // Виведення MessageBox тільки якщо збереження пройшло успішно
            if (success)
            {
                MessageBox.Show("Дані профілю успішно збережені.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистити шлях до обраного файлу
                selectedImagePath = null;

                // Закрити форму чи виконати інші необхідні дії
            }
            else
            {
                // Обробка випадку, коли збереження не вдалося
                MessageBox.Show("Дані профілю не вдалося змінити.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
