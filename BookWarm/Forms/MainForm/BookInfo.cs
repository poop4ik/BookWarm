using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BookWarm.Forms.MainForm
{
    
    public partial class BookInfo : KryptonForm
    {
        private User user;
        private int bookID;
        private int authorID;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;
        public BookInfo(int authorID, int bookID, Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.bookID = bookID;
            this.authorID = authorID;

            genreListBox.DrawMode = DrawMode.OwnerDrawFixed;
            genreListBox.DrawItem += genreListBox_DrawItem;

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
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            // Check if the book is found
            if (book != null)
            {
                // Access the AuthorName property through the Author property
                authorText.Text = author?.AuthorName ?? "Unknown Author";

                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);

                // Check if BookStat is found
                if (bookStat != null)
                {
                    titleText.Text = $"Книга: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"}";
                    ReadsCount.Text = $"📕 {bookStat.ReadsCount}";
                    ViewCount.Text = $"👁 {bookStat.ViewCount}";
                    BookImage.Image = book.CoverImageObject;
                    DescriptionTitle.Text = $"Короткий зміст книги: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"} (анотація)";

                    const int maxTitleLength = 1000;
                    Description.Text = TrimDescription(book.Description, maxTitleLength);

                    // Get the list of genres for the current book
                    List<BookGenre> bookGenres = GetBookGenres(bookID);

                    // Concatenate genre names with commas and display in the ListBox
                    genreListBox.Items.Add(string.Join(", ", bookGenres.Select(genre => genre.GenreName)));
                }
            }
        }

        private string TrimDescription(string description, int maxLength)
        {
            if (description.Length > maxLength)
            {
                // Trim the description to the specified length and append "..."
                return description.Substring(0, maxLength - 3) + "...";
            }

            return description;
        }

        private List<BookGenre> GetBookGenres(int bookID)
        {
            List<BookGenre> bookGenres = new List<BookGenre>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT DISTINCT G.GenreID, G.GenreName, GBR.GenreBookRelationID " +
                                  "FROM Genres G " +
                                  "JOIN GenreBookRelation GBR ON G.GenreID = GBR.GenreID " +
                                  "WHERE GBR.BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookGenre bookGenre = new BookGenre
                            {
                                GenreID = (int)reader["GenreID"],
                                GenreName = reader["GenreName"].ToString(),
                                GenreBookRelationID = (int)reader["GenreBookRelationID"]
                            };

                            // Add the genre to the local variable
                            bookGenres.Add(bookGenre);
                        }
                    }
                }
            }

            return bookGenres;
        }

        private void genreListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Set background color for the selected item
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(
                    e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    SystemColors.Highlight);

                e.DrawBackground();
            }



            // Draw the text of the item
            e.Graphics.DrawString(
                genreListBox.Items[e.Index].ToString(),
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.Left,
                e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2);

            // Optionally, draw additional elements based on your requirements
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
            mainForm.PopulateBookData();
            mainForm.RatingBookData();
            mainForm.PopularBookData();
        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Close();
            mainForm.PopulateBookData();
            mainForm.RatingBookData();
            mainForm.PopularBookData();
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
