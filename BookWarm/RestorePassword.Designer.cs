namespace BookWarm
{
    partial class RestorePassword
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
            System.Windows.Forms.Label Text;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label ChangePassword;
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Label();
            this.LogoMain = new System.Windows.Forms.PictureBox();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.ValidLoginAndEmail = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            Text = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ChangePassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Text.Location = new System.Drawing.Point(453, 119);
            Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Text.Name = "Text";
            Text.Size = new System.Drawing.Size(148, 27);
            Text.TabIndex = 34;
            Text.Text = "Меню Входу";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(369, 200);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 18);
            emailLabel.TabIndex = 32;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(477, 199);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '*';
            this.emailTextBox.Size = new System.Drawing.Size(192, 19);
            this.emailTextBox.TabIndex = 33;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.Location = new System.Drawing.Point(369, 164);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(87, 18);
            usernameLabel.TabIndex = 30;
            usernameLabel.Text = "Username:";
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
            this.usernameTextBox.TabIndex = 31;
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
            this.Back.TabIndex = 29;
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
            this.LogoMain.TabIndex = 28;
            this.LogoMain.TabStop = false;
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
            // ValidLoginAndEmail
            // 
            this.ValidLoginAndEmail.AutoSize = true;
            this.ValidLoginAndEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.ValidLoginAndEmail.Location = new System.Drawing.Point(474, 221);
            this.ValidLoginAndEmail.Name = "ValidLoginAndEmail";
            this.ValidLoginAndEmail.Size = new System.Drawing.Size(236, 13);
            this.ValidLoginAndEmail.TabIndex = 38;
            this.ValidLoginAndEmail.Text = "Користувача або email введено не правильно";
            this.ValidLoginAndEmail.Visible = false;
            // 
            // ChangePassword
            // 
            ChangePassword.AutoSize = true;
            ChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ChangePassword.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ChangePassword.Location = new System.Drawing.Point(440, 261);
            ChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new System.Drawing.Size(183, 29);
            ChangePassword.TabIndex = 37;
            ChangePassword.Text = "Змінити пароль";
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
            this.Exit.TabIndex = 27;
            this.Exit.Text = "Х";
            // 
            // RestorePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(739, 377);
            this.Controls.Add(Text);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogoMain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ValidLoginAndEmail);
            this.Controls.Add(ChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RestorePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestorePassword";
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox LogoMain;
        private BookWarmDBDataSet bookWarmDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BookWarmDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BookWarmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label ValidLoginAndEmail;
        private System.Windows.Forms.Label Exit;
    }
}