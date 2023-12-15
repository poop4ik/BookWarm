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

            if (title.Length > maxTitleLength)
            {
                title = title.Substring(0, maxTitleLength) + "...";
            }

            Title.Text = $"«{title}» {ageCategory}+";

            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

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

                string checkQuery = "SELECT COUNT(*) FROM UserHistory WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@UserID", userID);
                    checkCommand.Parameters.AddWithValue("@BookID", bookID);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
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
            if (Main.user != null)
            {
                int userAge = Main.user.Age;

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
