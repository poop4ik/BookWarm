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
        AppSettings appSettings = new AppSettings();
        string connectionString;


        public Main()
        {
            InitializeComponent();
            connectionString = appSettings.ConnectionString;
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
                profilePhotoPictureBox.Size = new Size(profilePhotoPictureBox.Width = 54, profilePhotoPictureBox.Height = 54);// Зменшення розміру 
                profilePhotoPictureBox.Location = new Point(profilePhotoPictureBox.Location.X, profilePhotoPictureBox.Location.Y + 20);
                LineLogo.Location = new Point(-7, 375);
                isMaximized = false;
            }
            else
            {
                // Максимізуємо вікно на весь екран
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                profilePhotoPictureBox.Size = new Size(profilePhotoPictureBox.Width = 74, profilePhotoPictureBox.Height = 74); // Збільшення розміру 
                profilePhotoPictureBox.Location = new Point(profilePhotoPictureBox.Location.X, profilePhotoPictureBox.Location.Y - 20);
                LineLogo.Location = new Point(profilePhotoPictureBox.Location.X, profilePhotoPictureBox.Location.Y - 10);
                isMaximized = true;
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
            this.Close();
            // Відкриття форми Main
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
        }   
    }
}
