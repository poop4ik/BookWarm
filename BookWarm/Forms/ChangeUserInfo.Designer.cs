namespace BookWarm.Forms
{
    partial class ChangeUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeUserInfo));
            this.Minimize = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.AuthenticationPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Username = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.NewEmail = new System.Windows.Forms.Label();
            this.OldEmail = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.NewEmailBox = new System.Windows.Forms.TextBox();
            this.OldEmailBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.PictureBox();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(680, 9);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(23, 19);
            this.Minimize.TabIndex = 71;
            this.Minimize.Text = "—";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
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
            this.Back.TabIndex = 69;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AuthenticationPanel
            // 
            this.AuthenticationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationPanel.Controls.Add(this.Save);
            this.AuthenticationPanel.Controls.Add(this.Minimize);
            this.AuthenticationPanel.Location = new System.Drawing.Point(0, -2);
            this.AuthenticationPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AuthenticationPanel.Name = "AuthenticationPanel";
            this.AuthenticationPanel.Size = new System.Drawing.Size(765, 41);
            this.AuthenticationPanel.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.AuthenticationPanel.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.AuthenticationPanel.TabIndex = 72;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Arial", 12F);
            this.Username.Location = new System.Drawing.Point(271, 123);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 18);
            this.Username.TabIndex = 73;
            this.Username.Text = "Нікнейм – ";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial", 12F);
            this.Description.Location = new System.Drawing.Point(454, 240);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(44, 18);
            this.Description.TabIndex = 75;
            this.Description.Text = "Опис";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.FirstName.Location = new System.Drawing.Point(271, 180);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(51, 18);
            this.FirstName.TabIndex = 74;
            this.FirstName.Text = "Ім\'я – ";
            this.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Arial", 12F);
            this.LastName.Location = new System.Drawing.Point(271, 150);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(93, 18);
            this.LastName.TabIndex = 76;
            this.LastName.Text = "Прізвище – ";
            this.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 12F);
            this.Email.Location = new System.Drawing.Point(433, 356);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(65, 18);
            this.Email.TabIndex = 77;
            this.Email.Text = "Email – ";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Arial", 12F);
            this.Password.Location = new System.Drawing.Point(71, 356);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(63, 18);
            this.Password.TabIndex = 78;
            this.Password.Text = "Пароль";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(271, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Вік – ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPassword
            // 
            this.OldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPassword.AutoSize = true;
            this.OldPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.OldPassword.Location = new System.Drawing.Point(71, 385);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(117, 18);
            this.OldPassword.TabIndex = 80;
            this.OldPassword.Text = "Старий пароль";
            this.OldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewPassword
            // 
            this.NewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.NewPassword.Location = new System.Drawing.Point(71, 412);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(109, 18);
            this.NewPassword.TabIndex = 81;
            this.NewPassword.Text = "Новий пароль";
            this.NewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewEmail
            // 
            this.NewEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewEmail.AutoSize = true;
            this.NewEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.NewEmail.Location = new System.Drawing.Point(433, 412);
            this.NewEmail.Name = "NewEmail";
            this.NewEmail.Size = new System.Drawing.Size(109, 18);
            this.NewEmail.TabIndex = 83;
            this.NewEmail.Text = "Новий пароль";
            this.NewEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldEmail
            // 
            this.OldEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldEmail.AutoSize = true;
            this.OldEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.OldEmail.Location = new System.Drawing.Point(433, 385);
            this.OldEmail.Name = "OldEmail";
            this.OldEmail.Size = new System.Drawing.Size(117, 18);
            this.OldEmail.TabIndex = 82;
            this.OldEmail.Text = "Старий пароль";
            this.OldEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(342, 76);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(269, 30);
            this.Info.TabIndex = 84;
            this.Info.Text = "Редагування профіля";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.BackColor = System.Drawing.Color.Silver;
            this.OldPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldPasswordBox.Enabled = false;
            this.OldPasswordBox.Location = new System.Drawing.Point(194, 389);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.Size = new System.Drawing.Size(124, 13);
            this.OldPasswordBox.TabIndex = 85;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.BackColor = System.Drawing.Color.Silver;
            this.NewPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordBox.Enabled = false;
            this.NewPasswordBox.Location = new System.Drawing.Point(194, 416);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(124, 13);
            this.NewPasswordBox.TabIndex = 86;
            // 
            // NewEmailBox
            // 
            this.NewEmailBox.BackColor = System.Drawing.Color.Silver;
            this.NewEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewEmailBox.Enabled = false;
            this.NewEmailBox.Location = new System.Drawing.Point(560, 416);
            this.NewEmailBox.Name = "NewEmailBox";
            this.NewEmailBox.Size = new System.Drawing.Size(124, 13);
            this.NewEmailBox.TabIndex = 88;
            // 
            // OldEmailBox
            // 
            this.OldEmailBox.BackColor = System.Drawing.Color.Silver;
            this.OldEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldEmailBox.Enabled = false;
            this.OldEmailBox.Location = new System.Drawing.Point(560, 389);
            this.OldEmailBox.Name = "OldEmailBox";
            this.OldEmailBox.Size = new System.Drawing.Size(124, 13);
            this.OldEmailBox.TabIndex = 87;
            // 
            // LastNameBox
            // 
            this.LastNameBox.BackColor = System.Drawing.Color.Silver;
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(370, 154);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(124, 13);
            this.LastNameBox.TabIndex = 90;
            this.LastNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameBox
            // 
            this.UserNameBox.BackColor = System.Drawing.Color.Silver;
            this.UserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameBox.Enabled = false;
            this.UserNameBox.Location = new System.Drawing.Point(370, 127);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(124, 13);
            this.UserNameBox.TabIndex = 89;
            this.UserNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgeBox
            // 
            this.AgeBox.BackColor = System.Drawing.Color.Silver;
            this.AgeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgeBox.Enabled = false;
            this.AgeBox.Location = new System.Drawing.Point(319, 211);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(124, 13);
            this.AgeBox.TabIndex = 92;
            this.AgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.BackColor = System.Drawing.Color.Silver;
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameBox.Enabled = false;
            this.FirstNameBox.Location = new System.Drawing.Point(319, 184);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(124, 13);
            this.FirstNameBox.TabIndex = 91;
            this.FirstNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.Silver;
            this.DescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionBox.Enabled = false;
            this.DescriptionBox.Location = new System.Drawing.Point(347, 263);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(264, 13);
            this.DescriptionBox.TabIndex = 95;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.Silver;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(497, 360);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(124, 13);
            this.EmailBox.TabIndex = 96;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Image = global::BookWarm.Properties.Resources.savepng;
            this.Save.Location = new System.Drawing.Point(708, 6);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(32, 32);
            this.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Save.TabIndex = 97;
            this.Save.TabStop = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
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
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(47, 76);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePhotoPictureBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(200, 200);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 70;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox1.Location = new System.Drawing.Point(-26, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox2.Location = new System.Drawing.Point(324, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // ChangeUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.NewEmailBox);
            this.Controls.Add(this.OldEmailBox);
            this.Controls.Add(this.NewPasswordBox);
            this.Controls.Add(this.OldPasswordBox);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.NewEmail);
            this.Controls.Add(this.OldEmail);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 10;
            this.Text = "ChangeUserInfo";
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).EndInit();
            this.AuthenticationPanel.ResumeLayout(false);
            this.AuthenticationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Back;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel AuthenticationPanel;
        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OldPassword;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Label NewEmail;
        private System.Windows.Forms.Label OldEmail;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.TextBox NewEmailBox;
        private System.Windows.Forms.TextBox OldEmailBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.PictureBox Save;
    }
}