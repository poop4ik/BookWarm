namespace BookWarm.Forms.MainForm
{
    partial class BookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfo));
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Back = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.Label();
            this.ViewCount = new System.Windows.Forms.Label();
            this.ReadsCount = new System.Windows.Forms.Label();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.Year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadBook = new System.Windows.Forms.Label();
            this.ReviewGeneral = new System.Windows.Forms.Label();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.flowLayoutPanelReview = new System.Windows.Forms.FlowLayoutPanel();
            this.BookPng2 = new System.Windows.Forms.PictureBox();
            this.BookPng = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.WriteReview = new System.Windows.Forms.Label();
            this.ReadLater = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPng2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(1160, 9);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 19);
            this.Minimize.TabIndex = 71;
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
            this.AuthenticationPanel.Size = new System.Drawing.Size(1224, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 72;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(4, 0);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 75;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.BackColor = System.Drawing.Color.Silver;
            this.titleText.Font = new System.Drawing.Font("Arial Black", 16F);
            this.titleText.Location = new System.Drawing.Point(453, 111);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(69, 31);
            this.titleText.TabIndex = 75;
            this.titleText.Text = "Title";
            // 
            // authorText
            // 
            this.authorText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorText.Location = new System.Drawing.Point(397, 165);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(84, 17);
            this.authorText.TabIndex = 76;
            this.authorText.Text = "Author";
            this.authorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewCount
            // 
            this.ViewCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewCount.Location = new System.Drawing.Point(461, 251);
            this.ViewCount.Name = "ViewCount";
            this.ViewCount.Size = new System.Drawing.Size(84, 26);
            this.ViewCount.TabIndex = 78;
            this.ViewCount.Text = "View";
            this.ViewCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReadsCount
            // 
            this.ReadsCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadsCount.Location = new System.Drawing.Point(445, 222);
            this.ReadsCount.Name = "ReadsCount";
            this.ReadsCount.Size = new System.Drawing.Size(84, 25);
            this.ReadsCount.TabIndex = 77;
            this.ReadsCount.Text = "Reads";
            this.ReadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genreListBox
            // 
            this.genreListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genreListBox.BackColor = System.Drawing.Color.LightGray;
            this.genreListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genreListBox.Font = new System.Drawing.Font("Arial", 12F);
            this.genreListBox.ItemHeight = 18;
            this.genreListBox.Location = new System.Drawing.Point(410, 284);
            this.genreListBox.MultiColumn = true;
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.genreListBox.Size = new System.Drawing.Size(802, 54);
            this.genreListBox.TabIndex = 200;
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(375, 192);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(84, 25);
            this.Year.TabIndex = 202;
            this.Year.Text = "Year";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label1.Location = new System.Drawing.Point(327, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 203;
            this.label1.Text = "Автор:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label2.Location = new System.Drawing.Point(327, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 27);
            this.label2.TabIndex = 204;
            this.label2.Text = "Рік:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label3.Location = new System.Drawing.Point(336, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 205;
            this.label3.Text = "Прочитано:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label4.Location = new System.Drawing.Point(335, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 27);
            this.label4.TabIndex = 206;
            this.label4.Text = "Переглянуто:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label5.Location = new System.Drawing.Point(332, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 207;
            this.label5.Text = "Жанри:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTitle.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionTitle.Font = new System.Drawing.Font("Arial Black", 12F);
            this.DescriptionTitle.Location = new System.Drawing.Point(555, 363);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(207, 27);
            this.DescriptionTitle.TabIndex = 208;
            this.DescriptionTitle.Text = "DescriptionTitle";
            this.DescriptionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.BackColor = System.Drawing.Color.LightGray;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(340, 430);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(631, 87);
            this.Description.TabIndex = 211;
            this.Description.Text = "Description";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Arial Black", 16F);
            this.label6.Location = new System.Drawing.Point(623, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 31);
            this.label6.TabIndex = 214;
            this.label6.Text = ". . .";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadBook
            // 
            this.ReadBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadBook.BackColor = System.Drawing.Color.Silver;
            this.ReadBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadBook.Font = new System.Drawing.Font("Arial Black", 14F);
            this.ReadBook.Location = new System.Drawing.Point(873, 725);
            this.ReadBook.Name = "ReadBook";
            this.ReadBook.Size = new System.Drawing.Size(192, 31);
            this.ReadBook.TabIndex = 215;
            this.ReadBook.Text = "Читати книгу";
            this.ReadBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReadBook.Click += new System.EventHandler(this.ReadBook_Click);
            // 
            // ReviewGeneral
            // 
            this.ReviewGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewGeneral.BackColor = System.Drawing.Color.Transparent;
            this.ReviewGeneral.Font = new System.Drawing.Font("Arial Black", 12F);
            this.ReviewGeneral.Location = new System.Drawing.Point(555, 597);
            this.ReviewGeneral.Name = "ReviewGeneral";
            this.ReviewGeneral.Size = new System.Drawing.Size(207, 27);
            this.ReviewGeneral.TabIndex = 219;
            this.ReviewGeneral.Text = "Review";
            this.ReviewGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelReview
            // 
            this.flowLayoutPanelReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReview.AutoScroll = true;
            this.flowLayoutPanelReview.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.flowLayoutPanelReview.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.flowLayoutPanelReview.AutoSize = true;
            this.flowLayoutPanelReview.Location = new System.Drawing.Point(393, 646);
            this.flowLayoutPanelReview.MaximumSize = new System.Drawing.Size(0, 310);
            this.flowLayoutPanelReview.MinimumSize = new System.Drawing.Size(710, 52);
            this.flowLayoutPanelReview.Name = "flowLayoutPanelReview";
            this.flowLayoutPanelReview.Size = new System.Drawing.Size(710, 52);
            this.flowLayoutPanelReview.TabIndex = 221;
            // 
            // BookPng2
            // 
            this.BookPng2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookPng2.BackColor = System.Drawing.Color.Transparent;
            this.BookPng2.Image = global::BookWarm.Properties.Resources.book;
            this.BookPng2.Location = new System.Drawing.Point(520, 586);
            this.BookPng2.MaximumSize = new System.Drawing.Size(50, 50);
            this.BookPng2.Name = "BookPng2";
            this.BookPng2.Size = new System.Drawing.Size(50, 50);
            this.BookPng2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPng2.TabIndex = 220;
            this.BookPng2.TabStop = false;
            // 
            // BookPng
            // 
            this.BookPng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookPng.BackColor = System.Drawing.Color.Transparent;
            this.BookPng.Image = global::BookWarm.Properties.Resources.book;
            this.BookPng.Location = new System.Drawing.Point(520, 352);
            this.BookPng.MaximumSize = new System.Drawing.Size(50, 50);
            this.BookPng.Name = "BookPng";
            this.BookPng.Size = new System.Drawing.Size(50, 50);
            this.BookPng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookPng.TabIndex = 218;
            this.BookPng.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox2.Location = new System.Drawing.Point(164, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 456);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 217;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(496, 516);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(311, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 216;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox1.Location = new System.Drawing.Point(1121, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 759);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 213;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox8.Location = new System.Drawing.Point(3, 39);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 759);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 212;
            this.pictureBox8.TabStop = false;
            // 
            // BookImage
            // 
            this.BookImage.Location = new System.Drawing.Point(112, 81);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(210, 260);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImage.TabIndex = 201;
            this.BookImage.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1186, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 74;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.BackColor = System.Drawing.Color.Silver;
            this.Resize.Image = ((System.Drawing.Image)(resources.GetObject("Resize.Image")));
            this.Resize.Location = new System.Drawing.Point(1162, 10);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(20, 20);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 73;
            this.Resize.TabStop = false;
            this.Resize.Visible = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // WriteReview
            // 
            this.WriteReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WriteReview.BackColor = System.Drawing.Color.Silver;
            this.WriteReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WriteReview.Font = new System.Drawing.Font("Arial Black", 14F);
            this.WriteReview.Location = new System.Drawing.Point(334, 725);
            this.WriteReview.Name = "WriteReview";
            this.WriteReview.Size = new System.Drawing.Size(192, 31);
            this.WriteReview.TabIndex = 222;
            this.WriteReview.Text = "Написати відгук";
            this.WriteReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WriteReview.Click += new System.EventHandler(this.WriteReview_Click);
            // 
            // ReadLater
            // 
            this.ReadLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReadLater.BackColor = System.Drawing.Color.Silver;
            this.ReadLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadLater.Font = new System.Drawing.Font("Arial Black", 12F);
            this.ReadLater.Location = new System.Drawing.Point(865, 278);
            this.ReadLater.Name = "ReadLater";
            this.ReadLater.Size = new System.Drawing.Size(192, 31);
            this.ReadLater.TabIndex = 223;
            this.ReadLater.Text = "Відкласти на потім";
            this.ReadLater.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ReadLater.Click += new System.EventHandler(this.ReadLater_Click);
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1224, 792);
            this.Controls.Add(this.ReadLater);
            this.Controls.Add(this.WriteReview);
            this.Controls.Add(this.ReadBook);
            this.Controls.Add(this.BookPng);
            this.Controls.Add(this.flowLayoutPanelReview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookPng2);
            this.Controls.Add(this.ReviewGeneral);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.ViewCount);
            this.Controls.Add(this.ReadsCount);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookImage);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "BookWorm";
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPng2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookPng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label authorText;
        private System.Windows.Forms.Label ViewCount;
        private System.Windows.Forms.Label ReadsCount;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.PictureBox BookImage;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DescriptionTitle;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ReadBook;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox BookPng;
        private System.Windows.Forms.Label ReviewGeneral;
        private System.Windows.Forms.PictureBox BookPng2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReview;
        private System.Windows.Forms.Label WriteReview;
        private System.Windows.Forms.Label ReadLater;
    }
}