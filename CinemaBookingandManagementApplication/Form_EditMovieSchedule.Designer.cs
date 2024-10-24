﻿namespace CinemaBookingandManagementApplication
{
    partial class Form_EditMovieSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditMovieSchedule));
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textboxSeatEmpty = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFinishTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerShowtime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerRelease = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCinema = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cinema = new System.Windows.Forms.Label();
            this.comboBoxMovie = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pic_movie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAdd.BorderRadius = 5;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonAdd.Location = new System.Drawing.Point(53, 710);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(470, 47);
            this.buttonAdd.TabIndex = 67;
            this.buttonAdd.Text = "Add Movie Schedule";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 65;
            this.label7.Text = "Seat Empty";
            // 
            // textboxSeatEmpty
            // 
            this.textboxSeatEmpty.BorderColor = System.Drawing.Color.Gray;
            this.textboxSeatEmpty.BorderRadius = 5;
            this.textboxSeatEmpty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxSeatEmpty.DefaultText = "";
            this.textboxSeatEmpty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxSeatEmpty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxSeatEmpty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSeatEmpty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxSeatEmpty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSeatEmpty.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSeatEmpty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxSeatEmpty.Location = new System.Drawing.Point(315, 454);
            this.textboxSeatEmpty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxSeatEmpty.Name = "textboxSeatEmpty";
            this.textboxSeatEmpty.PasswordChar = '\0';
            this.textboxSeatEmpty.PlaceholderText = "Input Duration";
            this.textboxSeatEmpty.SelectedText = "";
            this.textboxSeatEmpty.Size = new System.Drawing.Size(212, 33);
            this.textboxSeatEmpty.TabIndex = 66;
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxRoom.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxRoom.BorderRadius = 5;
            this.comboBoxRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.comboBoxRoom.ItemHeight = 35;
            this.comboBoxRoom.Location = new System.Drawing.Point(53, 454);
            this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(233, 41);
            this.comboBoxRoom.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Room";
            // 
            // dateTimePickerFinishTime
            // 
            this.dateTimePickerFinishTime.BorderRadius = 5;
            this.dateTimePickerFinishTime.Checked = true;
            this.dateTimePickerFinishTime.FillColor = System.Drawing.Color.White;
            this.dateTimePickerFinishTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFinishTime.Location = new System.Drawing.Point(315, 621);
            this.dateTimePickerFinishTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFinishTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFinishTime.Name = "dateTimePickerFinishTime";
            this.dateTimePickerFinishTime.ShowUpDown = true;
            this.dateTimePickerFinishTime.Size = new System.Drawing.Size(212, 33);
            this.dateTimePickerFinishTime.TabIndex = 62;
            this.dateTimePickerFinishTime.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 61;
            this.label3.Text = "Finish time";
            // 
            // dateTimePickerShowtime
            // 
            this.dateTimePickerShowtime.BorderRadius = 5;
            this.dateTimePickerShowtime.Checked = true;
            this.dateTimePickerShowtime.FillColor = System.Drawing.Color.White;
            this.dateTimePickerShowtime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerShowtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerShowtime.Location = new System.Drawing.Point(52, 621);
            this.dateTimePickerShowtime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerShowtime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerShowtime.Name = "dateTimePickerShowtime";
            this.dateTimePickerShowtime.ShowUpDown = true;
            this.dateTimePickerShowtime.Size = new System.Drawing.Size(234, 33);
            this.dateTimePickerShowtime.TabIndex = 60;
            this.dateTimePickerShowtime.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Showtime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 23);
            this.label1.TabIndex = 58;
            this.label1.Text = "Add Movie Schedule";
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.BorderRadius = 5;
            this.dateTimePickerRelease.Checked = true;
            this.dateTimePickerRelease.FillColor = System.Drawing.Color.White;
            this.dateTimePickerRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRelease.Location = new System.Drawing.Point(53, 538);
            this.dateTimePickerRelease.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerRelease.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(233, 33);
            this.dateTimePickerRelease.TabIndex = 57;
            this.dateTimePickerRelease.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Release date";
            // 
            // comboBoxCinema
            // 
            this.comboBoxCinema.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCinema.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxCinema.BorderRadius = 5;
            this.comboBoxCinema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCinema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinema.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCinema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCinema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCinema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCinema.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.comboBoxCinema.ItemHeight = 35;
            this.comboBoxCinema.Location = new System.Drawing.Point(53, 372);
            this.comboBoxCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCinema.Name = "comboBoxCinema";
            this.comboBoxCinema.Size = new System.Drawing.Size(473, 41);
            this.comboBoxCinema.TabIndex = 55;
            // 
            // Cinema
            // 
            this.Cinema.AutoSize = true;
            this.Cinema.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinema.Location = new System.Drawing.Point(52, 345);
            this.Cinema.Name = "Cinema";
            this.Cinema.Size = new System.Drawing.Size(74, 19);
            this.Cinema.TabIndex = 54;
            this.Cinema.Text = "Cinema";
            // 
            // comboBoxMovie
            // 
            this.comboBoxMovie.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxMovie.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxMovie.BorderRadius = 5;
            this.comboBoxMovie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMovie.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMovie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxMovie.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxMovie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.comboBoxMovie.ItemHeight = 35;
            this.comboBoxMovie.Location = new System.Drawing.Point(53, 294);
            this.comboBoxMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMovie.Name = "comboBoxMovie";
            this.comboBoxMovie.Size = new System.Drawing.Size(473, 41);
            this.comboBoxMovie.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 19);
            this.label14.TabIndex = 52;
            this.label14.Text = "Movie";
            // 
            // pic_movie
            // 
            this.pic_movie.BorderRadius = 10;
            this.pic_movie.Image = ((System.Drawing.Image)(resources.GetObject("pic_movie.Image")));
            this.pic_movie.ImageRotate = 0F;
            this.pic_movie.Location = new System.Drawing.Point(217, 71);
            this.pic_movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(133, 180);
            this.pic_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_movie.TabIndex = 51;
            this.pic_movie.TabStop = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.BorderRadius = 5;
            this.buttonDelete.BorderThickness = 1;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonDelete.Location = new System.Drawing.Point(53, 783);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(470, 47);
            this.buttonDelete.TabIndex = 68;
            this.buttonDelete.Text = "Delete";
            // 
            // Form_EditMovieSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(576, 844);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textboxSeatEmpty);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFinishTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerShowtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxCinema);
            this.Controls.Add(this.Cinema);
            this.Controls.Add(this.comboBoxMovie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pic_movie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_EditMovieSchedule";
            this.Text = "Form_EditMovieSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textboxSeatEmpty;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRoom;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerFinishTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerShowtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCinema;
        private System.Windows.Forms.Label Cinema;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMovie;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2PictureBox pic_movie;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
    }
}