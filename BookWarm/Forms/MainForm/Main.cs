using BookWarm.Data.Models;
using BookWarm.Forms.MainForm;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm
{
    public partial class Main : KryptonForm
    {
        public static List<Book> books;
        public static List<BookStat> bookStatList;
        public static List<Author> authorList;
        private User user;
        private Size originPhotoSize;
        private Point originPhotoLocation;
        private bool isMaximized = false; // Перевірка стану максимізації
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
                // Якщо ім'я користувача порожнє, перейти до форми аутентифікації
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

                Search.Leave += textBoxSearch_Leave;
                Search.Enter += textBoxSearch_Enter;

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

                if (user != null)
                {

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

                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    // Отримання книг з бази даних
                    string sqlQuery = "SELECT * FROM Books ";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Book book = new Book
                                {
                                    // Отримання даних для кожної книги
                                    BookID = (int)reader["BookID"],
                                    AuthorID = (int)reader["AuthorID"],
                                    Title = reader["Title"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Language = reader["Language"].ToString(),
                                    Year = (int)reader["Year"],
                                    AgeCategory = (int)reader["AgeCategory"],
                                    AverageRating = reader["AverageRating"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["AverageRating"]),
                                    Content = reader["Content"].ToString(),
                                    // Отримання байтового масиву для зображення
                                    CoverImage = (reader["CoverImage"] == DBNull.Value ? null : (byte[])reader["CoverImage"])
                                };

                                // Опціонально: перетворення байтового масиву в об'єкт Image
                                if (book.CoverImage != null)
                                {

                                    // Використання ImageConverter для конвертації байтів у Image
                                    ImageConverter converter = new ImageConverter();
                                    Image img = (Image)converter.ConvertFrom(book.CoverImage);
                                    book.CoverImageObject = img;

                                    books.Add(book);
                                }
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
                                    // Отримання даних для кожного автора
                                    AuthorID = (int)reader["AuthorID"],
                                    BookID = (int)reader["BookID"],
                                    RelationID = (int)reader["RelationID"],
                                    AuthorName = reader["AuthorName"].ToString(),
                                    Country = reader["Country"].ToString(),
                                    Age = (int)reader["Age"],
                                    // Отримання байтового масиву для зображення
                                    AuthorPhoto = (reader["AuthorPhoto"] == DBNull.Value ? null : (byte[])reader["AuthorPhoto"])
                                };

                                // Опціонально: перетворення байтового масиву в об'єкт Image
                                if (author.AuthorPhoto != null)
                                {

                                    // Використання ImageConverter для конвертації байтів у Image
                                    ImageConverter converter = new ImageConverter();
                                    Image img = (Image)converter.ConvertFrom(author.AuthorPhoto);
                                    author.AuthorPhotoObject = img;

                                    authorList.Add(author);
                                }
                            }
                        }
                    }


                    // Отримання даних про прочитані книги з бази даних
                    string readsQuery = "SELECT * FROM BookReads";
                    using (SqlCommand command = new SqlCommand(readsQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int readsCount = (int)reader["ReadsCount"];

                                // Знайдемо книгу в списку книг
                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                // Оновимо об'єкт BookStat
                                if (book != null)
                                {
                                    // Якщо в списку вже існує об'єкт BookStat для цієї книги, оновіть його
                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ReadsCount += readsCount;  // Змінено тут
                                    }
                                    else
                                    {
                                        // Інакше створіть новий об'єкт BookStat
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

                    // Отримання даних про переглядені книги з бази даних
                    string viewsQuery = "SELECT * FROM BookViews";
                    using (SqlCommand command = new SqlCommand(viewsQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int viewCount = (int)reader["ViewCount"];

                                // Знайдемо книгу в списку книг
                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                // Оновимо об'єкт BookStat
                                if (book != null)
                                {
                                    // Якщо в списку вже існує об'єкт BookStat для цієї книги, оновіть його
                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ViewCount += viewCount;  // Змінено тут
                                    }
                                    else
                                    {
                                        // Інакше створіть новий об'єкт BookStat
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

                    // Виклик функції для відображення популярних книг

                    PopularBookData();
                    PopulateBookData();
                    RatingBookData();

                }
            }
        }


        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
/*                // Повертаємо вікно до звичайного розміру
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = originalFormBorderStyle;
                this.Size = originalSize;
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                profilePhotoPictureBox.Size = originPhotoSize; // Збільшння розміру 
                profilePhotoPictureBox.Location = originPhotoLocation;
                Popular.Location = originPopularLocation;
                Rating.Location = originRatingLocation;
                New.Location = originNewLocation;*/
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                Popular.Location = new Point(Popular.Location.X - 5, Popular.Location.Y - 25);
                New.Location = new Point(New.Location.X - 5, New.Location.Y);
                Rating.Location = new Point(Rating.Location.X - 8, Rating.Location.Y - 20);
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
            if (!string.IsNullOrEmpty(user.UserName))
            {
                this.Hide();
                UserProfile userProfile = new UserProfile(user.UserName, this);
                userProfile.ShowDialog();
                this.Show();
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
            Application.Exit();
        }

        private int previousScrollValue = 0;

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int scrollValue = vScrollBar.Value;

            // Визначте напрямок прокрутки
            int scrollDirection = scrollValue - previousScrollValue;

            // Прокрутіть елементи на потрібне значення
            New.Top -= scrollDirection;
            Popular.Top -= scrollDirection;
            Rating.Top -= scrollDirection;
            flowLayoutPanelNew.Top -= scrollDirection;
            flowLayoutPanelPopular.Top -= scrollDirection;
            flowLayoutPanelRating.Top -= scrollDirection;

            // Оновіть попереднє значення прокрутки
            previousScrollValue = scrollValue;
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            // Перевірити, чи текстове поле не має фокусу та чи не введено жодного тексту
            if (!Search.Focused && string.IsNullOrWhiteSpace(Search.Text))
            {
                Search.Text = "Search";
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            // Очистити текст у TextBox при фокусі, тільки якщо він містить "Search"
            if (Search.Text == "Search")
            {
                Search.Text = "";
            }
        }

        private void SeacrhClick_Click(object sender, EventArgs e)
        {
            /*Search.Visible = !Search.Visible;*/
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public void PopulateBookData()
        {
            // Shuffle the books list
            Shuffle(books);
            flowLayoutPanelNew.Controls.Clear();
            // Now, update the vertical scrollbar range based on the content height
            int totalHeight = 0;
            const int maxBooksToShow = 8;

            // Take the first 'maxBooksToShow' books after shuffling
            for (int i = 0; i < Math.Min(books.Count, maxBooksToShow); i++)
            {
                Book book = books[i];
                if (book.Year >= 2023)
                {
                    BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                    UserControlPopularBook bookControl = new UserControlPopularBook(this);
                    // Pass the Author object instead of AuthorName
                    bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID);

                    flowLayoutPanelNew.Controls.Add(bookControl);

                    // Increment the total height based on the height of the added control
                    totalHeight += bookControl.Height;
                }
            }
        }





        public void PopularBookData()
        {
            Shuffle(books);
            flowLayoutPanelPopular.Controls.Clear();
            int totalHeight = 0;
            const int maxBooksToShow = 8;
            const int minViews = 15;
            const int minReads = 5;

            foreach (Book book in books.Where(b =>
            {
                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == b.BookID);
                return (bookStat != null && bookStat.ViewCount > minViews && bookStat.ReadsCount > minReads);
            }).Take(maxBooksToShow))
            {
                // Знайдіть відповідний об'єкт BookStat для цієї книги
                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);
                // Створіть і додайте UserControlPopularBook до flowLayoutPanelPopular
                UserControlPopularBook bookControl = new UserControlPopularBook(this);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID);
                flowLayoutPanelPopular.Controls.Add(bookControl);

                totalHeight += bookControl.Height;
            }
        }


        public void RatingBookData()
        {
            Shuffle(books);
            flowLayoutPanelRating.Controls.Clear();
            int totalHeight = 0;
            const int maxBooksToShow = 8;

            foreach (Book book in books.Where(b => Decimal.Compare(b.AverageRating, 4.5m) >= 0).Take(maxBooksToShow))
            {
                // Знайдіть відповідний об'єкт BookStat для цієї книги
                BookStat bookStat = bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);
                // Створіть і додайте UserControlPopularBook до flowLayoutPanelPopular
                UserControlPopularBook bookControl = new UserControlPopularBook(this);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID);
                flowLayoutPanelRating.Controls.Add(bookControl);

                totalHeight += bookControl.Height;
            }
        }



        // Shuffle method to randomize the order of books
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
    }
}

