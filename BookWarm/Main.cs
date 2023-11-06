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

namespace BookWarm
{
    public partial class Main : Form
    {
        AppSettings appSettings = new AppSettings();
        string connectionString;
        public string Username { get; set; }

        public Main(string username)
        {
            InitializeComponent();
            connectionString = appSettings.ConnectionString;
            Username = username; // Присвоюємо значення властивості Username
            DisplayUserProfilePhoto(); // Отримуємо та відображаємо фотографію користувача
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

        private bool isMaximized = true; // Перевірка стану максимізації

        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Повертаємо вікно до звичайного розміру
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None; // Встановлюємо рамку вікна (опціонально)
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                ProfileLogo.Size = new Size(ProfileLogo.Width = 54, ProfileLogo.Height = 54);// Зменшення розміру 
                ProfileLogo.Location = new Point(ProfileLogo.Location.X, ProfileLogo.Location.Y + 20);

                isMaximized = false;
            }
            else
            {
                // Максимізуємо вікно на весь екран
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                ProfileLogo.Size = new Size(ProfileLogo.Width = 74, ProfileLogo.Height = 74); // Збільшення розміру 
                ProfileLogo.Location = new Point(ProfileLogo.Location.X, ProfileLogo.Location.Y - 20);

                isMaximized = true;
            }
        }


        public byte[] GetProfilePhotoFromDatabase(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT ProfilePhoto FROM Users WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    // Виконуємо запит та отримуємо результат
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Отримуємо фото як масив байтів
                        if (reader["ProfilePhoto"] != DBNull.Value)
                        {
                            return (byte[])reader["ProfilePhoto"];
                        }
                    }
                }
            }

            return null; // Якщо фото не знайдено
        }

        private void DisplayUserProfilePhoto()
        {
            // Отримайте фото користувача з бази даних
            byte[] profilePhotoBytes = GetProfilePhotoFromDatabase(Username);

            if (profilePhotoBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(profilePhotoBytes))
                {
                    Image profileImage = Image.FromStream(ms);
                    SetRoundPictureBox(ProfileLogo, profileImage); // Використовуйте метод для встановлення круглої фотографії
                }
            }

        }

        private void SetRoundPictureBox(PictureBox pictureBox, Image image)
        {
            int diameter = Math.Min(pictureBox.Width, pictureBox.Height);
            Bitmap roundImage = new Bitmap(diameter, diameter);

            using (Graphics g = Graphics.FromImage(roundImage))
            using (Brush brush = new SolidBrush(Color.Transparent))
            {
                g.FillRegion(brush, new Region(new Rectangle(0, 0, diameter, diameter)));
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.CompositingQuality = CompositingQuality.HighQuality;

                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, diameter, diameter);

                g.SetClip(path, CombineMode.Replace);
                g.DrawImage(image, 0, 0, diameter, diameter);
            }

            pictureBox.Image = roundImage;
        }

    }
}
