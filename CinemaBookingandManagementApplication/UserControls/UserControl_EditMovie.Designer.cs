namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_EditMovie
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_EditMovie));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pic_movie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pic_movie
            // 
            this.pic_movie.BorderRadius = 10;
            this.pic_movie.Image = ((System.Drawing.Image)(resources.GetObject("pic_movie.Image")));
            this.pic_movie.ImageRotate = 0F;
            this.pic_movie.Location = new System.Drawing.Point(0, 0);
            this.pic_movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(178, 240);
            this.pic_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_movie.TabIndex = 7;
            this.pic_movie.TabStop = false;
            this.pic_movie.Click += new System.EventHandler(this.pic_movie_Click);
            this.pic_movie.MouseEnter += new System.EventHandler(this.pic_movie_MouseEnter);
            this.pic_movie.MouseLeave += new System.EventHandler(this.pic_movie_MouseLeave);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(8, 254);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 18);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Robot Hoang Dã";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(148)))), ((int)(((byte)(64)))));
            this.btn_edit.BorderRadius = 10;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.FillColor = System.Drawing.Color.Transparent;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btn_edit.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_edit.Location = new System.Drawing.Point(68, 0);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(110, 36);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextOffset = new System.Drawing.Point(0, -1);
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            this.btn_edit.MouseEnter += new System.EventHandler(this.btn_edit_MouseEnter);
            // 
            // UserControl_EditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pic_movie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControl_EditMovie";
            this.Size = new System.Drawing.Size(178, 282);
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2PictureBox pic_movie;
    }
}
