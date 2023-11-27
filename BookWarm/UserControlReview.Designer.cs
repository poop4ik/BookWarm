namespace BookWarm
{
    partial class UserControlReview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Username = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.ReviewText = new System.Windows.Forms.TextBox();
            this.profilePhotoPictureBox = new BookWarm.Data.Elements.CustomeCirclePicture();
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.Username.Location = new System.Drawing.Point(109, 16);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(102, 23);
            this.Username.TabIndex = 66;
            this.Username.Text = "UserName";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTime
            // 
            this.DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTime.Location = new System.Drawing.Point(109, 44);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(166, 33);
            this.DateTime.TabIndex = 67;
            this.DateTime.Text = "DateTime";
            this.DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rating
            // 
            this.Rating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rating.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.Rating.Location = new System.Drawing.Point(226, 43);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(114, 33);
            this.Rating.TabIndex = 68;
            this.Rating.Text = "Rate";
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReviewText
            // 
            this.ReviewText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewText.BackColor = System.Drawing.Color.LightGray;
            this.ReviewText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReviewText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReviewText.Location = new System.Drawing.Point(108, 80);
            this.ReviewText.MaxLength = 120;
            this.ReviewText.Multiline = true;
            this.ReviewText.Name = "ReviewText";
            this.ReviewText.ReadOnly = true;
            this.ReviewText.Size = new System.Drawing.Size(904, 56);
            this.ReviewText.TabIndex = 212;
            this.ReviewText.Text = "Description";
            // 
            // profilePhotoPictureBox
            // 
            this.profilePhotoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.profilePhotoPictureBox.Border = 0;
            this.profilePhotoPictureBox.BorderCap = System.Drawing.Drawing2D.DashCap.Flat;
            this.profilePhotoPictureBox.Borderstyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.profilePhotoPictureBox.ColorBorder = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.ColorBorder2 = System.Drawing.Color.Black;
            this.profilePhotoPictureBox.Gradiant = 50F;
            this.profilePhotoPictureBox.Location = new System.Drawing.Point(33, 16);
            this.profilePhotoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePhotoPictureBox.MaximumSize = new System.Drawing.Size(200, 200);
            this.profilePhotoPictureBox.Name = "profilePhotoPictureBox";
            this.profilePhotoPictureBox.Size = new System.Drawing.Size(57, 57);
            this.profilePhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePhotoPictureBox.TabIndex = 34;
            this.profilePhotoPictureBox.TabStop = false;
            // 
            // UserControlReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ReviewText);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.profilePhotoPictureBox);
            this.Name = "UserControlReview";
            this.Size = new System.Drawing.Size(738, 149);
            ((System.ComponentModel.ISupportInitialize)(this.profilePhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Data.Elements.CustomeCirclePicture profilePhotoPictureBox;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.TextBox ReviewText;
    }
}
