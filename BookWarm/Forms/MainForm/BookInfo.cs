using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm.Forms.MainForm
{

    public partial class BookInfo : KryptonForm
    {
        private User user;
        private int bookID;
        private int authorID;
        private int userID;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;
        public static List<AllUsers> allUserList;

        public BookInfo(int authorID, int bookID, Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.bookID = bookID;
            this.authorID = authorID;
            this.userID = Main.user.UserId;

            bool isBookInPreferences = CheckIfBookInPreferences(userID, bookID);

            SaveToPreference.Visible = !isBookInPreferences;
            DeleteFromPreference.Visible = isBookInPreferences;

            allUserList = new List<AllUsers>();

            genreListBox.DrawMode = DrawMode.OwnerDrawFixed;
            genreListBox.DrawItem += genreListBox_DrawItem;

            Resize_Click(this, EventArgs.Empty);

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);

            GetAllUsersFromDatabase();

            
            SetBookInfo();
            AlignTextBothSides(Description);

        }

        private void SetBookInfo()
        {
            Book book = Main.books.FirstOrDefault(b => b.BookID == bookID);
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            if (book != null)
            {
                authorText.Text = author?.AuthorName ?? "Unknown Author";

                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);

                if (bookStat != null)
                {
                    titleText.Text = $"Книга: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"}";
                    Year.Text = $"{book.Year}";
                    ReadsCount.Text = $"📕 {bookStat.ReadsCount}";
                    ViewCount.Text = $"👁 {bookStat.ViewCount}";
                    BookImage.Image = book.CoverImageObject;
                    DescriptionTitle.Text = $"Короткий зміст книги: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"} (анотація)";

                    AgeCategory.Text = $"{book.AgeCategory}+";
                    Language.Text = $"{book.Language}";

                    const int maxTitleLength = 1000;
                    Description.Text = TrimDescription(book.Description, maxTitleLength);

                    List<BookGenre> bookGenres = GetBookGenres(bookID);
                    genreListBox.Items.Add(string.Join(", ", bookGenres.Select(genre => genre.GenreName)));


                    List<Review> bookReviews = GetBookReviews(bookID);
                    bookReviews = bookReviews.OrderByDescending(review => review.ReviewDate).ToList();

                    flowLayoutPanelReview.Controls.Clear();

                    foreach (Review review in bookReviews)
                    {
                        AllUsers reviewUser = allUserList.FirstOrDefault(user => user.UserId == review.UserID);
                        UserControlReview reviewControl = new UserControlReview(mainForm);
                        Image profilePhoto = reviewUser?.ProfilePhotoObject ?? Properties.Resources.logo;
                        reviewControl.SetData(reviewUser?.UserName ?? "Unknown User", profilePhoto, review.ReviewDate, review.Rate, review.ReviewText);
                        flowLayoutPanelReview.Controls.Add(reviewControl);
                    }


                    using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                    {
                        connection.Open();

                        string query = "SELECT COUNT(*) FROM UserReviews WHERE BookID = @BookID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", book.BookID);

                            int reviewCount = (int)command.ExecuteScalar();

                            ReviewGeneral.Text = $"Відгуки на книгу «{book.Title}» — {author?.AuthorName ?? "Unknown Author"} ({reviewCount})";
                        }
                    }
                }
            }
        }

        private List<AllUsers> GetAllUsersFromDatabase()
        {
            List<AllUsers> allUsersList = new List<AllUsers>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AllUsers user = new AllUsers
                            {
                                UserId = (int)reader["UserID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                ProfilePhoto = (reader["ProfilePhoto"] == DBNull.Value ? null : (byte[])reader["ProfilePhoto"])
                            };

                            if (user.ProfilePhoto != null)
                            {
                                ImageConverter converter = new ImageConverter();
                                Image img = (Image)converter.ConvertFrom(user.ProfilePhoto);
                                user.ProfilePhotoObject = img;

                                allUserList.Add(user);
                            }

                            allUserList.Add(user);
                        }
                    }
                }
            }
            return allUsersList;
        }

        private List<Review> GetBookReviews(int bookID)
        {
            List<Review> reviews = new List<Review>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT * FROM UserReviews WHERE BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Review review = new Review
                            {
                                ReviewID = (int)reader["ReviewID"],
                                UserID = (int)reader["UserID"],
                                BookID = (int)reader["BookID"],
                                ReviewText = reader["ReviewText"].ToString(),
                                ReviewDate = (DateTime)reader["ReviewDate"],
                                Rate = (decimal)reader["Rate"],
                            };

                            reviews.Add(review);
                        }
                    }
                }
            }

            return reviews;
        }

        private string TrimDescription(string description, int maxLength)
        {
            maxLength = 731;

            if (description.Length > maxLength)
            {
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

                            bookGenres.Add(bookGenre);
                        }
                    }
                }
            }

            return bookGenres;
        }

        private void genreListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
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

            e.Graphics.DrawString(
                genreListBox.Items[e.Index].ToString(),
                e.Font,
                new SolidBrush(e.ForeColor),
                e.Bounds.Left,
                e.Bounds.Top + (e.Bounds.Height - e.Font.Height) / 2);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Resize_MouseEnter(object sender, EventArgs e)
        {
            Resize.Image = Properties.Resources.resizegif;
        }

        private void Resize_MouseLeave(object sender, EventArgs e)
        {
            Resize.Image = Properties.Resources.resizepng;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.exitgif;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
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
                isMaximized = false;
            }
            else
            {
                originalSize = this.Size;

                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                isMaximized = true;
            }
        }

        private void AlignTextBothSides(TextBox textBox)
        {
            using (Graphics g = textBox.CreateGraphics())
            {
                Size textSize = TextRenderer.MeasureText(g, textBox.Text, textBox.Font);

                int textLeftMargin = (textBox.ClientSize.Width - textSize.Width) / 2;

                textBox.Padding = new Padding(textLeftMargin, 0, 0, 0);
            }
        }


        private void WriteReview_Click(object sender, EventArgs e)
        {
            ToolForm.BookWorm setReview = new ToolForm.BookWorm(bookID, mainForm);
            setReview.ShowDialog();
            ReviewUpdate();
            
        }

        public void ReviewUpdate()
        {
            BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);
            Book book = Main.books.FirstOrDefault(b => b.BookID == bookID);
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);
            List<Review> bookReviews = GetBookReviews(bookID);

            bookReviews = bookReviews.OrderByDescending(review => review.ReviewDate).ToList();

            flowLayoutPanelReview.Controls.Clear();

            foreach (Review review in bookReviews)
            {
                AllUsers reviewUser = allUserList.FirstOrDefault(user => user.UserId == review.UserID);

                UserControlReview reviewControl = new UserControlReview(mainForm);

                Image profilePhoto = reviewUser?.ProfilePhotoObject ?? Properties.Resources.logo;

                reviewControl.SetData(reviewUser?.UserName ?? "Unknown User", profilePhoto, review.ReviewDate, review.Rate, review.ReviewText);
                flowLayoutPanelReview.Controls.Add(reviewControl);
            }
        }

        private void AddUserReadRecord(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "INSERT INTO [dbo].[UserReadNow] (UserID, BookID) VALUES (@UserID, @BookID)";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool IsUserReadingBook(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT COUNT(*) FROM [dbo].[UserReadNow] WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private bool IsUserReadBook(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT COUNT(*) FROM [dbo].[UserRead] WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private bool CheckIfBookInPreferences(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                // Перевірте наявність книги в UserPreference для користувача
                string query = "SELECT COUNT(*) FROM UserPreference WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void AddBookToPreferences(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO UserPreference (UserID, BookID) VALUES (@UserID, @BookID)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void RemoveBookFromPreferences(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM UserPreference WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void ReadBook_Click(object sender, EventArgs e)
        {
            int userID = Main.user.UserId;

            if (!IsUserReadingBook(userID, bookID) && !IsUserReadBook(userID, bookID))
            {
                AddUserReadRecord(userID, bookID);
            }

            BookRead readBook = new BookRead(bookID, mainForm, authorID);
            readBook.ShowDialog();
        }

        private void SaveToPreference_Click(object sender, EventArgs e)
        { 
            AddBookToPreferences(userID, bookID);

            SaveToPreference.Visible = false;
            DeleteFromPreference.Visible = true;
        }

        private void DeleteFromPreference_Click(object sender, EventArgs e)
        {
            RemoveBookFromPreferences(userID, bookID);

            SaveToPreference.Visible = true;
            DeleteFromPreference.Visible = false;
        }
    }
}
