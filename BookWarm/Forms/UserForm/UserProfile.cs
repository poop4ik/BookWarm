﻿using BookWarm.Data.Models;
using BookWarm.Forms;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class UserProfile : KryptonForm
    {
        private User user;
        public static UserStatistics userstat;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;
        private Label selectedLabel;

        public UserProfile(string username, Main mainForm)
        {
            InitializeComponent();
            InitializeLabels();

            Resize_Click(this, EventArgs.Empty);

            ChangeInfo.MouseEnter += new EventHandler(ChangeInfo_MouseEnter);
            ChangeInfo.MouseLeave += new EventHandler(ChangeInfo_MouseLeave);

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);

            Logout.MouseEnter += new EventHandler(Logout_MouseEnter);
            Logout.MouseLeave += new EventHandler(Logout_MouseLeave);

            PopulateUserReadsNow();
            flowLayoutPanelReadsNow.Visible = true;

            this.mainForm = mainForm;

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT * FROM Users WHERE Username = @username;";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                UserId = (int)reader["UserID"],
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                UserName = reader["UserName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Age = (int)reader["Age"],
                                PasswordHash = reader["PasswordHash"].ToString(),
                                Description = reader["Description"].ToString(),
                                ProfilePhoto = (reader["ProfilePhoto"] == DBNull.Value ? null : (byte[])reader["ProfilePhoto"])
                            };
                        }
                    }
                }
            }

            if (user != null)
            {
                lblFullName.Text = $"{user.LastName} {user.FirstName}";
                lblUsername.Text = user.UserName;
                lblDescription.Text = user.Description;

                if (user.ProfilePhoto != null)
                {
                    using (MemoryStream ms = new MemoryStream(user.ProfilePhoto))
                    {
                        profilePhotoPictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    profilePhotoPictureBox.Image = Properties.Resources.logo;
                    profilePhotoPictureBox.Border = 0;
                }
            }

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM UserStatistics WHERE UserID = @userID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", user.UserId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userstat = new UserStatistics
                            {
                                StatisticID = (int)reader["StatisticID"],
                                UserID = user.UserId,
                                TotalViews = (int)reader["TotalViews"],
                                TotalReads = (int)reader["TotalReads"]
                            };
                        }
                    }
                }
            }

            if (userstat != null)
            {
                lblTotalRead.Text = $"Прочитано 📕 - {userstat.TotalReads}";
                lblTotalView.Text = $"Переглянуто 👁 - {userstat.TotalViews}";
            }
            else
            {
                lblTotalRead.Text = "Прочитано 📕 - N/A";
                lblTotalView.Text = "Переглянуто 👁 - N/A";
            }
        }

        private void InitializeLabels()
        {
            ReadsNow.Click += Label_Click;
            Reads.Click += Label_Click;
            Preference.Click += Label_Click;
            History.Click += Label_Click;

            ReadsNow.Font = new Font("Arial", 12, FontStyle.Bold);
            selectedLabel = ReadsNow;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            selectedLabel.Font = new Font("Arial", 12, FontStyle.Regular);
            Label clickedLabel = (Label)sender;
            clickedLabel.Font = new Font("Arial Black", 12, FontStyle.Bold);


            selectedLabel = clickedLabel;

            flowLayoutPanelHistory.Visible = false;
            flowLayoutPanelPreference.Visible = false;
            flowLayoutPanelReads.Visible = false;
            flowLayoutPanelReadsNow.Visible = false;

            if (selectedLabel == History)
            {
                flowLayoutPanelHistory.Visible = true;
                PopulateUserHistory();
            }
            else if (selectedLabel == Preference)
            {
                flowLayoutPanelPreference.Visible = true;
                PopulateUserPreference();
            }
            else if (selectedLabel == Reads)
            {
                flowLayoutPanelReads.Visible = true;
                PopulateUserReads();
            }
            else if (selectedLabel == ReadsNow)
            {
                flowLayoutPanelReadsNow.Visible = true;
                PopulateUserReadsNow();
            }
        }

        public void PopulateUserHistory()
        {
            List<UserHistoryItem> userHistory = GetUserHistory(Main.user.UserId);
            flowLayoutPanelHistory.Controls.Clear();

            foreach (UserHistoryItem historyItem in userHistory)
            {

                Book book = Main.books.FirstOrDefault(b => b.BookID == historyItem.BookID);

                if (book != null)
                {
                    BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == historyItem.BookID);

                    UserControlPopularBook historyControlItem = new UserControlPopularBook(mainForm);
                    historyControlItem.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                    flowLayoutPanelHistory.Controls.Add(historyControlItem);
                }
            }
        }

        public void PopulateUserPreference()
        {
            List<UserPreferenceItem> userPreference = GetUserPreference(Main.user.UserId);
            flowLayoutPanelPreference.Controls.Clear();

            foreach (UserPreferenceItem preferenceItem in userPreference)
            {
                Book book = Main.books.FirstOrDefault(b => b.BookID == preferenceItem.BookID);

                if (book != null)
                {
                    BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == preferenceItem.BookID);

                    UserControlPopularBook preferenceControlItem = new UserControlPopularBook(mainForm);
                    preferenceControlItem.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                    flowLayoutPanelPreference.Controls.Add(preferenceControlItem);
                }
            }
        }

        public void PopulateUserReads()
        {
            List<UserReadItem> userReads = GetUserReads(Main.user.UserId);
            flowLayoutPanelReads.Controls.Clear();

            foreach (UserReadItem readsItem in userReads)
            {
                Book book = Main.books.FirstOrDefault(b => b.BookID == readsItem.BookID);

                if (book != null)
                {
                    BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == readsItem.BookID);

                    UserControlPopularBook readsItemControl = new UserControlPopularBook(mainForm);
                    readsItemControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                    flowLayoutPanelReads.Controls.Add(readsItemControl);
                }
            }
        }

        public void PopulateUserReadsNow()
        {
            List<UserReadNowItem> userReadsNow = GetUserReadsNow(Main.user.UserId);
            flowLayoutPanelReadsNow.Controls.Clear();

            foreach (UserReadNowItem readsNowItem in userReadsNow)
            {
                Book book = Main.books.FirstOrDefault(b => b.BookID == readsNowItem.BookID);

                if (book != null)
                {
                    BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == readsNowItem.BookID);

                    UserControlPopularBook readsNowItemControl = new UserControlPopularBook(mainForm);
                    readsNowItemControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                    flowLayoutPanelReadsNow.Controls.Add(readsNowItemControl);
                }
            }
        }


        private List<UserHistoryItem> GetUserHistory(int userID)
        {
            List<UserHistoryItem> userHistory = new List<UserHistoryItem>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT BookID, ViewDate FROM UserHistory WHERE UserID = @UserID ORDER BY ViewDate DESC";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookID = reader.GetInt32(reader.GetOrdinal("BookID"));
                            DateTime viewDate = reader.GetDateTime(reader.GetOrdinal("ViewDate"));

                            userHistory.Add(new UserHistoryItem(bookID, viewDate));
                        }
                    }
                }
            }

            return userHistory;
        }

        public List<UserPreferenceItem> GetUserPreference(int userID)
        {
            List<UserPreferenceItem> userPreferences = new List<UserPreferenceItem>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT PreferenceID, UserID, BookID FROM UserPreference WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int preferenceID = reader.GetInt32(reader.GetOrdinal("PreferenceID"));
                            int bookID = reader.GetInt32(reader.GetOrdinal("BookID"));

                            userPreferences.Add(new UserPreferenceItem(preferenceID, userID, bookID));
                        }
                    }
                }
            }

            return userPreferences;
        }

        public List<UserReadItem> GetUserReads(int userID)
        {
            List<UserReadItem> userReads = new List<UserReadItem>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT UserReadID, UserID, BookID FROM UserRead WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userReadID = reader.GetInt32(reader.GetOrdinal("UserReadID"));
                            int bookID = reader.GetInt32(reader.GetOrdinal("BookID"));

                            userReads.Add(new UserReadItem(userReadID, userID, bookID));
                        }
                    }
                }
            }

            return userReads;
        }

        public List<UserReadNowItem> GetUserReadsNow(int userID)
        {
            List<UserReadNowItem> userReadsNow = new List<UserReadNowItem>();

            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT UserReadNowID, UserID, BookID FROM UserReadNow WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int userReadNowID = reader.GetInt32(reader.GetOrdinal("UserReadNowID"));
                            int bookID = reader.GetInt32(reader.GetOrdinal("BookID"));

                            userReadsNow.Add(new UserReadNowItem(userReadNowID, userID, bookID));
                        }
                    }
                }
            }

            return userReadsNow;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.UpdatePhoto();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Resize_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = originalFormBorderStyle;
                this.Size = originalSize;
                CenterToScreen();
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; 
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                isMaximized = true;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ChangeInfo_MouseEnter(object sender, EventArgs e)
        {
            ChangeInfo.Image = Properties.Resources.gear;
        }

        private void ChangeInfo_MouseLeave(object sender, EventArgs e)
        {
            ChangeInfo.Image = Properties.Resources.gearpng1;
        }

        private void Resize_MouseEnter(object sender, EventArgs e)
        {
            Resize.Image = Properties.Resources.resizegif;
        }

        private void Resize_MouseLeave(object sender, EventArgs e)
        {
            Resize.Image = Properties.Resources.resizepng;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.exitgif;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.Image = Properties.Resources.exit;
        }
        private void ChangeInfo_Click(object sender, EventArgs e)
        {
            ChangeUserInfo changeUserInfo = new ChangeUserInfo(user.UserName, mainForm);
            this.Hide();
            changeUserInfo.ShowDialog();
            this.Close();
        }

        private void Logout_MouseLeave(object sender, EventArgs e)
        {
            Logout.Image = Properties.Resources.exitacc;
        }

        private void Logout_MouseEnter(object sender, EventArgs e)
        {
            Logout.Image = Properties.Resources.exitaccgif;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = string.Empty;
            Properties.Settings.Default.Save();
            Application.Exit();

        }
    }
}
