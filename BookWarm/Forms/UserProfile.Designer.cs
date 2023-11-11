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
            this.Exit = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.ChangeInfo = new System.Windows.Forms.PictureBox();
            this.Resize = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Silver;
            this.Exit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(716, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(22, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Silver;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(-1, -5);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
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
            this.Minimize.Location = new System.Drawing.Point(648, 9);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 19);
            this.Minimize.TabIndex = 63;
            this.Minimize.Text = "—";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.Controls.Add(this.Resize);
            this.AuthenticationPanel.Controls.Add(this.ChangeInfo);
            this.AuthenticationPanel.Location = new System.Drawing.Point(-2, -5);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(765, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 64;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeInfo.BackColor = System.Drawing.Color.Transparent;
            this.ChangeInfo.Image = ((System.Drawing.Image)(resources.GetObject("ChangeInfo.Image")));
            this.ChangeInfo.Location = new System.Drawing.Point(695, 13);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(24, 24);
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
            this.Resize.Location = new System.Drawing.Point(675, 15);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(20, 20);
            this.Resize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resize.TabIndex = 68;
            this.Resize.TabStop = false;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsername.Location = new System.Drawing.Point(130, 71);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(500, 33);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "UserName";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.Location = new System.Drawing.Point(226, 213);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(300, 16);
            this.lblFullName.TabIndex = 66;
            this.lblFullName.Text = "FullName";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDescription.Location = new System.Drawing.Point(226, 229);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(300, 50);
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
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(323, 106);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePhotoPictureBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 33;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AuthenticationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Back;
        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label Minimize;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox Resize;
        private System.Windows.Forms.PictureBox ChangeInfo;
    }
}