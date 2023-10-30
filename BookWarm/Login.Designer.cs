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
            this.LogoMain = new System.Windows.Forms.PictureBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.Label();
            this.ValidLoginAndPassword = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordHashLabel = new System.Windows.Forms.Label();
            Text = new System.Windows.Forms.Label();
            LoginInAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.Location = new System.Drawing.Point(369, 164);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 18);
            usernameLabel.TabIndex = 18;
            usernameLabel.Text = "Username:";
            // 
            // passwordHashLabel
            // 
            passwordHashLabel.AutoSize = true;
            passwordHashLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordHashLabel.Location = new System.Drawing.Point(369, 190);
            passwordHashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            passwordHashLabel.Name = "passwordHashLabel";
            passwordHashLabel.Size = new System.Drawing.Size(82, 18);
            passwordHashLabel.TabIndex = 20;
            passwordHashLabel.Text = "Password:";
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Text.Location = new System.Drawing.Point(453, 119);
            Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Text.Name = "Text";
            Text.Size = new System.Drawing.Size(148, 27);
            Text.TabIndex = 22;
            Text.Text = "Меню Входу";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(704, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 24);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(-1, -5);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 17;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogoMain
            // 
            this.LogoMain.BackColor = System.Drawing.Color.Transparent;
            this.LogoMain.Image = global::BookWarm.Properties.Resources.Без_назви_1;
            this.LogoMain.Location = new System.Drawing.Point(6, 76);
            this.LogoMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoMain.Name = "LogoMain";
            this.LogoMain.Size = new System.Drawing.Size(363, 299);
            this.LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMain.TabIndex = 16;
            this.LogoMain.TabStop = false;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextBox.Location = new System.Drawing.Point(477, 164);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameTextBox.Size = new System.Drawing.Size(192, 19);
            this.usernameTextBox.TabIndex = 19;
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordHashTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordHashTextBox.Location = new System.Drawing.Point(477, 189);
            this.passwordHashTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.PasswordChar = '*';
            this.passwordHashTextBox.Size = new System.Drawing.Size(192, 19);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(369, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Забули пароль?";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowPassword.Location = new System.Drawing.Point(676, 190);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(27, 18);
            this.ShowPassword.TabIndex = 24;
            this.ShowPassword.Text = "👁️";
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // LoginInAccount
            // 
            LoginInAccount.AutoSize = true;
            LoginInAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LoginInAccount.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            LoginInAccount.Location = new System.Drawing.Point(484, 263);
            LoginInAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LoginInAccount.Name = "LoginInAccount";
            LoginInAccount.Size = new System.Drawing.Size(81, 29);
            LoginInAccount.TabIndex = 25;
            LoginInAccount.Text = "Увійти";
            LoginInAccount.Click += new System.EventHandler(this.LoginInAccount_Click);
            // 
            // ValidLoginAndPassword
            // 
            this.ValidLoginAndPassword.AutoSize = true;
            this.ValidLoginAndPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.ValidLoginAndPassword.Location = new System.Drawing.Point(474, 211);
            this.ValidLoginAndPassword.Name = "ValidLoginAndPassword";
            this.ValidLoginAndPassword.Size = new System.Drawing.Size(248, 13);
            this.ValidLoginAndPassword.TabIndex = 26;
            this.ValidLoginAndPassword.Text = "Користувача або пароль введено не правильно";
            this.ValidLoginAndPassword.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(739, 377);
            this.Controls.Add(this.ValidLoginAndPassword);
            this.Controls.Add(LoginInAccount);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(Text);
            this.Controls.Add(passwordHashLabel);
            this.Controls.Add(this.passwordHashTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogoMain);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ShowPassword;
        private System.Windows.Forms.Label ValidLoginAndPassword;
    }
}