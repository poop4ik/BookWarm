using BookWarm.Data.Models;
using BookWarm.Forms.MainForm;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BookWarm.Data.Models;


namespace BookWarm
{
    public partial class UserControlPopularBook : UserControl
    {
        private Main mainForm;

        public UserControlPopularBook(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }

        public void SetData(int bookID, Image coverImageObject, string title, decimal averageRating, int readsCount, int viewCount, int authorID, int ageCategory)
        {
            const int maxTitleLength = 16;

            // Обрізати назву книги, якщо вона довша за максимальну довжину
            if (title.Length > maxTitleLength)
            {
                title = title.Substring(0, maxTitleLength) + "...";
            }

            Title.Text = $"«{title}» {ageCategory}+";

            // Find the author with the given authorID
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);
            // Use the AuthorName property directly
            Author.Text = author?.AuthorName ?? "Unknown Author";

            Rating.Text = averageRating.ToString();
            ReadsCount.Text = $"📕 {readsCount}";
            ViewCount.Text = $"👁 {viewCount}";
            BookImage.Image = coverImageObject;

            int userAge = Main.user.Age;

            BookImage.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, ageCategory);
            View.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, ageCategory);
            Author.Click += (sender, e) => OpenAuthorInfoForm(authorID);
        }

        private void UpdateUserHistory(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                // Перевірте наявність запису користувача та книги в історії
                string checkQuery = "SELECT COUNT(*) FROM UserHistory WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserID", userID);
                    checkCommand.Parameters.AddWithValue("@BookID", bookID);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Якщо запис існує, оновіть дату перегляду
                        string updateQuery = "UPDATE UserHistory SET ViewDate = GETDATE() WHERE UserID = @UserID AND BookID = @BookID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@UserID", userID);
                            updateCommand.Parameters.AddWithValue("@BookID", bookID);

                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // Якщо запис не існує, вставте новий запис
                        string insertQuery = "INSERT INTO UserHistory (UserID, BookID, ViewDate) VALUES (@UserID, @BookID, GETDATE())";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@UserID", userID);
                            insertCommand.Parameters.AddWithValue("@BookID", bookID);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }
            }
        }


        private void OpenBookInfoForm(int authorID, int bookID, int ageCategory)
        {
            // Ensure that the User property is accessible from the Main form
            if (Main.user != null)
            {
                int userAge = Main.user.Age;

                // Add your age condition here (e.g., 18 years and older)
                if (userAge >= ageCategory)
                {
                    UpdateUserHistory(Main.user.UserId, bookID);

                    BookInfo bookInfoForm = new BookInfo(authorID, bookID, mainForm);
                    bookInfoForm.ShowDialog();
                    mainForm.PopulateUserHistory();
                }
                else
                {
                    AgeCategory errorAge = new AgeCategory(ageCategory);
                    errorAge.ShowDialog();
                    mainForm.PopulateUserHistory();
                }
            }
            else
            {
                AgeCategory errorAge = new AgeCategory(ageCategory);
                errorAge.ShowDialog();
                mainForm.PopulateUserHistory();
            }
        }


        private void OpenAuthorInfoForm(int authorID)
        {
            AuthorInfo authorInfoForm = new AuthorInfo(authorID, mainForm);
            authorInfoForm.Show();

        }
    }
}
