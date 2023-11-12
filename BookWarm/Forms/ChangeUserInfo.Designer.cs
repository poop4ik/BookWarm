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
            this.Change = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            this.ShowPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailExist = new System.Windows.Forms.Label();
            this.ValidEmail = new System.Windows.Forms.Label();
            this.EmailCheck = new System.Windows.Forms.Label();
            this.PasswordValid = new System.Windows.Forms.Label();
            this.UserNameExist = new System.Windows.Forms.Label();
            this.DescriptionLimit = new System.Windows.Forms.Label();
            this.AgeValid = new System.Windows.Forms.Label();
            this.PasswordRepeat = new System.Windows.Forms.Label();
            this.EmailRepeat = new System.Windows.Forms.Label();
            this.PasswordEmpty = new System.Windows.Forms.Label();
            this.EmailEmpty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AuthenticationPanel)).BeginInit();
            this.AuthenticationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Change)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Silver;
            this.Minimize.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize.Location = new System.Drawing.Point(662, 10);
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
            this.AuthenticationPanel.Controls.Add(this.Change);
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
            this.Username.Location = new System.Drawing.Point(261, 124);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(96, 18);
            this.Username.TabIndex = 73;
            this.Username.Text = "Нікнейм   –>";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Description.Location = new System.Drawing.Point(590, 102);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(56, 23);
            this.Description.TabIndex = 75;
            this.Description.Text = "Опис";
            this.Description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Arial", 12F);
            this.FirstName.Location = new System.Drawing.Point(261, 181);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(96, 18);
            this.FirstName.TabIndex = 74;
            this.FirstName.Text = "Ім\'я           –>";
            this.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Arial", 12F);
            this.LastName.Location = new System.Drawing.Point(261, 151);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(102, 18);
            this.LastName.TabIndex = 76;
            this.LastName.Text = "Прізвище –> ";
            this.LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Email.Location = new System.Drawing.Point(464, 332);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(83, 23);
            this.Email.TabIndex = 77;
            this.Email.Text = "Email –>";
            this.Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(173, 334);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 23);
            this.Password.TabIndex = 78;
            this.Password.Text = "Пароль";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(261, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 79;
            this.label2.Text = "Вік            –> ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldPassword
            // 
            this.OldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldPassword.AutoSize = true;
            this.OldPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.OldPassword.Location = new System.Drawing.Point(84, 364);
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
            this.NewPassword.Location = new System.Drawing.Point(84, 391);
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
            this.NewEmail.Location = new System.Drawing.Point(465, 391);
            this.NewEmail.Name = "NewEmail";
            this.NewEmail.Size = new System.Drawing.Size(95, 18);
            this.NewEmail.TabIndex = 83;
            this.NewEmail.Text = "Новий email";
            this.NewEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OldEmail
            // 
            this.OldEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OldEmail.AutoSize = true;
            this.OldEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.OldEmail.Location = new System.Drawing.Point(465, 364);
            this.OldEmail.Name = "OldEmail";
            this.OldEmail.Size = new System.Drawing.Size(103, 18);
            this.OldEmail.TabIndex = 82;
            this.OldEmail.Text = "Старий email";
            this.OldEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Info.Location = new System.Drawing.Point(375, 65);
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
            this.OldPasswordBox.Location = new System.Drawing.Point(207, 368);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.PasswordChar = '*';
            this.OldPasswordBox.Size = new System.Drawing.Size(124, 13);
            this.OldPasswordBox.TabIndex = 85;
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.BackColor = System.Drawing.Color.Silver;
            this.NewPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewPasswordBox.Enabled = false;
            this.NewPasswordBox.Location = new System.Drawing.Point(207, 395);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.PasswordChar = '*';
            this.NewPasswordBox.Size = new System.Drawing.Size(124, 13);
            this.NewPasswordBox.TabIndex = 86;
            // 
            // NewEmailBox
            // 
            this.NewEmailBox.BackColor = System.Drawing.Color.Silver;
            this.NewEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewEmailBox.Enabled = false;
            this.NewEmailBox.Location = new System.Drawing.Point(574, 395);
            this.NewEmailBox.Name = "NewEmailBox";
            this.NewEmailBox.Size = new System.Drawing.Size(142, 13);
            this.NewEmailBox.TabIndex = 88;
            // 
            // OldEmailBox
            // 
            this.OldEmailBox.BackColor = System.Drawing.Color.Silver;
            this.OldEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldEmailBox.Enabled = false;
            this.OldEmailBox.Location = new System.Drawing.Point(574, 368);
            this.OldEmailBox.Name = "OldEmailBox";
            this.OldEmailBox.Size = new System.Drawing.Size(142, 13);
            this.OldEmailBox.TabIndex = 87;
            // 
            // LastNameBox
            // 
            this.LastNameBox.BackColor = System.Drawing.Color.Silver;
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameBox.Enabled = false;
            this.LastNameBox.Location = new System.Drawing.Point(360, 155);
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
            this.UserNameBox.Location = new System.Drawing.Point(360, 128);
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
            this.AgeBox.Location = new System.Drawing.Point(360, 211);
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
            this.FirstNameBox.Location = new System.Drawing.Point(360, 181);
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
            this.DescriptionBox.Location = new System.Drawing.Point(530, 126);
            this.DescriptionBox.MaxLength = 80;
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(183, 97);
            this.DescriptionBox.TabIndex = 95;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.Silver;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Enabled = false;
            this.EmailBox.Location = new System.Drawing.Point(545, 339);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(171, 13);
            this.EmailBox.TabIndex = 96;
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.Transparent;
            this.Change.Image = global::BookWarm.Properties.Resources.changepng;
            this.Change.Location = new System.Drawing.Point(688, 10);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(22, 22);
            this.Change.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Change.TabIndex = 99;
            this.Change.TabStop = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Image = global::BookWarm.Properties.Resources.savepng;
            this.Save.Location = new System.Drawing.Point(714, 9);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(26, 26);
            this.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Save.TabIndex = 97;
            this.Save.TabStop = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox1.Location = new System.Drawing.Point(-20, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox2.Location = new System.Drawing.Point(356, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(472, 272);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox3.Location = new System.Drawing.Point(252, -6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(249, 358);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BookWarm.Properties.Resources.rectanglev2;
            this.pictureBox4.Location = new System.Drawing.Point(519, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(205, 358);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
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
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.Location = new System.Drawing.Point(330, 380);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(27, 18);
            this.ShowPassword.TabIndex = 99;
            this.ShowPassword.Text = "👁️";
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(322, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 100;
            this.label1.Text = "Про акаунт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailExist
            // 
            this.EmailExist.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailExist.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailExist.Location = new System.Drawing.Point(436, 423);
            this.EmailExist.Name = "EmailExist";
            this.EmailExist.Size = new System.Drawing.Size(313, 19);
            this.EmailExist.TabIndex = 101;
            this.EmailExist.Text = "Дана електронна адреса уже використовується.\r\n\r\n";
            this.EmailExist.Visible = false;
            // 
            // ValidEmail
            // 
            this.ValidEmail.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValidEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.ValidEmail.Location = new System.Drawing.Point(516, 423);
            this.ValidEmail.Name = "ValidEmail";
            this.ValidEmail.Size = new System.Drawing.Size(168, 19);
            this.ValidEmail.TabIndex = 102;
            this.ValidEmail.Text = "Введіть коректний email.";
            this.ValidEmail.Visible = false;
            // 
            // EmailCheck
            // 
            this.EmailCheck.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailCheck.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailCheck.Location = new System.Drawing.Point(516, 423);
            this.EmailCheck.Name = "EmailCheck";
            this.EmailCheck.Size = new System.Drawing.Size(168, 19);
            this.EmailCheck.TabIndex = 103;
            this.EmailCheck.Text = "Старий email не вірний.\r\n";
            this.EmailCheck.Visible = false;
            // 
            // PasswordValid
            // 
            this.PasswordValid.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordValid.ForeColor = System.Drawing.Color.Firebrick;
            this.PasswordValid.Location = new System.Drawing.Point(116, 423);
            this.PasswordValid.Name = "PasswordValid";
            this.PasswordValid.Size = new System.Drawing.Size(215, 19);
            this.PasswordValid.TabIndex = 104;
            this.PasswordValid.Text = "Старий пароль введено не вірно.\r\n\r\n";
            this.PasswordValid.Visible = false;
            // 
            // UserNameExist
            // 
            this.UserNameExist.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold);
            this.UserNameExist.ForeColor = System.Drawing.Color.Firebrick;
            this.UserNameExist.Location = new System.Drawing.Point(378, 142);
            this.UserNameExist.Name = "UserNameExist";
            this.UserNameExist.Size = new System.Drawing.Size(87, 10);
            this.UserNameExist.TabIndex = 105;
            this.UserNameExist.Text = "Нікнейм занятий\r\n.";
            this.UserNameExist.Visible = false;
            // 
            // DescriptionLimit
            // 
            this.DescriptionLimit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLimit.ForeColor = System.Drawing.Color.Firebrick;
            this.DescriptionLimit.Location = new System.Drawing.Point(527, 234);
            this.DescriptionLimit.Name = "DescriptionLimit";
            this.DescriptionLimit.Size = new System.Drawing.Size(197, 19);
            this.DescriptionLimit.TabIndex = 106;
            this.DescriptionLimit.Text = "Кількість символів більше 80.";
            this.DescriptionLimit.Visible = false;
            // 
            // AgeValid
            // 
            this.AgeValid.Font = new System.Drawing.Font("Arial Black", 6F, System.Drawing.FontStyle.Bold);
            this.AgeValid.ForeColor = System.Drawing.Color.Firebrick;
            this.AgeValid.Location = new System.Drawing.Point(358, 198);
            this.AgeValid.Name = "AgeValid";
            this.AgeValid.Size = new System.Drawing.Size(127, 11);
            this.AgeValid.TabIndex = 107;
            this.AgeValid.Text = "Він вказано не правильно";
            this.AgeValid.Visible = false;
            // 
            // PasswordRepeat
            // 
            this.PasswordRepeat.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordRepeat.ForeColor = System.Drawing.Color.Firebrick;
            this.PasswordRepeat.Location = new System.Drawing.Point(154, 423);
            this.PasswordRepeat.Name = "PasswordRepeat";
            this.PasswordRepeat.Size = new System.Drawing.Size(131, 19);
            this.PasswordRepeat.TabIndex = 108;
            this.PasswordRepeat.Text = "Паролі співпадають";
            this.PasswordRepeat.Visible = false;
            // 
            // EmailRepeat
            // 
            this.EmailRepeat.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailRepeat.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailRepeat.Location = new System.Drawing.Point(542, 423);
            this.EmailRepeat.Name = "EmailRepeat";
            this.EmailRepeat.Size = new System.Drawing.Size(117, 19);
            this.EmailRepeat.TabIndex = 109;
            this.EmailRepeat.Text = "Пошта співпадає";
            this.EmailRepeat.Visible = false;
            // 
            // PasswordEmpty
            // 
            this.PasswordEmpty.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEmpty.ForeColor = System.Drawing.Color.Firebrick;
            this.PasswordEmpty.Location = new System.Drawing.Point(135, 423);
            this.PasswordEmpty.Name = "PasswordEmpty";
            this.PasswordEmpty.Size = new System.Drawing.Size(196, 19);
            this.PasswordEmpty.TabIndex = 110;
            this.PasswordEmpty.Text = "Поле з новим паролем пусте";
            this.PasswordEmpty.Visible = false;
            // 
            // EmailEmpty
            // 
            this.EmailEmpty.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailEmpty.ForeColor = System.Drawing.Color.Firebrick;
            this.EmailEmpty.Location = new System.Drawing.Point(516, 423);
            this.EmailEmpty.Name = "EmailEmpty";
            this.EmailEmpty.Size = new System.Drawing.Size(168, 19);
            this.EmailEmpty.TabIndex = 111;
            this.EmailEmpty.Text = "Поле з новим Email пусте";
            this.EmailEmpty.Visible = false;
            // 
            // ChangeUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.EmailRepeat);
            this.Controls.Add(this.EmailEmpty);
            this.Controls.Add(this.PasswordEmpty);
            this.Controls.Add(this.PasswordRepeat);
            this.Controls.Add(this.AgeValid);
            this.Controls.Add(this.DescriptionLimit);
            this.Controls.Add(this.UserNameExist);
            this.Controls.Add(this.PasswordValid);
            this.Controls.Add(this.EmailCheck);
            this.Controls.Add(this.ValidEmail);
            this.Controls.Add(this.EmailExist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.AgeBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.UserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.NewEmailBox);
            this.Controls.Add(this.OldEmailBox);
            this.Controls.Add(this.NewPasswordBox);
            this.Controls.Add(this.OldPasswordBox);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.NewEmail);
            this.Controls.Add(this.OldEmail);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AuthenticationPanel);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
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
            ((System.ComponentModel.ISupportInitialize)(this.Change)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox Change;
        private System.Windows.Forms.Label ShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EmailExist;
        private System.Windows.Forms.Label ValidEmail;
        private System.Windows.Forms.Label EmailCheck;
        private System.Windows.Forms.Label PasswordValid;
        private System.Windows.Forms.Label UserNameExist;
        private System.Windows.Forms.Label DescriptionLimit;
        private System.Windows.Forms.Label AgeValid;
        private System.Windows.Forms.Label PasswordRepeat;
        private System.Windows.Forms.Label EmailRepeat;
        private System.Windows.Forms.Label PasswordEmpty;
        private System.Windows.Forms.Label EmailEmpty;
    }
}