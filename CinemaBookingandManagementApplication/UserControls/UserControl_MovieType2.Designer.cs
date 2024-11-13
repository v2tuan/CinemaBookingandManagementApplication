namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_MovieType2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_MovieType2));
            this.pic_movie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_movie
            // 
            this.pic_movie.BorderRadius = 10;
            this.pic_movie.Image = ((System.Drawing.Image)(resources.GetObject("pic_movie.Image")));
            this.pic_movie.ImageRotate = 0F;
            this.pic_movie.Location = new System.Drawing.Point(0, -1);
            this.pic_movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(100, 150);
            this.pic_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_movie.TabIndex = 8;
            this.pic_movie.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(141, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(170, 25);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Robot Hoang Dã";
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReleaseDate.ForeColor = System.Drawing.Color.DarkGray;
            this.labelReleaseDate.Location = new System.Drawing.Point(142, 43);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(144, 20);
            this.labelReleaseDate.TabIndex = 10;
            this.labelReleaseDate.Text = "Robot Hoang Dã";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(146, 66);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(140, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.labelReleaseDate);
            this.guna2Panel1.Controls.Add(this.labelName);
            this.guna2Panel1.Controls.Add(this.pic_movie);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(736, 150);
            this.guna2Panel1.TabIndex = 12;
            // 
            // UserControl_MovieType2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControl_MovieType2";
            this.Size = new System.Drawing.Size(736, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pic_movie;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelReleaseDate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
