using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Main : KryptonForm
    {
        private User user;
        private Size originPhotoSize;
        private Point originPhotoLocation;
        private bool isMaximized = false; // Перевірка стану максимізації
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;

        public Main(string username)
        {
            InitializeComponent();

            originPhotoLocation = profilePhotoPictureBox.Location;
            originPhotoSize = profilePhotoPictureBox.Size;

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

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
                profilePhotoPictureBox.Size = originPhotoSize; // Збільшння розміру 
                profilePhotoPictureBox.Location = originPhotoLocation;
                //profilePhotoPictureBox.Location = new Point(440, 520);
            }
            else
            {
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

        private void AuthenticationPanel_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
