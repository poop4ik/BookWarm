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

            BookImage.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, userAge, ageCategory);
            View.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, userAge, ageCategory);
            Author.Click += (sender, e) => OpenAuthorInfoForm(authorID);
        }

        private void OpenBookInfoForm(int authorID, int bookID, int userAge, int ageCategory)
        {
            // Додайте вашу умову перевірки віку тут (наприклад, 18 років і старше)
            if (userAge >= ageCategory)
            {
                BookInfo bookInfoForm = new BookInfo(authorID, bookID, mainForm);
                bookInfoForm.Show();
            }
            else
            {
                AgeCategory errorAge = new AgeCategory(ageCategory);
                errorAge.ShowDialog();
            }
        }


        private void OpenAuthorInfoForm(int authorID)
        {
            AuthorInfo authorInfoForm = new AuthorInfo(authorID, mainForm);
            authorInfoForm.Show();

        }
    }
}
