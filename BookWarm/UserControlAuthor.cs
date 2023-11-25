using BookWarm.Data.Models;
using BookWarm.Forms.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class UserControlAuthor : UserControl
    {
        private Main mainForm;
        public UserControlAuthor(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void SetData(int bookID, Image coverImageObject, string title, decimal averageRating, int readsCount, int viewCount, int authorID)
        {
            const int maxTitleLength = 16;

            // Обрізати назву книги, якщо вона довша за максимальну довжину
            if (title.Length > maxTitleLength)
            {
                title = title.Substring(0, maxTitleLength) + "...";
            }

            // Ваш код для використання title, author, averageRating, readsCount, viewCount і coverImage
            Title.Text = $"«{title}»";

            // Find the author with the given authorID
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);
            // Use the AuthorName property directly
            Author.Text = author?.AuthorName ?? "Unknown Author";

            Rating.Text = averageRating.ToString();
            ReadsCount.Text = $"📕 {readsCount}";
            ViewCount.Text = $"👁 {viewCount}";
            BookImage.Image = coverImageObject;

            BookImage.Click += (sender, e) => OpenBookInfoForm(authorID, bookID);
            View.Click += (sender, e) => OpenBookInfoForm(authorID, bookID);
        }

        private void OpenBookInfoForm(int authorID, int bookID)
        {
            BookInfo bookInfoForm = new BookInfo(authorID, bookID, mainForm);
            bookInfoForm.Show();
        }
    }
}
