﻿using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;

namespace BookWarm.Forms.ToolForm
{
    public partial class BookWorm : KryptonForm
    {
        private User user;
        private Main mainForm;
        private int bookID;
        private int UserID;

        public BookWorm(int bookID, Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.bookID = bookID;
            UserID = Main.user.UserId;
            SetInfo();

            ReviewText.Leave += textReviewText_Leave;
            ReviewText.Enter += textReviewText_Enter;


            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);
        }

        private void SendReview_Click(object sender, EventArgs e)
        {
            int userID = UserID;
            int bookID = this.bookID;
            string reviewText = ReviewText.Text;
            decimal rate = ChooseRating.Value;

            if (rate > 5)
            {
                rate = 0; 
            }

            DateTime reviewDate = DateTime.Now;

            string sqlQuery = "INSERT INTO UserReviews (UserID, BookID, ReviewText, ReviewDate, Rate) VALUES (@UserID, @BookID, @ReviewText, @ReviewDate, @Rate)";

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);
                    command.Parameters.AddWithValue("@ReviewText", reviewText);
                    command.Parameters.AddWithValue("@ReviewDate", reviewDate);
                    command.Parameters.AddWithValue("@Rate", rate);

                    command.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        public Image GetProfilePhoto(string username)
        {
            Image profilePhoto = null;

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string query = "SELECT ProfilePhoto FROM Users WHERE UserName = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        byte[] photoBytes = (byte[])result;

                        ImageConverter converter = new ImageConverter();
                        Image img = (Image)converter.ConvertFrom(photoBytes);
                        profilePhoto = img;
                    }
                }
            }

            return profilePhoto;
        }


        public void SetInfo()
        {
            StarRate.Text = "☆☆☆☆☆";
            Username.Text = Main.user.UserName;

            Image profilePhoto = GetProfilePhoto(Main.user.UserName);

            if (profilePhoto != null)
            {
                profilePhotoPictureBox.Image = profilePhoto;
                Main.user.ProfilePhotoObject = profilePhoto;
            }
            else
            {
                profilePhotoPictureBox.Image = Properties.Resources.logo;
            }
        }


        private void ChooseRating_ValueChanged(object sender, EventArgs e)
        {
            int starCount = (int)Math.Round(ChooseRating.Value);

            if (starCount > 5)
            {
                starCount = 0;
                ChooseRating.Value = 0; 
            }

            StarRate.Text = new string('★', starCount) + new string('☆', 5 - starCount);
        }

        private void textReviewText_Leave(object sender, EventArgs e)
        {
            if (!ReviewText.Focused && string.IsNullOrWhiteSpace(ReviewText.Text))
            {
                ReviewText.Text = "Напишіть відгук . . .";
            }
        }

        private void textReviewText_Enter(object sender, EventArgs e)
        {
            if (ReviewText.Text == "Напишіть відгук . . .")
            {
                ReviewText.Text = "";
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.exitgif;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.exit;
        }
    }
}
