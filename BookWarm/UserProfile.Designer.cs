namespace BookWarm
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.Exit = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Resize = new System.Windows.Forms.Label();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.profilePhotoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(763, 9);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(24, 24);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(-1, -5);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 15;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.AutoSize = true;
            this.Resize.BackColor = System.Drawing.Color.Transparent;
            this.Resize.Font = new System.Drawing.Font("MS Outlook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Resize.Location = new System.Drawing.Point(750, 13);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(17, 17);
            this.Resize.TabIndex = 16;
            this.Resize.Text = "O";
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookReadsTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.BookViewsTableAdapter = null;
            this.tableAdapterManager.ForeignBooksTableAdapter = null;
            this.tableAdapterManager.MainBooksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserFavoritesTableAdapter = null;
            this.tableAdapterManager.UserPreferencesTableAdapter = null;
            this.tableAdapterManager.UserReviewsTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.UserStatisticsTableAdapter = null;
            // 
            // profilePhotoPictureBox
            // 
            this.profilePhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usersBindingSource, "ProfilePhoto", true));
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(91, 76);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePhotoPictureBox.TabIndex = 19;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.Label Resize;
        private BookWarmDBDataSet bookWarmDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BookWarmDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BookWarmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox profilePhotoPictureBox;
    }
}