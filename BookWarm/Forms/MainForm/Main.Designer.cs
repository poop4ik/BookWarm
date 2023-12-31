﻿namespace BookWarm
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.SearchBox = new Krypton.Toolkit.KryptonTextBox();
            this.flowLayoutPanelNew = new System.Windows.Forms.FlowLayoutPanel();
            this.New = new System.Windows.Forms.Label();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.flowLayoutPanelPopular = new System.Windows.Forms.FlowLayoutPanel();
            this.SeacrhClick = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.LineLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.Popular = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.flowLayoutPanelRating = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.LastView = new System.Windows.Forms.Label();
            this.flowLayoutPanelHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchResult = new System.Windows.Forms.Label();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeacrhClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(684, 9);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 19);
            this.Minimize.TabIndex = 62;
            this.Minimize.Text = "—";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.AutoSize = true;
            this.AuthenticationPanel.Controls.Add(this.Resize);
            this.AuthenticationPanel.Location = new System.Drawing.Point(0, -2);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(1052, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 63;
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.BackColor = System.Drawing.Color.Silver;
            this.Resize.Image = ((System.Drawing.Image)(resources.GetObject("Resize.Image")));
            this.Resize.Location = new System.Drawing.Point(989, 11);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(20, 20);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 69;
            this.Resize.TabStop = false;
            this.Resize.Visible = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Location = new System.Drawing.Point(244, 45);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SearchBox.Size = new System.Drawing.Size(262, 27);
            this.SearchBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SearchBox.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.SearchBox.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.SearchBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SearchBox.StateCommon.Border.Rounding = 7F;
            this.SearchBox.TabIndex = 100;
            this.SearchBox.Text = "Search";
            this.SearchBox.UseMnemonic = false;
            this.SearchBox.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // flowLayoutPanelNew
            // 
            this.flowLayoutPanelNew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelNew.AutoSize = true;
            this.flowLayoutPanelNew.Location = new System.Drawing.Point(77, 124);
            this.flowLayoutPanelNew.MaximumSize = new System.Drawing.Size(0, 284);
            this.flowLayoutPanelNew.MinimumSize = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelNew.Name = "flowLayoutPanelNew";
            this.flowLayoutPanelNew.Size = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelNew.TabIndex = 74;
            // 
            // New
            // 
            this.New.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.New.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.New.Location = new System.Drawing.Point(239, 73);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(267, 29);
            this.New.TabIndex = 75;
            this.New.Text = "Новинки";
            this.New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar.LargeChange = 80;
            this.vScrollBar.Location = new System.Drawing.Point(740, 41);
            this.vScrollBar.Maximum = 820;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(10, 859);
            this.vScrollBar.SmallChange = 40;
            this.vScrollBar.TabIndex = 76;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // flowLayoutPanelPopular
            // 
            this.flowLayoutPanelPopular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPopular.AutoSize = true;
            this.flowLayoutPanelPopular.Location = new System.Drawing.Point(77, 518);
            this.flowLayoutPanelPopular.MaximumSize = new System.Drawing.Size(0, 284);
            this.flowLayoutPanelPopular.MinimumSize = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelPopular.Name = "flowLayoutPanelPopular";
            this.flowLayoutPanelPopular.Size = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelPopular.TabIndex = 78;
            // 
            // SeacrhClick
            // 
            this.SeacrhClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeacrhClick.BackColor = System.Drawing.Color.Transparent;
            this.SeacrhClick.Image = ((System.Drawing.Image)(resources.GetObject("SeacrhClick.Image")));
            this.SeacrhClick.Location = new System.Drawing.Point(508, 44);
            this.SeacrhClick.Name = "SeacrhClick";
            this.SeacrhClick.Size = new System.Drawing.Size(21, 28);
            this.SeacrhClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SeacrhClick.TabIndex = 73;
            this.SeacrhClick.TabStop = false;
            this.SeacrhClick.Click += new System.EventHandler(this.Searсh_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(709, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 70;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LineLogo
            // 
            this.LineLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineLogo.BackColor = System.Drawing.Color.Transparent;
            this.LineLogo.Image = ((System.Drawing.Image)(resources.GetObject("LineLogo.Image")));
            this.LineLogo.Location = new System.Drawing.Point(-16, 814);
            this.LineLogo.Name = "LineLogo";
            this.LineLogo.Size = new System.Drawing.Size(782, 81);
            this.LineLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineLogo.TabIndex = 56;
            this.LineLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 77);
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // bookWarmDBDataSet
            // 
            this.bookWarmDBDataSet.DataSetName = "BookWarmDBDataSet";
            this.bookWarmDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.bookWarmDBDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorBookRelationTableAdapter = null;
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookReadsTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.BookViewsTableAdapter = null;
            this.tableAdapterManager.GenreBookRelationTableAdapter = null;
            this.tableAdapterManager.GenresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserHistoryTableAdapter = null;
            this.tableAdapterManager.UserPreferenceTableAdapter = null;
            this.tableAdapterManager.UserReadNowTableAdapter = null;
            this.tableAdapterManager.UserReadTableAdapter = null;
            this.tableAdapterManager.UserReviewsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.UserStatisticsTableAdapter = null;
            // 
            // Popular
            // 
            this.Popular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Popular.BackColor = System.Drawing.Color.Transparent;
            this.Popular.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.Popular.Location = new System.Drawing.Point(239, 481);
            this.Popular.Name = "Popular";
            this.Popular.Size = new System.Drawing.Size(267, 40);
            this.Popular.TabIndex = 77;
            this.Popular.Text = "Популярні";
            this.Popular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rating
            // 
            this.Rating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Rating.BackColor = System.Drawing.Color.Transparent;
            this.Rating.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.Rating.Location = new System.Drawing.Point(239, 845);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(267, 29);
            this.Rating.TabIndex = 80;
            this.Rating.Text = "Рейтингові";
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelRating
            // 
            this.flowLayoutPanelRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelRating.AutoSize = true;
            this.flowLayoutPanelRating.Location = new System.Drawing.Point(77, 880);
            this.flowLayoutPanelRating.MaximumSize = new System.Drawing.Size(0, 284);
            this.flowLayoutPanelRating.MinimumSize = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelRating.Name = "flowLayoutPanelRating";
            this.flowLayoutPanelRating.Size = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelRating.TabIndex = 81;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox2.Location = new System.Drawing.Point(673, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 876);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 216;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox8.Location = new System.Drawing.Point(-26, 31);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 862);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 215;
            this.pictureBox8.TabStop = false;
            // 
            // LastView
            // 
            this.LastView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastView.BackColor = System.Drawing.Color.Transparent;
            this.LastView.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.LastView.Location = new System.Drawing.Point(239, 1190);
            this.LastView.Name = "LastView";
            this.LastView.Size = new System.Drawing.Size(267, 29);
            this.LastView.TabIndex = 217;
            this.LastView.Text = "Нещодавно переглянуті";
            this.LastView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelHistory
            // 
            this.flowLayoutPanelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelHistory.AutoSize = true;
            this.flowLayoutPanelHistory.Location = new System.Drawing.Point(77, 1250);
            this.flowLayoutPanelHistory.MaximumSize = new System.Drawing.Size(0, 284);
            this.flowLayoutPanelHistory.MinimumSize = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            this.flowLayoutPanelHistory.Size = new System.Drawing.Size(600, 52);
            this.flowLayoutPanelHistory.TabIndex = 218;
            // 
            // flowLayoutPanelSearch
            // 
            this.flowLayoutPanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelSearch.AutoScroll = true;
            this.flowLayoutPanelSearch.AutoSize = true;
            this.flowLayoutPanelSearch.Location = new System.Drawing.Point(80, 124);
            this.flowLayoutPanelSearch.MaximumSize = new System.Drawing.Size(0, 1422);
            this.flowLayoutPanelSearch.MinimumSize = new System.Drawing.Size(750, 52);
            this.flowLayoutPanelSearch.Name = "flowLayoutPanelSearch";
            this.flowLayoutPanelSearch.Size = new System.Drawing.Size(750, 284);
            this.flowLayoutPanelSearch.TabIndex = 219;
            this.flowLayoutPanelSearch.Visible = false;
            // 
            // SearchResult
            // 
            this.SearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResult.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.SearchResult.Location = new System.Drawing.Point(239, 76);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(267, 45);
            this.SearchResult.TabIndex = 220;
            this.SearchResult.Text = "Результати пошуку";
            this.SearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SearchResult.Visible = false;
            // 
            // profilePhotoPictureBox
            // 
            this.profilePhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.profilePhotoPictureBox.Border = 0;
            this.profilePhotoPictureBox.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePhotoPictureBox.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePhotoPictureBox.ColorBorder = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.ColorBorder2 = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.Gradiant = 50F;
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(352, 831);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(45, 45);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 61;
            this.profilePhotoPictureBox.TabStop = false;
            this.profilePhotoPictureBox.Click += new System.EventHandler(this.profilePhotoPictureBox_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(-100, -100);
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 894);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.SeacrhClick);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Popular);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.flowLayoutPanelSearch);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.LineLogo);
            this.Controls.Add(this.LastView);
            this.Controls.Add(this.flowLayoutPanelHistory);
            this.Controls.Add(this.New);
            this.Controls.Add(this.flowLayoutPanelNew);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.flowLayoutPanelPopular);
            this.Controls.Add(this.flowLayoutPanelRating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 845);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "BookWorm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Main_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeacrhClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox LineLogo;
        private BookWarmDBDataSet bookWarmDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BookWarmDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BookWarmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.PictureBox Exit;
        private Krypton.Toolkit.KryptonTextBox SearchBox;
        private System.Windows.Forms.PictureBox SeacrhClick;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNew;
        private System.Windows.Forms.Label New;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPopular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Popular;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRating;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label LastView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSearch;
        private System.Windows.Forms.Label SearchResult;
    }
}

