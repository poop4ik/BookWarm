using BookWarm.Data.Models;
using BookWarm.Forms.MainForm;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BookWarm.Data.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace BookWarm
{
    public partial class UserControlReview : UserControl
    {
        private Main mainForm;

        public UserControlReview(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void SetData(string username, Image ProfilePhotoObject, DateTime reviewDate, decimal rate, string reviewText)
        {
            // Set username
            Username.Text = username;

            // Set profile photo
            profilePhotoPictureBox.Image = ProfilePhotoObject;

            // Set review date
            DateTime.Text = reviewDate.ToString("dd.MM.yyyy HH:mm");

            int starCount = (int)Math.Round(rate);
            string stars = new string('★', starCount);
            string emptyStars = new string('☆', 5 - starCount);

            Rating.Text = $"{stars}{emptyStars}";

            // Set review text
            ReviewText.Text = reviewText;
        }
    }
}

