﻿using BookWarm.Data.Models;
using BookWarm.Forms.MainForm;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm
{
    public partial class UserControlAuthor : UserControl
    {
        private Main mainForm;

        public UserControlAuthor(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void SetData(int bookID, Image coverImageObject, string title, decimal averageRating, int readsCount, int viewCount, int authorID, int ageCategory)
        {
            const int maxTitleLength = 16;

            if (title.Length > maxTitleLength)
            {
                title = title.Substring(0, maxTitleLength) + "...";
            }

            Title.Text = $"«{title}» {ageCategory}+";

            Author author = Main.authorList.FirstOrDefault(a => a.AuthorID == authorID);
            Author.Text = author?.AuthorName ?? "Unknown Author";

            Rating.Text = averageRating.ToString();
            ReadsCount.Text = $"📕 {readsCount}";
            ViewCount.Text = $"👁 {viewCount}";
            BookImage.Image = coverImageObject;

            int userAge = Main.user.Age;

            BookImage.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, userAge, ageCategory);
            View.Click += (sender, e) => OpenBookInfoForm(authorID, bookID, userAge, ageCategory);
        }

        private void OpenBookInfoForm(int authorID, int bookID, int userAge, int ageCategory)
        {
            if (userAge >= ageCategory)
            {
                BookInfo bookInfoForm = new BookInfo(authorID, bookID, mainForm);
                bookInfoForm.ShowDialog();
                mainForm.PopulateUserHistory();
            }
            else
            {
                AgeCategory errorAge = new AgeCategory(ageCategory);
                errorAge.ShowDialog();
                mainForm.PopulateUserHistory();
            }
        }
    }
}
