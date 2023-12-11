namespace BookWarm
{
    partial class UserControlPopularBook
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Author = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Rating = new System.Windows.Forms.Label();
            this.ReadsCount = new System.Windows.Forms.Label();
            this.ViewCount = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Author.ForeColor = System.Drawing.Color.Blue;
            this.Author.Location = new System.Drawing.Point(-23, 229);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(333, 16);
            this.Author.TabIndex = 46;
            this.Author.Text = "Author";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(-23, 202);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(333, 23);
            this.Title.TabIndex = 45;
            this.Title.Text = "Titile";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(-23, 254);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(333, 16);
            this.Rating.TabIndex = 47;
            this.Rating.Text = "Rating";
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadsCount
            // 
            this.ReadsCount.Location = new System.Drawing.Point(144, 279);
            this.ReadsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadsCount.Name = "ReadsCount";
            this.ReadsCount.Size = new System.Drawing.Size(55, 16);
            this.ReadsCount.TabIndex = 51;
            this.ReadsCount.Text = "Reads";
            this.ReadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewCount
            // 
            this.ViewCount.Location = new System.Drawing.Point(87, 279);
            this.ViewCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewCount.Name = "ViewCount";
            this.ViewCount.Size = new System.Drawing.Size(60, 16);
            this.ViewCount.TabIndex = 52;
            this.ViewCount.Text = "View";
            this.ViewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.Transparent;
            this.View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.View.Location = new System.Drawing.Point(44, 300);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(207, 37);
            this.View.TabIndex = 53;
            this.View.Text = "Переглянути";
            this.View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(163, 252);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // BookImage
            // 
            this.BookImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookImage.Image = global::BookWarm.Properties.Resources.book;
            this.BookImage.Location = new System.Drawing.Point(65, 1);
            this.BookImage.Margin = new System.Windows.Forms.Padding(4);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(160, 197);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BookImage.TabIndex = 44;
            this.BookImage.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(23, 272);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // UserControlPopularBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewCount);
            this.Controls.Add(this.View);
            this.Controls.Add(this.ReadsCount);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BookImage);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlPopularBook";
            this.Size = new System.Drawing.Size(300, 345);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Title;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label ReadsCount;
        private System.Windows.Forms.Label ViewCount;
        private System.Windows.Forms.Label View;
    }
}
