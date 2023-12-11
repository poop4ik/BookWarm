namespace BookWarm
{
    partial class BookRead
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
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Back = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewCount = new System.Windows.Forms.Label();
            this.ReadsCount = new System.Windows.Forms.Label();
            this.BookWorm = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.BookContent = new System.Windows.Forms.RichTextBox();
            this.Download = new System.Windows.Forms.Label();
            this.EndRead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookWorm)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.AutoSize = true;
            this.AuthenticationPanel.Controls.Add(this.Back);
            this.AuthenticationPanel.Controls.Add(this.Exit);
            this.AuthenticationPanel.Location = new System.Drawing.Point(-4, 2);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(1385, 47);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 222;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(9, -5);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 52);
            this.Back.TabIndex = 301;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::BookWarm.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(1329, 5);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 32);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 302;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox8.Location = new System.Drawing.Point(4, 41);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(133, 798);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 223;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox1.Location = new System.Drawing.Point(1244, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 798);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 224;
            this.pictureBox1.TabStop = false;
            // 
            // ViewCount
            // 
            this.ViewCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ViewCount.AutoSize = true;
            this.ViewCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewCount.Location = new System.Drawing.Point(696, 396);
            this.ViewCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewCount.Name = "ViewCount";
            this.ViewCount.Size = new System.Drawing.Size(53, 23);
            this.ViewCount.TabIndex = 228;
            this.ViewCount.Text = "View";
            this.ViewCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadsCount
            // 
            this.ReadsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReadsCount.AutoSize = true;
            this.ReadsCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadsCount.Location = new System.Drawing.Point(597, 396);
            this.ReadsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadsCount.Name = "ReadsCount";
            this.ReadsCount.Size = new System.Drawing.Size(67, 23);
            this.ReadsCount.TabIndex = 227;
            this.ReadsCount.Text = "Reads";
            this.ReadsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookWorm
            // 
            this.BookWorm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BookWorm.Location = new System.Drawing.Point(580, 74);
            this.BookWorm.Margin = new System.Windows.Forms.Padding(4);
            this.BookWorm.Name = "BookWorm";
            this.BookWorm.Size = new System.Drawing.Size(189, 261);
            this.BookWorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookWorm.TabIndex = 230;
            this.BookWorm.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.BackColor = System.Drawing.Color.Transparent;
            this.titleText.Font = new System.Drawing.Font("Arial Black", 16F);
            this.titleText.Location = new System.Drawing.Point(632, 348);
            this.titleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(92, 38);
            this.titleText.TabIndex = 225;
            this.titleText.Text = "Title";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookContent
            // 
            this.BookContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookContent.BackColor = System.Drawing.Color.LightGray;
            this.BookContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookContent.Location = new System.Drawing.Point(145, 542);
            this.BookContent.Margin = new System.Windows.Forms.Padding(4);
            this.BookContent.Name = "BookContent";
            this.BookContent.ReadOnly = true;
            this.BookContent.Size = new System.Drawing.Size(1091, 279);
            this.BookContent.TabIndex = 231;
            this.BookContent.Text = "";
            // 
            // Download
            // 
            this.Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Download.BackColor = System.Drawing.Color.Transparent;
            this.Download.Font = new System.Drawing.Font("Arial Black", 16F);
            this.Download.Location = new System.Drawing.Point(542, 432);
            this.Download.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(275, 38);
            this.Download.TabIndex = 232;
            this.Download.Text = "Завантажити";
            this.Download.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // EndRead
            // 
            this.EndRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndRead.BackColor = System.Drawing.Color.Transparent;
            this.EndRead.Font = new System.Drawing.Font("Arial Black", 16F);
            this.EndRead.Location = new System.Drawing.Point(463, 481);
            this.EndRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndRead.Name = "EndRead";
            this.EndRead.Size = new System.Drawing.Size(435, 38);
            this.EndRead.TabIndex = 233;
            this.EndRead.Text = "Завершити читання";
            this.EndRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EndRead.Click += new System.EventHandler(this.EndRead_Click);
            // 
            // BookRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1380, 836);
            this.Controls.Add(this.EndRead);
            this.Controls.Add(this.Download);
            this.Controls.Add(this.BookContent);
            this.Controls.Add(this.ReadsCount);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.ViewCount);
            this.Controls.Add(this.BookWorm);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookRead";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "і";
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookWorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ViewCount;
        private System.Windows.Forms.Label ReadsCount;
        private System.Windows.Forms.PictureBox BookWorm;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.RichTextBox BookContent;
        private System.Windows.Forms.Label Download;
        private System.Windows.Forms.Label EndRead;
    }
}