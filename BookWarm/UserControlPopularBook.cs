using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class UserControlPopularBook : UserControl
    {
        public UserControlPopularBook()
        {
            InitializeComponent();
        }
        public void SetData(string title, string author, decimal averageRating, int readsCount, int viewCount)
        {
            Title.Text = title;
            Author.Text = author;
            Rating.Text = averageRating.ToString();
            ReadsCount.Text = $"Прочитало: {readsCount}";
            ViewCount.Text = $"Переглянуло: {viewCount}";
        }
    }
}
