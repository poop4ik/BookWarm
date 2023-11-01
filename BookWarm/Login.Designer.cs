namespace BookWarm
{
    partial class Login
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
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordHashLabel;
            System.Windows.Forms.Label Text;
            System.Windows.Forms.Label LoginInAccount;
            this.Exit = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.RestorePassword = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.Label();
            this.ValidLoginAndPassword = new System.Windows.Forms.Label();
            this.LogoMain = new System.Windows.Forms.PictureBox();
            this.emptytextbox = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            Text = new System.Windows.Forms.Label();
            LoginInAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.Location = new System.Drawing.Point(492, 202);
            usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(110, 24);
            usernameLabel.TabIndex = 18;
            usernameLabel.Text = "Username:";
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordHashLabel.Location = new System.Drawing.Point(492, 246);
            passwordHashLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(105, 24);
            passwordHashLabel.TabIndex = 20;
            passwordHashLabel.Text = "Password:";
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Text.Location = new System.Drawing.Point(604, 146);
            Text.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            Text.Name = "Text";
            Text.Size = new System.Drawing.Size(184, 33);
            Text.TabIndex = 22;
            Text.Text = "Меню Входу";
            // 
            // LoginInAccount
            // 
            LoginInAccount.AutoSize = true;
            LoginInAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LoginInAccount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LoginInAccount.Location = new System.Drawing.Point(645, 324);
            LoginInAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            LoginInAccount.Name = "LoginInAccount";
            LoginInAccount.Size = new System.Drawing.Size(102, 35);
            LoginInAccount.TabIndex = 25;
            LoginInAccount.Text = "Увійти";
            LoginInAccount.Click += new System.EventHandler(this.LoginInAccount_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(939, 11);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(31, 31);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(-1, -6);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(59, 52);
            this.Back.TabIndex = 17;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(636, 202);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTextBox.Size = new System.Drawing.Size(256, 23);
            this.usernameTextBox.TabIndex = 19;
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordHashTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordHashTextBox.Location = new System.Drawing.Point(636, 245);
            this.passwordHashTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.PasswordChar = '*';
            this.passwordHashTextBox.Size = new System.Drawing.Size(256, 23);
            this.passwordHashTextBox.TabIndex = 21;
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
            this.tableAdapterManager.UpdateOrder = BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // RestorePassword
            // 
            this.RestorePassword.AutoSize = true;
            this.RestorePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestorePassword.ForeColor = System.Drawing.Color.Blue;
            this.RestorePassword.Location = new System.Drawing.Point(492, 268);
            this.RestorePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RestorePassword.Name = "RestorePassword";
            this.RestorePassword.Size = new System.Drawing.Size(113, 16);
            this.RestorePassword.TabIndex = 23;
            this.RestorePassword.Text = "Забули пароль?";
            this.RestorePassword.Click += new System.EventHandler(this.RestorePassword_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.Location = new System.Drawing.Point(901, 246);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(34, 24);
            this.ShowPassword.TabIndex = 24;
            this.ShowPassword.Text = "👁️";
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // ValidLoginAndPassword
            // 
            this.ValidLoginAndPassword.AutoSize = true;
            this.ValidLoginAndPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.ValidLoginAndPassword.Location = new System.Drawing.Point(632, 272);
            this.ValidLoginAndPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValidLoginAndPassword.Name = "ValidLoginAndPassword";
            this.ValidLoginAndPassword.Size = new System.Drawing.Size(322, 16);
            this.ValidLoginAndPassword.TabIndex = 26;
            this.ValidLoginAndPassword.Text = "Користувача або пароль введено не правильно";
            this.ValidLoginAndPassword.Visible = false;
            // 
            // LogoMain
            // 
            this.LogoMain.BackColor = System.Drawing.Color.Transparent;
            this.LogoMain.Image = global::BookWarm.Properties.Resources.Без_назви_1;
            this.LogoMain.Location = new System.Drawing.Point(8, 94);
            this.LogoMain.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LogoMain.Name = "LogoMain";
            this.LogoMain.Size = new System.Drawing.Size(484, 368);
            this.LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMain.TabIndex = 16;
            this.LogoMain.TabStop = false;
            // 
            // emptytextbox
            // 
            this.emptytextbox.AutoSize = true;
            this.emptytextbox.BackColor = System.Drawing.Color.Transparent;
            this.emptytextbox.ForeColor = System.Drawing.Color.Firebrick;
            this.emptytextbox.Location = new System.Drawing.Point(632, 272);
            this.emptytextbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emptytextbox.Name = "emptytextbox";
            this.emptytextbox.Size = new System.Drawing.Size(236, 32);
            this.emptytextbox.TabIndex = 27;
            this.emptytextbox.Text = "Будь ласка, заповніть обидва поля\r\n.";
            this.emptytextbox.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(985, 464);
            this.Controls.Add(this.emptytextbox);
            this.Controls.Add(this.ValidLoginAndPassword);
            this.Controls.Add(LoginInAccount);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.RestorePassword);
            this.Controls.Add(Text);
            this.Controls.Add(passwordHashLabel);
            this.Controls.Add(this.passwordHashTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogoMain);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox LogoMain;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordHashTextBox;
        private BookWarmDBDataSet bookWarmDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BookWarmDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BookWarmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label RestorePassword;
        private System.Windows.Forms.Label ShowPassword;
        private System.Windows.Forms.Label ValidLoginAndPassword;
        private System.Windows.Forms.Label emptytextbox;
    }
}