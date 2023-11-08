using BookWarm.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm
{
    public partial class Main : Form
    {
        private User user;
        private Size originPhotoSize;
        private Point originPhotoLocation;

        public Main(string username)
        {
            InitializeComponent();

            originPhotoLocation = profilePhotoPictureBox.Location;
            originPhotoSize = profilePhotoPictureBox.Size;

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
                                ProfilePhoto = (reader["ProfilePhoto"] == DBNull.Value ? null : (byte[])reader["ProfilePhoto"])
                            };
                        }
                    }
                }
            }

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
            }
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

        private bool isMinimized = true; // Перевірка стану максимізації

        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMinimized)
            {
                // Повертаємо вікно до звичайного розміру
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None; // Встановлюємо рамку вікна (опціонально)
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                profilePhotoPictureBox.Size = originPhotoSize; // Збільшння розміру 
                profilePhotoPictureBox.Location = originPhotoLocation;
                //profilePhotoPictureBox.Location = new Point(440, 520);
                isMinimized = false;
            }
            else
            {
                // Максимізуємо вікно на весь екран
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                //profilePhotoPictureBox.Size = new Size(profilePhotoPictureBox.Width = 70, profilePhotoPictureBox.Height = 70);// Зменшення розміру 
                //profilePhotoPictureBox.Location = new Point(((int)(Width / 2) - (int)(profilePhotoPictureBox.Width / 2)), profilePhotoPictureBox.Location.Y - 10);
                isMinimized = true;
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWarmDBDataSet);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookWarmDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);
        }

        private void profilePhotoPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Відкриття форми Main
            UserProfile userProfile = new UserProfile(user.UserName);
            userProfile.ShowDialog();
            this.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
