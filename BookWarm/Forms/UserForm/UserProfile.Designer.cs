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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.Back = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ChangeInfo = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            this.lblTotalView = new System.Windows.Forms.Label();
            this.lblTotalRead = new System.Windows.Forms.Label();
            this.ReadsNow = new System.Windows.Forms.Label();
            this.Reads = new System.Windows.Forms.Label();
            this.Preference = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelPreference = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelReads = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelReadsNow = new System.Windows.Forms.FlowLayoutPanel();
            this.History = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(-1, -6);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 52);
            this.Back.TabIndex = 31;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(849, 11);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 24);
            this.Minimize.TabIndex = 63;
            this.Minimize.Text = "—";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.Controls.Add(this.ChangeInfo);
            this.AuthenticationPanel.Controls.Add(this.Resize);
            this.AuthenticationPanel.Controls.Add(this.Exit);
            this.AuthenticationPanel.Controls.Add(this.Logout);
            this.AuthenticationPanel.Location = new System.Drawing.Point(-3, -6);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(1020, 50);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 64;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeInfo.BackColor = System.Drawing.Color.Transparent;
            this.ChangeInfo.Image = ((System.Drawing.Image)(resources.GetObject("ChangeInfo.Image")));
            this.ChangeInfo.Location = new System.Drawing.Point(887, 16);
            this.ChangeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(32, 30);
            this.ChangeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChangeInfo.TabIndex = 68;
            this.ChangeInfo.TabStop = false;
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click);
            // 
            // Resize
            // 
            this.Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resize.BackColor = System.Drawing.Color.Transparent;
            this.Resize.Image = global::BookWarm.Properties.Resources.resizepng;
            this.Resize.Location = new System.Drawing.Point(855, 18);
            this.Resize.Margin = new System.Windows.Forms.Padding(4);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(27, 25);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 68;
            this.Resize.TabStop = false;
            this.Resize.Visible = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Image = global::BookWarm.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(957, 14);
            this.Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 32);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 68;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Image = global::BookWarm.Properties.Resources.exitacc;
            this.Logout.Location = new System.Drawing.Point(921, 12);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(37, 34);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 68;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(173, 83);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(667, 41);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "UserName";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(299, 274);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(400, 20);
            this.lblFullName.TabIndex = 66;
            this.lblFullName.Text = "FullName";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDescription.Location = new System.Drawing.Point(301, 294);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(400, 46);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(431, 130);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePhotoPictureBox.MaximumSize = new System.Drawing.Size(267, 246);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(133, 133);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 33;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // lblTotalView
            // 
            this.lblTotalView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalView.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalView.Location = new System.Drawing.Point(453, 366);
            this.lblTotalView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalView.Name = "lblTotalView";
            this.lblTotalView.Size = new System.Drawing.Size(95, 21);
            this.lblTotalView.TabIndex = 68;
            this.lblTotalView.Text = "TotalView";
            this.lblTotalView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalRead
            // 
            this.lblTotalRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRead.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblTotalRead.Location = new System.Drawing.Point(453, 333);
            this.lblTotalRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRead.Name = "lblTotalRead";
            this.lblTotalRead.Size = new System.Drawing.Size(95, 33);
            this.lblTotalRead.TabIndex = 69;
            this.lblTotalRead.Text = "TotalRead";
            this.lblTotalRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadsNow
            // 
            this.ReadsNow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReadsNow.BackColor = System.Drawing.Color.Silver;
            this.ReadsNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadsNow.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadsNow.Location = new System.Drawing.Point(35, 414);
            this.ReadsNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadsNow.Name = "ReadsNow";
            this.ReadsNow.Size = new System.Drawing.Size(141, 47);
            this.ReadsNow.TabIndex = 70;
            this.ReadsNow.Text = "Читаю";
            this.ReadsNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reads
            // 
            this.Reads.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reads.BackColor = System.Drawing.Color.Silver;
            this.Reads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reads.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reads.Location = new System.Drawing.Point(295, 421);
            this.Reads.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Reads.Name = "Reads";
            this.Reads.Size = new System.Drawing.Size(141, 33);
            this.Reads.TabIndex = 71;
            this.Reads.Text = "Прочитані";
            this.Reads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Preference
            // 
            this.Preference.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Preference.BackColor = System.Drawing.Color.Silver;
            this.Preference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Preference.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Preference.Location = new System.Drawing.Point(560, 421);
            this.Preference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Preference.Name = "Preference";
            this.Preference.Size = new System.Drawing.Size(141, 33);
            this.Preference.TabIndex = 72;
            this.Preference.Text = "Обрані";
            this.Preference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox2.Location = new System.Drawing.Point(904, -149);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 908);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 218;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::BookWarm.Properties.Resources.linev2;
            this.pictureBox8.Location = new System.Drawing.Point(-36, -158);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(133, 897);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 217;
            this.pictureBox8.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 414);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 47);
            this.label1.TabIndex = 219;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelHistory
            // 
            this.flowLayoutPanelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelHistory.AutoScroll = true;
            this.flowLayoutPanelHistory.AutoSize = true;
            this.flowLayoutPanelHistory.Location = new System.Drawing.Point(96, 492);
            this.flowLayoutPanelHistory.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelHistory.MaximumSize = new System.Drawing.Size(0, 355);
            this.flowLayoutPanelHistory.MinimumSize = new System.Drawing.Size(1000, 64);
            this.flowLayoutPanelHistory.Name = "flowLayoutPanelHistory";
            this.flowLayoutPanelHistory.Size = new System.Drawing.Size(1000, 65);
            this.flowLayoutPanelHistory.TabIndex = 220;
            // 
            // flowLayoutPanelPreference
            // 
            this.flowLayoutPanelPreference.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPreference.AutoScroll = true;
            this.flowLayoutPanelPreference.AutoSize = true;
            this.flowLayoutPanelPreference.Location = new System.Drawing.Point(96, 492);
            this.flowLayoutPanelPreference.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelPreference.MaximumSize = new System.Drawing.Size(0, 355);
            this.flowLayoutPanelPreference.MinimumSize = new System.Drawing.Size(1000, 64);
            this.flowLayoutPanelPreference.Name = "flowLayoutPanelPreference";
            this.flowLayoutPanelPreference.Size = new System.Drawing.Size(1000, 65);
            this.flowLayoutPanelPreference.TabIndex = 221;
            // 
            // flowLayoutPanelReads
            // 
            this.flowLayoutPanelReads.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReads.AutoScroll = true;
            this.flowLayoutPanelReads.AutoSize = true;
            this.flowLayoutPanelReads.Location = new System.Drawing.Point(96, 492);
            this.flowLayoutPanelReads.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelReads.MaximumSize = new System.Drawing.Size(0, 355);
            this.flowLayoutPanelReads.MinimumSize = new System.Drawing.Size(1000, 64);
            this.flowLayoutPanelReads.Name = "flowLayoutPanelReads";
            this.flowLayoutPanelReads.Size = new System.Drawing.Size(1000, 64);
            this.flowLayoutPanelReads.TabIndex = 222;
            // 
            // flowLayoutPanelReadsNow
            // 
            this.flowLayoutPanelReadsNow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReadsNow.AutoScroll = true;
            this.flowLayoutPanelReadsNow.AutoSize = true;
            this.flowLayoutPanelReadsNow.Location = new System.Drawing.Point(96, 492);
            this.flowLayoutPanelReadsNow.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelReadsNow.MaximumSize = new System.Drawing.Size(0, 355);
            this.flowLayoutPanelReadsNow.MinimumSize = new System.Drawing.Size(1000, 64);
            this.flowLayoutPanelReadsNow.Name = "flowLayoutPanelReadsNow";
            this.flowLayoutPanelReadsNow.Size = new System.Drawing.Size(1000, 65);
            this.flowLayoutPanelReadsNow.TabIndex = 223;
            // 
            // History
            // 
            this.History.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.History.BackColor = System.Drawing.Color.Silver;
            this.History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.History.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.History.Location = new System.Drawing.Point(825, 414);
            this.History.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(140, 47);
            this.History.TabIndex = 224;
            this.History.Text = "Історія";
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.History);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.Preference);
            this.Controls.Add(this.Reads);
            this.Controls.Add(this.ReadsNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanelReadsNow);
            this.Controls.Add(this.flowLayoutPanelHistory);
            this.Controls.Add(this.flowLayoutPanelReads);
            this.Controls.Add(this.flowLayoutPanelPreference);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.lblTotalRead);
            this.Controls.Add(this.lblTotalView);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "BookWorm";
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Back;
        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.PictureBox ChangeInfo;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.Label lblTotalView;
        private System.Windows.Forms.Label lblTotalRead;
        private System.Windows.Forms.Label ReadsNow;
        private System.Windows.Forms.Label Reads;
        private System.Windows.Forms.Label Preference;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPreference;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReads;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelReadsNow;
        private System.Windows.Forms.Label History;
    }
}