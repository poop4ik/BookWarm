using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm.Forms.MainForm
{
    public partial class AuthorInfo : KryptonForm
    {
        private User user;
        private string author;
        private int authorID;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;


        public AuthorInfo(int authorID, Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.authorID = authorID;

            Resize_Click(this, EventArgs.Empty);

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);

            SetAuthorInfo();

            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            PopulateBooksByAuthor(authorID);
        }


        private void SetAuthorInfo()
        {
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            // Check if the author is found
            if (author != null)
            {
                // Display author information on the form
                AuthorNameText.Text = author.AuthorName;
                CountryText.Text = author.Country;
                AuthorID.Text = $"{author.AuthorID}";
                RelationID.Text = $"{author.RelationID}";
            }
        }

        private void PopulateBooksByAuthor(int authorID)
        {
            // Clear existing controls in the FlowLayoutPanel
            flowLayoutPanelAuthorBooks.Controls.Clear();

            // Iterate through the books and create a UserControl for each book by the specified author
            foreach (Book book in Main.books.Where(b => b.AuthorID == authorID))
            {
                // Get the corresponding BookStat for the current book
                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                // You may need to adjust the constructor parameters based on your UserControl implementation
                UserControlAuthor bookControl = new UserControlAuthor(mainForm);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID);
                flowLayoutPanelAuthorBooks.Controls.Add(bookControl);
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
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Close();

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
