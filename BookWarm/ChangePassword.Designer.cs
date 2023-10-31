namespace BookWarm
{
    partial class ChangePassword
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
            System.Windows.Forms.Label ConfirmChange;
            this.passwordHashTextBox = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Label();
            this.LogoMain = new System.Windows.Forms.PictureBox();
            this.bookWarmDBDataSet = new BookWarm.BookWarmDBDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new BookWarm.BookWarmDBDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new BookWarm.BookWarmDBDataSetTableAdapters.TableAdapterManager();
            this.confirmPasswordHashTextBox = new System.Windows.Forms.TextBox();
            this.emptytextbox = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.ValidPassword = new System.Windows.Forms.Label();
            Text = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ConfirmChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Text
            // 
            Text.AutoSize = true;
            Text.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Text.Location = new System.Drawing.Point(427, 115);
            Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Text.Name = "Text";
            Text.Size = new System.Drawing.Size(228, 27);
            Text.TabIndex = 47;
            Text.Text = "Меню зміни пароля";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(376, 199);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(143, 18);
            emailLabel.TabIndex = 46;
            emailLabel.Text = "Confirm password:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            usernameLabel.Location = new System.Drawing.Point(376, 163);
            usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(82, 18);
            usernameLabel.TabIndex = 44;
            usernameLabel.Text = "Password:";
            // 
            // passwordHashTextBox
            // 
            this.passwordHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordHashTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordHashTextBox.Location = new System.Drawing.Point(525, 163);
            this.passwordHashTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.passwordHashTextBox.Name = "passwordHashTextBox";
            this.passwordHashTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordHashTextBox.Size = new System.Drawing.Size(192, 19);
            this.passwordHashTextBox.TabIndex = 45;
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(6, -6);
            this.Back.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(47, 41);
            this.Back.TabIndex = 43;
            this.Back.Text = "←";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // LogoMain
            // 
            this.LogoMain.BackColor = System.Drawing.Color.Transparent;
            this.LogoMain.Image = global::BookWarm.Properties.Resources.Без_назви_1;
            this.LogoMain.Location = new System.Drawing.Point(13, 75);
            this.LogoMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LogoMain.Name = "LogoMain";
            this.LogoMain.Size = new System.Drawing.Size(363, 299);
            this.LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoMain.TabIndex = 42;
            this.LogoMain.TabStop = false;
            // 
            // ConfirmChange
            // 
            ConfirmChange.AutoSize = true;
            ConfirmChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ConfirmChange.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            ConfirmChange.Location = new System.Drawing.Point(447, 260);
            ConfirmChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ConfirmChange.Name = "ConfirmChange";
            ConfirmChange.Size = new System.Drawing.Size(146, 29);
            ConfirmChange.TabIndex = 48;
            ConfirmChange.Text = "Підтвердити";
            ConfirmChange.Click += new System.EventHandler(this.ConfirmChange_Click);
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
            // confirmPasswordHashTextBox
            // 
            this.confirmPasswordHashTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswordHashTextBox.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordHashTextBox.Location = new System.Drawing.Point(525, 199);
            this.confirmPasswordHashTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.confirmPasswordHashTextBox.Name = "confirmPasswordHashTextBox";
            this.confirmPasswordHashTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.confirmPasswordHashTextBox.Size = new System.Drawing.Size(192, 19);
            this.confirmPasswordHashTextBox.TabIndex = 51;
            // 
            // emptytextbox
            // 
            this.emptytextbox.AutoSize = true;
            this.emptytextbox.BackColor = System.Drawing.Color.Transparent;
            this.emptytextbox.ForeColor = System.Drawing.Color.Firebrick;
            this.emptytextbox.Location = new System.Drawing.Point(522, 221);
            this.emptytextbox.Name = "emptytextbox";
            this.emptytextbox.Size = new System.Drawing.Size(185, 26);
            this.emptytextbox.TabIndex = 50;
            this.emptytextbox.Text = "Будь ласка, заповніть обидва поля\r\n.";
            this.emptytextbox.Visible = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Arial Black", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(711, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 24);
            this.Exit.TabIndex = 41;
            this.Exit.Text = "Х";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ValidPassword
            // 
            this.ValidPassword.AutoSize = true;
            this.ValidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.ValidPassword.Location = new System.Drawing.Point(522, 221);
            this.ValidPassword.Name = "ValidPassword";
            this.ValidPassword.Size = new System.Drawing.Size(122, 13);
            this.ValidPassword.TabIndex = 49;
            this.ValidPassword.Text = "Паролі не співпадають";
            this.ValidPassword.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(739, 377);
            this.Controls.Add(Text);
            this.Controls.Add(emailLabel);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.passwordHashTextBox);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.LogoMain);
            this.Controls.Add(ConfirmChange);
            this.Controls.Add(this.confirmPasswordHashTextBox);
            this.Controls.Add(this.emptytextbox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ValidPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.LogoMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookWarmDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordHashTextBox;
        private System.Windows.Forms.Label Back;
        private System.Windows.Forms.PictureBox LogoMain;
        private BookWarmDBDataSet bookWarmDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private BookWarmDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private BookWarmDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox confirmPasswordHashTextBox;
        private System.Windows.Forms.Label emptytextbox;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label ValidPassword;
    }
}