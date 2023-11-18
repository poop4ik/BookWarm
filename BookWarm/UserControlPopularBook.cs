using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class UserControlPopularBook : UserControl
    {
        public UserControlPopularBook()
        {
            InitializeComponent();
        }

        public void SetData(Image coverImageObject, string title, string author, decimal averageRating, int readsCount, int viewCount)
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
        }

    }
}
