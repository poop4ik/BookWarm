namespace BookWarm.Forms.ToolForm
{
    partial class BookWorm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWorm));
            this.ReviewText = new System.Windows.Forms.TextBox();
            this.Rating = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            this.SendReview = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ChooseRating = new System.Windows.Forms.NumericUpDown();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Back = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.StarRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // ReviewText
            // 
            this.ReviewText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewText.BackColor = System.Drawing.Color.Silver;
            this.ReviewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReviewText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReviewText.Location = new System.Drawing.Point(108, 100);
            this.ReviewText.MaxLength = 200;
            this.ReviewText.Multiline = true;
            this.ReviewText.Name = "ReviewText";
            this.ReviewText.Size = new System.Drawing.Size(587, 63);
            this.ReviewText.TabIndex = 300;
            this.ReviewText.Text = "Напишіть відгук . . .";
            this.ReviewText.Enter += new System.EventHandler(this.textReviewText_Leave);
            this.ReviewText.Leave += new System.EventHandler(this.textReviewText_Enter);
            // 
            // Rating
            // 
            this.Rating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rating.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Rating.Location = new System.Drawing.Point(110, 64);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(179, 33);
            this.Rating.TabIndex = 216;
            this.Rating.Text = "Виберіть оцінку";
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(109, 36);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(166, 33);
            this.Username.TabIndex = 214;
            this.Username.Text = "UserName";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profilePhotoPictureBox
            // 
            this.profilePhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePhotoPictureBox.Border = 1;
            this.profilePhotoPictureBox.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePhotoPictureBox.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePhotoPictureBox.ColorBorder = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.ColorBorder2 = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.Gradiant = 50F;
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(11, 36);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePhotoPictureBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(79, 79);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 213;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // SendReview
            // 
            this.SendReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendReview.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.SendReview.Location = new System.Drawing.Point(511, 176);
            this.SendReview.Name = "SendReview";
            this.SendReview.Size = new System.Drawing.Size(166, 33);
            this.SendReview.TabIndex = 218;
            this.SendReview.Text = "Надіслати відгук";
            this.SendReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendReview.Click += new System.EventHandler(this.SendReview_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.line;
            this.pictureBox3.Location = new System.Drawing.Point(493, 154);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 219;
            this.pictureBox3.TabStop = false;
            // 
            // ChooseRating
            // 
            this.ChooseRating.BackColor = System.Drawing.Color.Silver;
            this.ChooseRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChooseRating.DecimalPlaces = 1;
            this.ChooseRating.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseRating.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.ChooseRating.Location = new System.Drawing.Point(232, 72);
            this.ChooseRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ChooseRating.Name = "ChooseRating";
            this.ChooseRating.ReadOnly = true;
            this.ChooseRating.Size = new System.Drawing.Size(43, 18);
            this.ChooseRating.TabIndex = 220;
            this.ChooseRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChooseRating.ValueChanged += new System.EventHandler(this.ChooseRating_ValueChanged);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Controls.Add(this.Back);
            this.AuthenticationPanel.Controls.Add(this.Exit);
            this.AuthenticationPanel.Location = new System.Drawing.Point(-2, -1);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(741, 33);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.DarkGray;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 221;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.DarkGray;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(5, -7);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 301;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::BookWarm.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(702, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 302;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StarRate
            // 
            this.StarRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StarRate.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.StarRate.Location = new System.Drawing.Point(278, 64);
            this.StarRate.Name = "StarRate";
            this.StarRate.Size = new System.Drawing.Size(179, 33);
            this.StarRate.TabIndex = 301;
            this.StarRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(738, 218);
            this.Controls.Add(this.StarRate);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.ChooseRating);
            this.Controls.Add(this.SendReview);
            this.Controls.Add(this.ReviewText);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.pictureBox3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookWorm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "Review";
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChooseRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReviewText;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Username;
        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label SendReview;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown ChooseRating;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label StarRate;
    }
}