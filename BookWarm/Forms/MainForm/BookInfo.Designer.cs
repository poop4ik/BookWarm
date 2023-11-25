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
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Back = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.Label();
            this.ViewCount = new System.Windows.Forms.Label();
            this.ReadsCount = new System.Windows.Forms.Label();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.BookImage = new System.Windows.Forms.PictureBox();
            this.Year = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1175, 6);
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
            this.Resize.Location = new System.Drawing.Point(1151, 10);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(20, 20);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 73;
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
            this.Minimize.Location = new System.Drawing.Point(1149, 9);
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
            this.AuthenticationPanel.Size = new System.Drawing.Size(1213, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
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
            this.genreListBox.Size = new System.Drawing.Size(791, 54);
            this.genreListBox.TabIndex = 200;
            // 
            // BookImage
            // 
            this.BookImage.Location = new System.Drawing.Point(112, 81);
            this.BookImage.Name = "BookImage";
            this.BookImage.Size = new System.Drawing.Size(209, 260);
            this.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BookImage.TabIndex = 201;
            this.BookImage.TabStop = false;
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
            this.DescriptionTitle.Font = new System.Drawing.Font("Arial Black", 12F);
            this.DescriptionTitle.Location = new System.Drawing.Point(555, 363);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(196, 27);
            this.DescriptionTitle.TabIndex = 208;
            this.DescriptionTitle.Text = "DescriptionTitle";
            this.DescriptionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 210;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.BackColor = System.Drawing.Color.LightGray;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(336, 409);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(620, 211);
            this.Description.TabIndex = 211;
            this.Description.Text = "Description";
            // 
            // BookInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1213, 654);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.ViewCount);
            this.Controls.Add(this.ReadsCount);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.label5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.StateCommon.Border.Rounding = 10;
            this.Text = "BookWorm";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookImage)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Description;
    }
}