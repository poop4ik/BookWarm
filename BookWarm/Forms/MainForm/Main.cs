using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Main : KryptonForm
    {
        public static List<Book> books;
        public static List<BookStat> bookStatList;
        public static List<Author> authorList;
        public static List<BookGenre> bookGenresList;
        public static List<Review> userReviewList;
        public static User user;
        public static UserStatistics userstat;
        private Size originPhotoSize;
        private Point originPhotoLocation;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Point originPopularLocation;
        private Point originRatingLocation;
        private Point originNewLocation;
        private static Random random = new Random();

        public Main(string username)
        {

            if (string.IsNullOrEmpty(username))
            {
                Authentication authForm = new Authentication();
                authForm.Show();
                this.Close();
            }
            else
            {
                InitializeComponent();

                books = new List<Book>();
                bookStatList = new List<BookStat>();
                authorList = new List<Author>();
                bookGenresList = new List<BookGenre>();
                userReviewList = new List<Review>();

                SearchBox.Leave += textBoxSearch_Leave;
                SearchBox.Enter += textBoxSearch_Enter;
                SearchBox.KeyPress += SearchBox_KeyPress;

                originPhotoLocation = profilePhotoPictureBox.Location;
                originPhotoSize = profilePhotoPictureBox.Size;
                originPopularLocation = Popular.Location;
                originRatingLocation = Rating.Location;
                originNewLocation = New.Location;
                

                Resize_Click(this, EventArgs.Empty);

                Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
                Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

                Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
                Exit.MouseLeave += new EventHandler(Exit_MouseLeave);


                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    string sqlQuery = "SELECT * FROM Users WHERE UserName = @username";

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

                if (user != null)
                {
                    if (user.ProfilePhoto != null)
                    {
                        using (MemoryStream ms = new MemoryStream(user.ProfilePhoto))
                        {
                            profilePhotoPictureBox.Image = Image.FromStream(ms);
                        }
                        ImageConverter converter = new ImageConverter();
                        Image img = (Image)converter.ConvertFrom(user.ProfilePhoto);
                        user.ProfilePhotoObject = img;
                    }
                    else
                    {
                        profilePhotoPictureBox.Image = Properties.Resources.logo;
                    }

                    using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                    {
                        connection.Open();

                        string query = "SELECT * FROM UserStatistics WHERE UserID = @userID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@userID", user.UserId);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    userstat = new UserStatistics
                                    {
                                        StatisticID = (int)reader["StatisticID"],
                                        UserID = user.UserId,
                                        TotalViews = (int)reader["TotalViews"],
                                        TotalReads = (int)reader["TotalReads"]
                                    };
                                }
                            }
                        }
                    }
                }

                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    string sqlQuery = "SELECT * FROM BOOKS";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    BookID = (int)reader["BookID"],
                                    AuthorID = (int)reader["AuthorID"],
                                    Title = reader["Title"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Language = reader["Language"].ToString(),
                                    Year = (int)reader["Year"],
                                    AgeCategory = (int)reader["AgeCategory"],
                                    Content = (reader["Content"] == DBNull.Value ? null : (byte[])reader["Content"]),
                                    AverageRating = reader["AverageRating"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["AverageRating"]),
                                    CoverImage = (reader["CoverImage"] == DBNull.Value ? null : (byte[])reader["CoverImage"])
                                };

                                if (book.CoverImage != null)
                                {
                                    ImageConverter converter = new ImageConverter();
                                    Image img = (Image)converter.ConvertFrom(book.CoverImage);
                                    book.CoverImageObject = img;

                                    books.Add(book);
                                }
                            }
                        }
                    }

                    string sqlGenreQuery = "SELECT GBR.BookID, G.GenreID, G.GenreName, GBR.GenreBookRelationID " +
                                          "FROM Genres G " +
                                          "JOIN GenreBookRelation GBR ON G.GenreID = GBR.GenreID";

                    using (SqlCommand command = new SqlCommand(sqlGenreQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BookGenre bookGenre = new BookGenre
                                {
                                    BookID = (int)reader["BookID"],
                                    GenreID = (int)reader["GenreID"],
                                    GenreName = reader["GenreName"].ToString(),
                                    GenreBookRelationID = (int)reader["GenreBookRelationID"]
                                };

                                bookGenresList.Add(bookGenre);
                            }
                        }
                        
                    }

                    string sqlReviewQuery = "SELECT * FROM UserReviews";

                    using (SqlCommand command = new SqlCommand(sqlReviewQuery, connection))
                    {
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
                                    ReviewDate = reader["ReviewDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["ReviewDate"]),
                                    Rate = reader["Rate"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["Rate"])
                                };

                                userReviewList.Add(review);
                            }
                        }
                    }

                    string authorQuery = "SELECT * FROM Author " +
                     "INNER JOIN AuthorBookRelation ON Author.AuthorID = AuthorBookRelation.AuthorID";

                    using (SqlCommand command = new SqlCommand(authorQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Author author = new Author
                                {
                                    AuthorID = (int)reader["AuthorID"],
                                    BookID = (int)reader["BookID"],
                                    RelationID = (int)reader["RelationID"],
                                    AuthorName = reader["AuthorName"].ToString(),
                                    Country = reader["Country"].ToString(),
                                    Age = (int)reader["Age"],
                                    AuthorPhoto = (reader["AuthorPhoto"] == DBNull.Value ? null : (byte[])reader["AuthorPhoto"])
                                };

                                if (author.AuthorPhoto != null)
                                {
                                    ImageConverter converter = new ImageConverter();
                                    Image img = (Image)converter.ConvertFrom(author.AuthorPhoto);
                                    author.AuthorPhotoObject = img;

                                    authorList.Add(author);
                                }
                            }
                        }
                    }

                    string readsQuery = "SELECT * FROM BookReads";
                    using (SqlCommand command = new SqlCommand(readsQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int readsCount = (int)reader["ReadsCount"];

                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                if (book != null)
                                {

                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ReadsCount += readsCount;  
                                    }
                                    else
                                    {
                                        BookStat bookStat = new BookStat
                                        {
                                            BookID = bookID,
                                            ReadsCount = readsCount
                                        };
                                        bookStatList.Add(bookStat);
                                    }
                                }
                            }
                        }
                    }

                    string viewsQuery = "SELECT * FROM BookViews";
                    using (SqlCommand command = new SqlCommand(viewsQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int viewCount = (int)reader["ViewCount"];

                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                if (book != null)
                                {
                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ViewCount += viewCount; 
                                    }
                                    else
                                    {
                                        BookStat bookStat = new BookStat
                                        {
                                            BookID = bookID,
                                            ViewCount = viewCount
                                        };
                                        bookStatList.Add(bookStat);
                                    }
                                }
                            }
                        }
                    }

                    PopularBookData();
                    PopulateBookData();
                    RatingBookData();
                    PopulateUserHistory();
                }
            }
        }

        private List<UserHistoryItem> GetUserHistory(int userID)
        {
            List<UserHistoryItem> userHistory = new List<UserHistoryItem>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT BookID, ViewDate FROM UserHistory WHERE UserID = @UserID ORDER BY ViewDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookID = reader.GetInt32(reader.GetOrdinal("BookID"));
                            DateTime viewDate = reader.GetDateTime(reader.GetOrdinal("ViewDate"));

                            userHistory.Add(new UserHistoryItem(bookID, viewDate));
                        }
                    }
                }
            }

            return userHistory;
        }


        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; 
                Popular.Location = new Point(Popular.Location.X, Popular.Location.Y - 25);
                New.Location = new Point(New.Location.X, New.Location.Y);
                Rating.Location = new Point(Rating.Location.X, Rating.Location.Y - 20);

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
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);
        }

        private void profilePhotoPictureBox_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(user.UserName))
            {
                this.Hide();
                UserProfile userProfile = new UserProfile(user.UserName, this);
                userProfile.ShowDialog();
                this.Show();
                UpdatePhoto();
            }
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
            Application.Exit();
        }

        private int previousScrollValue = 0;

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar.Value;
            int scrollDirection = scrollValue - previousScrollValue;

            New.Top -= scrollDirection;
            Popular.Top -= scrollDirection;
            Rating.Top -= scrollDirection;
            LastView.Top -= scrollDirection;
            flowLayoutPanelNew.Top -= scrollDirection;
            flowLayoutPanelPopular.Top -= scrollDirection;
            flowLayoutPanelRating.Top -= scrollDirection;
            flowLayoutPanelHistory.Top -= scrollDirection;
            flowLayoutPanelSearch.Top -= scrollDirection;

            previousScrollValue = scrollValue;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (!SearchBox.Focused && string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                SearchBox.Text = "Search";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search")
            {
                SearchBox.Text = "";
            }
        }

        private void Searсh_Click(object sender, EventArgs e)
        {
            string searchText = SearchBox.Text.Trim();

            flowLayoutPanelSearch.Controls.Clear();

            List<Book> searchResults = SearchBooks(searchText);

            foreach (Book book in searchResults)
            {
                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                UserControlPopularBook searchResultItem = new UserControlPopularBook(this);
                searchResultItem.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                flowLayoutPanelSearch.Controls.Add(searchResultItem);
            }

            if (string.IsNullOrEmpty(searchText) || searchResults.Count == 0)
            {
                flowLayoutPanelSearch.Visible = false;
                flowLayoutPanelHistory.Visible = true;
                flowLayoutPanelRating.Visible = true;
                flowLayoutPanelPopular.Visible = true;
                flowLayoutPanelNew.Visible = true;
                New.Visible = true;
                Popular.Visible = true;
                Rating.Visible = true;
                LastView.Visible = true;
                SearchResult.Visible = false;
            }
            else
            {

                flowLayoutPanelSearch.Visible = true;
                flowLayoutPanelHistory.Visible = false;
                flowLayoutPanelRating.Visible = false;
                flowLayoutPanelPopular.Visible = false;
                flowLayoutPanelNew.Visible = false;
                New.Visible = false;
                Popular.Visible = false;
                Rating.Visible = false;
                LastView.Visible = false;
                SearchResult.Visible = true;
            }
        }


        private List<Book> SearchBooks(string searchText)
        {
            searchText = searchText.ToLower();

            List<Book> searchResults = books
                .Where(book =>
                    book.Title.ToLower().Contains(searchText) ||
                    authorList.Any(author => author.BookID == book.BookID && author.AuthorName.ToLower().Contains(searchText)) ||
                    bookGenresList
                        .Where(relation => relation.GenreName.ToLower().Contains(searchText))
                        .Select(relation => relation.BookID)
                        .Contains(book.BookID)
                )
                .ToList();

            return searchResults;
        }

        public void PopulateBookData()
        {
            Shuffle(books);
            flowLayoutPanelNew.Controls.Clear();
            int totalHeight = 0;
            const int maxBooksToShow = 6;

            for (int i = 0; i < Math.Min(books.Count, maxBooksToShow); i++)
            {
                Book book = books[i];
                if (book.Year >= 2015)
                {
                    BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                    UserControlPopularBook bookControl = new UserControlPopularBook(this);

                    bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);

                    flowLayoutPanelNew.Controls.Add(bookControl);

                    totalHeight += bookControl.Height;
                }
            }
        }

        public void PopularBookData()
        {
            Shuffle(books);
            flowLayoutPanelPopular.Controls.Clear();
            int totalHeight = 0;
            const int maxBooksToShow = 6;
            const int minViews = 15;
            const int minReads = 5;

            foreach (Book book in books.Where(b =>
            {
                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == b.BookID);
                return (bookStat != null && bookStat.ViewCount > minViews && bookStat.ReadsCount > minReads);
            }).Take(maxBooksToShow))
            {

                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                UserControlPopularBook bookControl = new UserControlPopularBook(this);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                flowLayoutPanelPopular.Controls.Add(bookControl);

                totalHeight += bookControl.Height;
            }
        }


        public void RatingBookData()
        {
            Shuffle(books);
            flowLayoutPanelRating.Controls.Clear();
            int totalHeight = 0;
            const int maxBooksToShow = 6;

            foreach (Book book in books.Where(b => Decimal.Compare(b.AverageRating, 4.5m) >= 0).Take(maxBooksToShow))
            {

                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                UserControlPopularBook bookControl = new UserControlPopularBook(this);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                flowLayoutPanelRating.Controls.Add(bookControl);

                totalHeight += bookControl.Height;
            }
        }

        public void PopulateUserHistory()
        {
            List<UserHistoryItem> userHistory = GetUserHistory(Main.user.UserId);
            flowLayoutPanelHistory.Controls.Clear();

            const int maxBooksToShow = 6;
            int booksAdded = 0;

            foreach (UserHistoryItem historyItem in userHistory)
            {
                Book book = books.FirstOrDefault(b => b.BookID == historyItem.BookID);

                if (book != null)
                {
                    BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == historyItem.BookID);

                    UserControlPopularBook historyControlItem = new UserControlPopularBook(this);
                    historyControlItem.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                    flowLayoutPanelHistory.Controls.Add(historyControlItem);

                    booksAdded++;

                    if (booksAdded >= maxBooksToShow)
                    {
                        break;
                    }
                }
            }
        }

        private static void Shuffle<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        private void Main_Scroll(object sender, ScrollEventArgs e)
        {

        }

        public void UpdatePhoto()
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT * FROM Users WHERE Username = @username;";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", user.UserName);
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

            if (user.ProfilePhoto != null)
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

        private void SearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Searсh_Click(sender, e);

                e.Handled = true;
            }
        }
    }
}

