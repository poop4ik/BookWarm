namespace BookWarm.Forms.MainForm
{
    partial class AuthorInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorInfo));
            this.CountryAuthor = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.AuthorImage = new System.Windows.Forms.PictureBox();
            this.AgeAuthor = new System.Windows.Forms.Label();
            this.AuthorBooks = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelAuthorBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.AvarageRatingAuthor = new System.Windows.Forms.Label();
            this.numberOfBooksAuthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryAuthor
            // 
            this.CountryAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CountryAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.CountryAuthor.Location = new System.Drawing.Point(336, 305);
            this.CountryAuthor.Name = "CountryAuthor";
            this.CountryAuthor.Size = new System.Drawing.Size(57, 16);
            this.CountryAuthor.TabIndex = 0;
            this.CountryAuthor.Text = "Country";
            this.CountryAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorName
            // 
            this.AuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorName.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorName.Location = new System.Drawing.Point(306, 256);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(120, 23);
            this.AuthorName.TabIndex = 1;
            this.AuthorName.Text = "AuthorName";
            this.AuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(4, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 75;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Image = global::BookWarm.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(712, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 78;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.BackColor = System.Drawing.Color.Silver;
            this.Resize.Image = global::BookWarm.Properties.Resources.resize;
            this.Resize.Location = new System.Drawing.Point(688, 11);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(20, 20);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 77;
            this.Resize.TabStop = false;
            this.Resize.Visible = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(686, 9);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 19);
            this.Minimize.TabIndex = 75;
            this.Minimize.Text = "—";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.AutoSize = true;
            this.AuthenticationPanel.Controls.Add(this.Back);
            this.AuthenticationPanel.Location = new System.Drawing.Point(0, -2);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(750, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 76;
            // 
            // AuthorImage
            // 
            this.AuthorImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorImage.Location = new System.Drawing.Point(280, 53);
            this.AuthorImage.Name = "AuthorImage";
            this.AuthorImage.Size = new System.Drawing.Size(166, 196);
            this.AuthorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AuthorImage.TabIndex = 79;
            this.AuthorImage.TabStop = false;
            // 
            // AgeAuthor
            // 
            this.AgeAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.AgeAuthor.Location = new System.Drawing.Point(348, 282);
            this.AgeAuthor.Name = "AgeAuthor";
            this.AgeAuthor.Size = new System.Drawing.Size(32, 16);
            this.AgeAuthor.TabIndex = 80;
            this.AgeAuthor.Text = "Age";
            this.AgeAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorBooks
            // 
            this.AuthorBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorBooks.BackColor = System.Drawing.Color.Transparent;
            this.AuthorBooks.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold);
            this.AuthorBooks.Location = new System.Drawing.Point(269, 412);
            this.AuthorBooks.Name = "AuthorBooks";
            this.AuthorBooks.Size = new System.Drawing.Size(181, 31);
            this.AuthorBooks.TabIndex = 81;
            this.AuthorBooks.Text = "Книги автора";
            this.AuthorBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox8.Location = new System.Drawing.Point(3, 39);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 455);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 82;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox1.Location = new System.Drawing.Point(647, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelAuthorBooks
            // 
            this.flowLayoutPanelAuthorBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAuthorBooks.AutoScroll = true;
            this.flowLayoutPanelAuthorBooks.AutoSize = true;
            this.flowLayoutPanelAuthorBooks.Location = new System.Drawing.Point(134, 464);
            this.flowLayoutPanelAuthorBooks.MaximumSize = new System.Drawing.Size(0, 620);
            this.flowLayoutPanelAuthorBooks.MinimumSize = new System.Drawing.Size(560, 52);
            this.flowLayoutPanelAuthorBooks.Name = "flowLayoutPanelAuthorBooks";
            this.flowLayoutPanelAuthorBooks.Size = new System.Drawing.Size(560, 52);
            this.flowLayoutPanelAuthorBooks.TabIndex = 84;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox3.Location = new System.Drawing.Point(464, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 349);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox4.Location = new System.Drawing.Point(154, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 349);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            // 
            // AvarageRatingAuthor
            // 
            this.AvarageRatingAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvarageRatingAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.AvarageRatingAuthor.Location = new System.Drawing.Point(294, 354);
            this.AvarageRatingAuthor.Name = "AvarageRatingAuthor";
            this.AvarageRatingAuthor.Size = new System.Drawing.Size(143, 16);
            this.AvarageRatingAuthor.TabIndex = 88;
            this.AvarageRatingAuthor.Text = "AvarageRatingAuthor";
            this.AvarageRatingAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numberOfBooksAuthor
            // 
            this.numberOfBooksAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberOfBooksAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.numberOfBooksAuthor.Location = new System.Drawing.Point(280, 329);
            this.numberOfBooksAuthor.Name = "numberOfBooksAuthor";
            this.numberOfBooksAuthor.Size = new System.Drawing.Size(166, 16);
            this.numberOfBooksAuthor.TabIndex = 89;
            this.numberOfBooksAuthor.Text = "NumberOfBooksAuthor";
            this.numberOfBooksAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.AvarageRatingAuthor);
            this.Controls.Add(this.AuthorBooks);
            this.Controls.Add(this.flowLayoutPanelAuthorBooks);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.AgeAuthor);
            this.Controls.Add(this.AuthorImage);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.CountryAuthor);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.numberOfBooksAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "AuthorInfo";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountryAuthor;
        private System.Windows.Forms.Label AuthorName;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.PictureBox AuthorImage;
        private System.Windows.Forms.Label AgeAuthor;
        private System.Windows.Forms.Label AuthorBooks;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAuthorBooks;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label AvarageRatingAuthor;
        private System.Windows.Forms.Label numberOfBooksAuthor;
    }
}