using BookWarm.Forms.MainForm;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        public void SetData(int bookID, Image coverImageObject, string title, string author, decimal averageRating, int readsCount, int viewCount)
        {
            const int maxTitleLength = 16;

            // Обрізати назву книги, якщо вона довша за максимальну довжину
            if (title.Length > maxTitleLength)
            {
                title = title.Substring(0, maxTitleLength) + "...";
            }

            // Ваш код для використання title, author, averageRating, readsCount, viewCount і coverImage
            Title.Text = title;
            Author.Text = author;
            Rating.Text = averageRating.ToString();
            ReadsCount.Text = $"📕 {readsCount}";
            ViewCount.Text = $"👁 {viewCount}";
            BookImage.Image = coverImageObject;

            BookImage.Click += (sender, e) => OpenBookInfoForm(bookID);
            View.Click += (sender, e) => OpenBookInfoForm(bookID);
        }

        private void OpenBookInfoForm(int bookID)
        {
            BookInfo bookInfoForm = new BookInfo(bookID, mainForm);
            bookInfoForm.Show();
            mainForm.WindowState = FormWindowState.Minimized;
        }
    }
}
