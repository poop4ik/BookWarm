using BookWarm.Data.Models;
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
    public partial class UserControlNewBook : UserControl
    {
        public UserControlNewBook()
        {
            InitializeComponent();
        }

        public void SetData(string title, string author, decimal averageRating)
        {
/*            using (MemoryStream ms = new MemoryStream(imageData))
            {
                Image image = Image.FromStream(ms);
                BookImage.Image = image;
            }*/
            Title.Text = title;
            Author.Text = author;
            Rating.Text = averageRating.ToString();
        }
    }
}
