﻿using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Main : KryptonForm
    {
        private List<Book> books;
        private List<BookStat> bookStatList;
        private User user;
        private Size originPhotoSize;
        private Point originPhotoLocation;
        private bool isMaximized = false; // Перевірка стану максимізації
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;

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
                List<BookStat> bookStatList = new List<BookStat>();

                Search.Leave += textBoxSearch_Leave;
                Search.Enter += textBoxSearch_Enter;

                originPhotoLocation = profilePhotoPictureBox.Location;
                originPhotoSize = profilePhotoPictureBox.Size;

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
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Language = reader["Language"].ToString(),
                                    Year = (int)reader["Year"],
                                    AgeCategory = (int)reader["AgeCategory"],
                                    AverageRating = (decimal)reader["AverageRating"],
                                    Content = reader["Content"].ToString(),
                                    CoverImage = (reader["CoverImage"] == DBNull.Value ? null : (byte[])reader["CoverImage"])
                                };

                                books.Add(book);
                            }
                        }
                    }
                }

                PopulateBookData();

                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    string sqlQuery = "SELECT BookID, COUNT(*) AS ReadsCount FROM BookReads GROUP BY BookID";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int readsCount = (int)reader["ReadsCount"];

                                // Знайдемо книгу в списку книг
                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                // Якщо книга знайдена, оновіть або створіть об'єкт BookStat
                                if (book != null)
                                {
                                    // Якщо в списку вже існує об'єкт BookStat для цієї книги, оновіть його
                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ReadsCount = readsCount;
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
                }


                using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
                {
                    string sqlQuery = "SELECT BookID, COUNT(*) AS ViewCount FROM BookViews GROUP BY BookID";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int bookID = (int)reader["BookID"];
                                int readsCount = (int)reader["ViewCount"];

                                // Знайдемо книгу в списку книг
                                Book book = books.FirstOrDefault(b => b.BookID == bookID);

                                // Якщо книга знайдена, оновіть або створіть об'єкт BookStat
                                if (book != null)
                                {
                                    // Якщо в списку вже існує об'єкт BookStat для цієї книги, оновіть його
                                    if (bookStatList.Any(bs => bs.BookID == bookID))
                                    {
                                        BookStat bookStat = bookStatList.First(bs => bs.BookID == bookID);
                                        bookStat.ReadsCount = readsCount;
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
                }
                PopularBookData();

            }
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
            if (!string.IsNullOrEmpty(user.UserName))
            {
                this.Hide();
                // Відкриття форми Main
                UserProfile userProfile = new UserProfile(user.UserName);
                userProfile.Show();
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
            flowLayoutPanelNew.Top -= scrollDirection;
            flowLayoutPanelPopular.Top -= scrollDirection;

            // Оновіть попереднє значення прокрутки
            previousScrollValue = scrollValue;
        }


        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            // Очистити текст у TextBox при фокусі
            Search.Text = "";
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Search.Text))
            {
                Search.Text = "Search";
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

        private void PopulateBookData()
        {
            // Shuffle the books list
            Shuffle(books);

            // Now, update the vertical scrollbar range based on the content height
            int totalHeight = 0;
            const int maxBooksToShow = 8;

            // Take the first 'maxBooksToShow' books after shuffling
            for (int i = 0; i < Math.Min(books.Count, maxBooksToShow); i++)
            {
                Book book = books[i];

                if (book.Year >= 2023)
                {
                    UserControlNewBook bookControl = new UserControlNewBook();
                    bookControl.SetData(book.Title, book.Author, book.AverageRating);

                    flowLayoutPanelNew.Controls.Add(bookControl);

                    // Increment the total height based on the height of the added control
                    totalHeight += bookControl.Height;
                }
            }
        }

        private void PopularBookData()
        {
            {
                // Shuffle the books list
                Shuffle(books);

                // Now, update the vertical scrollbar range based on the content height
                int totalHeight = 0;
                const int maxBooksToShow = 8;

                // Take the first 'maxBooksToShow' books after shuffling
                for (int i = 0; i < Math.Min(books.Count, maxBooksToShow); i++)
                {
                    Book book = books[i];

                    if (book.Year >= 2023)
                    {
                        UserControlNewBook bookControl = new UserControlNewBook();
                        bookControl.SetData(book.Title, book.Author, book.AverageRating);

                        flowLayoutPanelPopular.Controls.Add(bookControl);

                        // Increment the total height based on the height of the added control
                        totalHeight += bookControl.Height;
                    }
                }
            }
        }



        // Shuffle method to randomize the order of books
        private static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
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


        private void SetupFlowLayout()
        {
            // Set WrapContents to false
            flowLayoutPanelNew.WrapContents = false;

            // Add controls to the FlowLayoutPanel
            for (int i = 0; i < 10; i++)
            {
                // Add controls with a width that exceeds the FlowLayoutPanel's width
                UserControlNewBook bookControl = new UserControlNewBook();
                flowLayoutPanelNew.Controls.Add(bookControl);
            }
        }

        private void Main_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}

