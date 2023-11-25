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
            this.CountryText = new System.Windows.Forms.Label();
            this.AuthorNameText = new System.Windows.Forms.Label();
            this.RelationID = new System.Windows.Forms.Label();
            this.AuthorID = new System.Windows.Forms.Label();
            this.flowLayoutPanelAuthorBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.Back = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CountryText
            // 
            this.CountryText.AutoSize = true;
            this.CountryText.Location = new System.Drawing.Point(148, 65);
            this.CountryText.Name = "CountryText";
            this.CountryText.Size = new System.Drawing.Size(43, 13);
            this.CountryText.TabIndex = 0;
            this.CountryText.Text = "Country";
            // 
            // AuthorNameText
            // 
            this.AuthorNameText.AutoSize = true;
            this.AuthorNameText.Location = new System.Drawing.Point(211, 65);
            this.AuthorNameText.Name = "AuthorNameText";
            this.AuthorNameText.Size = new System.Drawing.Size(66, 13);
            this.AuthorNameText.TabIndex = 1;
            this.AuthorNameText.Text = "AuthorName";
            // 
            // RelationID
            // 
            this.RelationID.AutoSize = true;
            this.RelationID.Location = new System.Drawing.Point(211, 95);
            this.RelationID.Name = "RelationID";
            this.RelationID.Size = new System.Drawing.Size(57, 13);
            this.RelationID.TabIndex = 2;
            this.RelationID.Text = "RelationID";
            // 
            // AuthorID
            // 
            this.AuthorID.AutoSize = true;
            this.AuthorID.Location = new System.Drawing.Point(148, 95);
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.Size = new System.Drawing.Size(49, 13);
            this.AuthorID.TabIndex = 3;
            this.AuthorID.Text = "AuthorID";
            // 
            // flowLayoutPanelAuthorBooks
            // 
            this.flowLayoutPanelAuthorBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelAuthorBooks.AutoScroll = true;
            this.flowLayoutPanelAuthorBooks.Location = new System.Drawing.Point(30, 124);
            this.flowLayoutPanelAuthorBooks.MaximumSize = new System.Drawing.Size(0, 930);
            this.flowLayoutPanelAuthorBooks.MinimumSize = new System.Drawing.Size(710, 52);
            this.flowLayoutPanelAuthorBooks.Name = "flowLayoutPanelAuthorBooks";
            this.flowLayoutPanelAuthorBooks.Size = new System.Drawing.Size(710, 310);
            this.flowLayoutPanelAuthorBooks.TabIndex = 4;
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
            // AuthorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.AuthorID);
            this.Controls.Add(this.RelationID);
            this.Controls.Add(this.AuthorNameText);
            this.Controls.Add(this.CountryText);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.flowLayoutPanelAuthorBooks);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CountryText;
        private System.Windows.Forms.Label AuthorNameText;
        private System.Windows.Forms.Label RelationID;
        private System.Windows.Forms.Label AuthorID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAuthorBooks;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
    }
}