using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class BookRead : KryptonForm
    {
        private User user;
        private Book book;
        private int bookID;
        private int authorID;
        private Main mainForm;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;

        public BookRead(int bookID, Main mainForm, int authorID)
        {
            InitializeComponent();
            this.authorID = authorID;
            this.bookID = bookID;
            this.mainForm = mainForm;
            Resize_Click(this, EventArgs.Empty);
            SetBookInfo();
        }

        private void SetBookInfo()
        {

            book = Main.books.FirstOrDefault(b => b.BookID == bookID);
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            if (book != null)
            {
                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);

                if (bookStat != null)
                {
                    titleText.Text = $"Книга: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"}";
                    ReadsCount.Text = $"📕 {bookStat.ReadsCount}";
                    ViewCount.Text = $"👁 {bookStat.ViewCount}";
                    BookWorm.Image = book.CoverImageObject;

                    DisplayRTFContent(book.Content);
                }
            }
        }

        private void DisplayRTFContent(byte[] rtfContent)
        {
            if (rtfContent != null)
            {
                using (MemoryStream ms = new MemoryStream(rtfContent))
                {
                    BookContent.LoadFile(ms, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void Download_Click(object sender, EventArgs e)
        {
            byte[] rtfContent = GetRTFContent(BookContent);
            if (rtfContent != null)
            book = Main.books.FirstOrDefault(b => b.BookID == bookID);
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf";
                saveFileDialog.FileName = $"{author?.AuthorName ?? "Unknown Author"} - {book.Title}.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    File.WriteAllBytes(filePath, rtfContent);

                    MessageBox.Show($"Файл {filePath} був успішно збережений.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RemoveUserReadNowRecord(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "DELETE FROM [dbo].[UserReadNow] WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private bool IsUserReadBook(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT COUNT(*) FROM [dbo].[UserRead] WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void AddUserReadRecord(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "INSERT INTO [dbo].[UserRead] (UserID, BookID) VALUES (@UserID, @BookID)";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool IsUserReadingBook(int userID, int bookID)
        {
            using (SqlConnection connection = new SqlConnection(AppSettings.ConnectionString))
            {
                string sqlQuery = "SELECT COUNT(*) FROM [dbo].[UserReadNow] WHERE UserID = @UserID AND BookID = @BookID";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        private byte[] GetRTFContent(RichTextBox richTextBox)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                richTextBox.SaveFile(ms, RichTextBoxStreamType.RichText);
                return ms.ToArray();
            }
        }

        private void EndRead_Click(object sender, EventArgs e)
        {
            int userID = Main.user.UserId;

            if (IsUserReadingBook(userID, bookID))
            {
                RemoveUserReadNowRecord(userID, bookID);
                AddUserReadRecord(userID, bookID);
            }
            this.Close();
        }
    }
}

 
