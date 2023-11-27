using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Check if the book is found
            if (book != null)
            {
                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == bookID);

                // Check if BookStat is found
                if (bookStat != null)
                {
                    titleText.Text = $"Книга: «{book.Title}» — {author?.AuthorName ?? "Unknown Author"}";
                    ReadsCount.Text = $"📕 {bookStat.ReadsCount}";
                    ViewCount.Text = $"👁 {bookStat.ViewCount}";
                    BookImage.Image = book.CoverImageObject;

                    // Відобразити RTF-контент в існуючому RichTextBox
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
                    // Завантажити RTF-контент в існуючий RichTextBox (BookContent)
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
                // Повертаємо вікно до звичайного розміру
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = originalFormBorderStyle;
                this.Size = originalSize;
                CenterToScreen(); // Розміщуємо вікно в центрі екрану
                isMaximized = false;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                originalFormBorderStyle = this.FormBorderStyle;
                originalSize = this.Size;
                this.FormBorderStyle = FormBorderStyle.None; // Видаляємо рамку вікна (опціонально)
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;

                isMaximized = true;
            }
        }

        private void Download_Click(object sender, EventArgs e)
        {
            // Отримати RTF-контент з RichTextBox (BookContent)
            byte[] rtfContent = GetRTFContent(BookContent);
            if (rtfContent != null)
            {
                // Зберегти RTF-контент у файл
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "RTF Files (*.rtf)|*.rtf";
                saveFileDialog.FileName = $"{book.Title}.rtf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Записати RTF-контент у файл
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
                string sqlQuery = "INSERT INTO [dbo].[UserReadNow] (UserID, BookID) VALUES (@UserID, @BookID)";

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
                // Зберегти RTF-контент в MemoryStream
                richTextBox.SaveFile(ms, RichTextBoxStreamType.RichText);
                return ms.ToArray();
            }
        }

        private void EndRead_Click(object sender, EventArgs e)
        {
            int userID = Main.user.UserId;

            // Перевірка, чи користувач читає цю книгу
            if (IsUserReadingBook(userID, bookID))
            {
                // Видалення книги з UserReadNow
                RemoveUserReadNowRecord(userID, bookID);

                // Перевірка, чи користувач вже завершив читати цю книгу
                if (!IsUserReadBook(userID, bookID))
                {
                    // Якщо користувач ще не завершив читати книгу, вставте запис в UserRead
                    AddUserReadRecord(userID, bookID);
                }
            }
            this.Close();
        }
    }
}

 
