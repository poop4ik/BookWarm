using BookWarm.Data.Models;
using BookWarm.Forms;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class UserProfile : KryptonForm
    {
        private User user;
        private bool isMaximized = false; // Перевірка стану максимізації
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        public UserProfile(string username)
        {
            InitializeComponent();

            Resize_Click(this, EventArgs.Empty);

            ChangeInfo.MouseEnter += new EventHandler(ChangeInfo_MouseEnter);
            ChangeInfo.MouseLeave += new EventHandler(ChangeInfo_MouseLeave);

            Resize.MouseEnter     += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave    += new EventHandler(Resize_MouseLeave);

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
                // Встановлення значень у відповідні елементи на формі
                lblFullName.Text = $"{user.LastName} {user.FirstName}";
                lblFullName.TextAlign = ContentAlignment.MiddleCenter;
                lblUsername.Text = user.UserName;
                lblUsername.TextAlign = ContentAlignment.MiddleCenter;
                lblDescription.Text = user.Description;
                lblDescription.TextAlign = ContentAlignment.MiddleCenter;

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


        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Повертаємо вікно до звичайного розміру
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = originalFormBorderStyle;
                this.Size = originalSize;
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                isMaximized = false;
            }
            else
            {
                // Збільшуємо розмір вікна до розмірів екрана, залишаючи видимою панель завдань
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)

                // Встановлюємо розмір вікна на розміри екрана, залишаючи простір для панелі завдань
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                isMaximized = true;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeInfo_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            ChangeInfo.Image = Properties.Resources.gear;
        }

        private void ChangeInfo_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            ChangeInfo.Image = Properties.Resources.gearpng1;
        }

        private void Resize_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Resize.Image = Properties.Resources.resizegif;
        }

        private void Resize_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Resize.Image = Properties.Resources.resizepng;
        }

        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeUserInfo changeUserInfo = new ChangeUserInfo(user.UserName);
            changeUserInfo.ShowDialog();
            this.Show();
        }
    }
}
