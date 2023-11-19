using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;


namespace BookWarm.Forms.MainForm
{
    
    public partial class BookInfo : KryptonForm
    {
        private User user;
        private int bookID;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;
        public BookInfo(int bookID, Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.bookID = bookID;
            Resize_Click(this, EventArgs.Empty);

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);
            SetBookInfo();
        }

        private void SetBookInfo()
        {
            Book book = Main.books.FirstOrDefault(b => b.BookID == bookID);
           
            
            // Перевірте, чи книга знайдена
            if (book != null)
            {
                // Виведіть title та author на формі
                titleText.Text = book.Title;
                authorText.Text = book.Author;
                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);

                // Check if BookStat is found
                if (bookStat != null)
                {
                    // Use bookStat.ReadsCount and bookStat.ViewCount as needed
                    // For example:
                    ReadsCount.Text = $"📕 {bookStat.ReadsCount}";
                    ViewCount.Text = $"👁 {bookStat.ViewCount}";
                }
            }
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            // Змінити зображення при наведенні
            Exit.Image = Properties.Resources.exitgif;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            // Повернутися до попереднього зображення при виході миші
            Exit.Image = Properties.Resources.exit;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.WindowState = FormWindowState.Normal;
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Close();
            mainForm.WindowState = FormWindowState.Normal;

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
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                isMaximized = true;
            }
        }
    }
}
