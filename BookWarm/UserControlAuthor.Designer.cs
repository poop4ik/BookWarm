namespace BookWarm
{
    partial class UserControlAuthor
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
            this.Title = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.View = new System.Windows.Forms.Label();
            this.ViewCount = new System.Windows.Forms.Label();
            this.ReadsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(-17, 163);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(250, 19);
            this.Title.TabIndex = 1;
            this.Title.Text = "Titile";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(-17, 186);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(250, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            this.Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rating
            // 
            this.Rating.Location = new System.Drawing.Point(-17, 206);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(250, 13);
            this.Rating.TabIndex = 3;
            this.Rating.Text = "Rating";
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.star;
            this.pictureBox1.Location = new System.Drawing.Point(122, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BookImage
            // 
            this.BookImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookImage.Location = new System.Drawing.Point(49, 1);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(120, 160);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImage.TabIndex = 0;
            this.BookImage.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(17, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold);
            this.View.Location = new System.Drawing.Point(33, 244);
            this.View.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(155, 30);
            this.View.TabIndex = 52;
            this.View.Text = "Переглянути";
            this.View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewCount
            // 
            this.ViewCount.Location = new System.Drawing.Point(65, 223);
            this.ViewCount.Name = "ViewCount";
            this.ViewCount.Size = new System.Drawing.Size(45, 13);
            this.ViewCount.TabIndex = 54;
            this.ViewCount.Text = "View";
            this.ViewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadsCount
            // 
            this.ReadsCount.Location = new System.Drawing.Point(108, 223);
            this.ReadsCount.Name = "ReadsCount";
            this.ReadsCount.Size = new System.Drawing.Size(41, 13);
            this.ReadsCount.TabIndex = 53;
            this.ReadsCount.Text = "Reads";
            this.ReadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewCount);
            this.Controls.Add(this.ReadsCount);
            this.Controls.Add(this.View);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BookImage);
            this.Controls.Add(this.pictureBox3);
            this.Name = "UserControlAuthor";
            this.Size = new System.Drawing.Size(225, 273);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label View;
        private System.Windows.Forms.Label ViewCount;
        private System.Windows.Forms.Label ReadsCount;
    }
}
