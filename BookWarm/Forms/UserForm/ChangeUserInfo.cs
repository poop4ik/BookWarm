using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BookWarm.Forms
{
    public partial class ChangeUserInfo : KryptonForm
    {
        private User user;
        private Image previousImage;
        private Main mainForm;

        public ChangeUserInfo(string username, Main mainForm)
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

            this.mainForm = mainForm;

            user = GetUserByUsername(username);

            if (user != null)
            {
                UserNameBox.Text = user.UserName;
                LastNameBox.Text = user.LastName;
                FirstNameBox.Text = user.FirstName;
                AgeBox.Text = user.Age.ToString();
                DescriptionBox.Text = user.Description;
                EmailBox.Text = user.Email;

                if (user.ProfilePhoto != null)
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
            mainForm.UpdatePhoto();
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
            Save.Image = Properties.Resources.savegif;
        }

        private void Save_MouseLeave(object sender, EventArgs e)
        {
            Save.Image = Properties.Resources.savepng;
        }

        private void Change_MouseEnter(object sender, EventArgs e)
        {
            Change.Image = Properties.Resources.changegif;
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            Change.Image = Properties.Resources.changepng;
        }

        private void ChangePhoto_MouseEnter(object sender, EventArgs e)
        {
            ChangePhoto.Image = Properties.Resources.changephotogif;
        }

        private void ChangePhoto_MouseLeave(object sender, EventArgs e)
        {
            ChangePhoto.Image = Properties.Resources.changephotopng;
        }

        private void Reset_MouseEnter(object sender, EventArgs e)
        {
            Reset.Image = Properties.Resources.resetgif;
        }

        private void Reset_MouseLeave(object sender, EventArgs e)
        {
            Reset.Image = Properties.Resources.reset;
        }

        private void Delete_MouseEnter(object sender, EventArgs e)
        {

            Delete.Image = Properties.Resources.deletegif;
        }

        private void Delete_MouseLeave(object sender, EventArgs e)
        {
            Delete.Image = Properties.Resources.deletepng;
        }
        private void Change_Click(object sender, EventArgs e)
        {
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
                UserNameBox.Enabled = false;
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
            ClearAllLabels();
            if (string.IsNullOrWhiteSpace(UserNameBox.Text) ||
                string.IsNullOrWhiteSpace(FirstNameBox.Text) ||
                string.IsNullOrWhiteSpace(LastName.Text) ||
                string.IsNullOrWhiteSpace(AgeBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

                            if (IsEmailExists(NewEmailBox.Text))
                            {
                                EmailExist.Visible = true;
                                EmailCheck.Visible = false;
                                return;
                            }
                            else
                            {
                                EmailExist.Visible = false;

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

            if (!string.IsNullOrWhiteSpace(OldPasswordBox.Text) || !string.IsNullOrWhiteSpace(NewPasswordBox.Text))
            {
                PasswordEmpty.Visible = false;
                PasswordRepeat.Visible = false;
                PasswordValid.Visible = false;

                if (string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                {
                    PasswordEmpty.Visible = true;
                    return;
                }
                else
                {
                    PasswordEmpty.Visible = false;

                    if (OldPasswordBox.Text != user.PasswordHash)
                    {
                        PasswordValid.Visible = true;
                        return;
                    }
                    else
                    {
                        PasswordValid.Visible = false;

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

            if (UserNameBox.Text != user.UserName && IsUsernameExists(UserNameBox.Text))
            {
                UserNameExist.Visible = true;
                return;
            }
            else
            {
                UserNameExist.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(AgeBox.Text) || !int.TryParse(AgeBox.Text, out int age) || age <= 0)
            {
                AgeValid.Visible = true;
                return;
            }
            else
            {
                AgeValid.Visible = false;
            }

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
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

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
                NewPasswordBox.PasswordChar = '\0';
                OldPasswordBox.PasswordChar = '\0';
            }
            else
            {
                NewPasswordBox.PasswordChar = '*';
                OldPasswordBox.PasswordChar = '*';
            }
        }

        private void DescriptionBox_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 80;

            if (DescriptionBox.Text.Length >= maxLength)
            {
                DescriptionLimit.Visible = true;
            }
            else
            {
                DescriptionLimit.Visible = false;
            }
        }

        public static User GetUserByUsername(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Users WHERE UserName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User
                                {
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    UserName = Convert.ToString(reader["UserName"]),
                                    FirstName = Convert.ToString(reader["FirstName"]),
                                    LastName = Convert.ToString(reader["LastName"]),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Email = Convert.ToString(reader["Email"]),
                                    PasswordHash = Convert.ToString(reader["PasswordHash"]),
                                    Description = Convert.ToString(reader["Description"]),
                                };

                                if (reader["ProfilePhoto"] != DBNull.Value)
                                {
                                    user.ProfilePhoto = (byte[])reader["ProfilePhoto"];
                                }

                                return user;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return null;
        }

        private bool SaveProfileDataToDatabase(string username)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Description = @Description";

                    if (!string.IsNullOrWhiteSpace(NewEmailBox.Text))
                    {
                        updateQuery += ", Email = @Email";
                    }

                    if (!string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                    {
                        updateQuery += ", PasswordHash = @PasswordHash";
                    }

                    updateQuery += " WHERE UserName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameBox.Text);
                        cmd.Parameters.AddWithValue("@Age", int.Parse(AgeBox.Text));
                        cmd.Parameters.AddWithValue("@Description", DescriptionBox.Text);
                        cmd.Parameters.AddWithValue("@UserName", username);

                        if (!string.IsNullOrWhiteSpace(NewEmailBox.Text))
                        {
                            cmd.Parameters.AddWithValue("@Email", NewEmailBox.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(NewPasswordBox.Text))
                        {
                            cmd.Parameters.AddWithValue("@PasswordHash", NewPasswordBox.Text);
                        }

                        user.UpdateProfile(FirstNameBox.Text, LastNameBox.Text, NewEmailBox.Text, int.Parse(AgeBox.Text), DescriptionBox.Text);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool SaveProfileImageToDatabase(string username, Image image)
        {
            try
            {
                if (image == null)
                {
                    return false;
                }

                byte[] imageData;

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, ImageFormat.Png);
                    imageData = ms.ToArray();
                }

                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Users SET ProfilePhoto = @ProfilePhoto WHERE UserName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProfilePhoto", imageData);
                        cmd.Parameters.AddWithValue("@UserName", username);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void ChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePhotoPictureBox.Image = Image.FromFile(openFileDialog.FileName);

                profilePhotoPictureBox.Border = 1;
                SavePhoto.Visible = true;

                Back.Enabled = false;
                Save.Enabled = false;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            previousImage = profilePhotoPictureBox.Image;
            profilePhotoPictureBox.Image = Properties.Resources.logo;

            SavePhoto.Visible = true;
            Back.Enabled = false;
            Save.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            profilePhotoPictureBox.Image = previousImage ?? Properties.Resources.logo;
            profilePhotoPictureBox.Border = (profilePhotoPictureBox.Image == Properties.Resources.logo) ? 0 : 1;

            SavePhoto.Visible = true;
            Back.Enabled = false;
            Save.Enabled = false;
        }

        private void SavePhoto_Click(object sender, EventArgs e)
        {
            if (SaveProfileImageToDatabase(user.UserName, profilePhotoPictureBox.Image))
            {
                MessageBox.Show("Фото профілю змінено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SavePhoto.Visible = false;
                Back.Enabled = true;
                Save.Enabled = true;
            }
            else
            {
                MessageBox.Show("Помилка при зміні фото профілю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void profilePhotoPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePhotoPictureBox.Image = Image.FromFile(openFileDialog.FileName);

                profilePhotoPictureBox.Border = 1;
                SavePhoto.Visible = true;
            }
        }
    }
}
    
