using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        private void Save_Click(object sender, EventArgs e)
        {

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
    }
}
