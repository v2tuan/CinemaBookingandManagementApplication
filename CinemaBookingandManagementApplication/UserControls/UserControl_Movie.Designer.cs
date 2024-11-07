namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_Movie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Movie));
            this.btn_buy = new Guna.UI2.WinForms.Guna2Button();
            this.pic_cover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pic_movie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(47)))));
            this.btn_buy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_buy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_buy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_buy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_buy.FillColor = System.Drawing.Color.Transparent;
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Image = ((System.Drawing.Image)(resources.GetObject("btn_buy.Image")));
            this.btn_buy.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_buy.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_buy.Location = new System.Drawing.Point(43, 124);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(124, 45);
            this.btn_buy.TabIndex = 1;
            this.btn_buy.Text = "Buy";
            this.btn_buy.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            this.btn_buy.MouseEnter += new System.EventHandler(this.btn_buy_MouseEnter);
            // 
            // pic_cover
            // 
            this.pic_cover.BackColor = System.Drawing.Color.Transparent;
            this.pic_cover.BorderRadius = 10;
            this.pic_cover.FillColor = System.Drawing.Color.Transparent;
            this.pic_cover.Image = ((System.Drawing.Image)(resources.GetObject("pic_cover.Image")));
            this.pic_cover.ImageRotate = 0F;
            this.pic_cover.Location = new System.Drawing.Point(0, 0);
            this.pic_cover.Name = "pic_cover";
            this.pic_cover.Size = new System.Drawing.Size(200, 300);
            this.pic_cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cover.TabIndex = 2;
            this.pic_cover.TabStop = false;
            this.pic_cover.UseTransparentBackground = true;
            this.pic_cover.MouseLeave += new System.EventHandler(this.pic_movie_MouseLeave);
            // 
            // pic_movie
            // 
            this.pic_movie.BorderRadius = 10;
            this.pic_movie.Image = ((System.Drawing.Image)(resources.GetObject("pic_movie.Image")));
            this.pic_movie.ImageRotate = 0F;
            this.pic_movie.Location = new System.Drawing.Point(0, 0);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(200, 300);
            this.pic_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_movie.TabIndex = 3;
            this.pic_movie.TabStop = false;
            this.pic_movie.MouseEnter += new System.EventHandler(this.pic_movie_MouseEnter);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(9, 314);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(158, 22);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Robot Hoang Dã";
            // 
            // UserControl_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.pic_cover);
            this.Controls.Add(this.pic_movie);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControl_Movie";
            this.Size = new System.Drawing.Size(200, 352);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_buy;
        private Guna.UI2.WinForms.Guna2PictureBox pic_cover;
        private Guna.UI2.WinForms.Guna2PictureBox pic_movie;
        private System.Windows.Forms.Label labelName;
    }
}
