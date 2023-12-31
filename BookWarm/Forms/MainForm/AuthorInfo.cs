﻿using BookWarm.Data.Models;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm.Forms.MainForm
{
    public partial class AuthorInfo : KryptonForm
    {
        private User user;
        private string author;
        private int authorID;
        private bool isMaximized = false;
        private FormBorderStyle originalFormBorderStyle;
        private Size originalSize;
        private Main mainForm;

        public AuthorInfo(int authorID, Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.authorID = authorID;

            Resize_Click(this, EventArgs.Empty);

            Resize.MouseEnter += new EventHandler(Resize_MouseEnter);
            Resize.MouseLeave += new EventHandler(Resize_MouseLeave);

            Exit.MouseEnter += new EventHandler(Exit_MouseEnter);
            Exit.MouseLeave += new EventHandler(Exit_MouseLeave);

            SetAuthorInfo();

            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            PopulateBooksByAuthor(authorID);
        }


        private void SetAuthorInfo()
        {
            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);

            if (author != null)
            {
                AvarageRatingAuthor.Text = "";
                decimal totalRating = 0;
                int numberOfBooks = 0;

                foreach (Book book in Main.books.Where(b => b.AuthorID == authorID))
                {
                    BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);
                    AvarageRatingAuthor.Text += $"{book.AverageRating}\n";
                    totalRating += book.AverageRating;
                    numberOfBooks++;
                }

                if (numberOfBooks > 0)
                {
                    decimal averageRating = totalRating / numberOfBooks;
                    int starCount = (int)Math.Round(averageRating);

                    string stars = new string('★', starCount);
                    string emptyStars = new string('☆', 5 - starCount);

                    AvarageRatingAuthor.Text = $"{stars}{emptyStars}";
                    numberOfBooksAuthor.Text = $"{numberOfBooks}";
                    AuthorName.Text = author.AuthorName;
                    CountryAuthor.Text = $"{author.Country}";
                    AgeAuthor.Text = $"{author.Age}";
                    AuthorImage.Image = author.AuthorPhotoObject;
                }
            }
        }

        private void PopulateBooksByAuthor(int authorID)
        {
            flowLayoutPanelAuthorBooks.Controls.Clear();

            foreach (Book book in Main.books.Where(b => b.AuthorID == authorID))
            {
                BookStat bookStat = Main.bookStatList.FirstOrDefault(bs => bs.BookID == book.BookID);

                UserControlAuthor bookControl = new UserControlAuthor(mainForm);
                bookControl.SetData(book.BookID, book.CoverImageObject, book.Title, book.AverageRating, bookStat?.ReadsCount ?? 0, bookStat?.ViewCount ?? 0, book.AuthorID, book.AgeCategory);
                flowLayoutPanelAuthorBooks.Controls.Add(bookControl);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
