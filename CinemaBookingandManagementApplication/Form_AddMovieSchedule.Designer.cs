namespace CinemaBookingandManagementApplication
{
    partial class Form_AddMovieSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddMovieSchedule));
            this.pic_movie = new Guna.UI2.WinForms.Guna2PictureBox();
            this.comboBoxType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Cinema = new System.Windows.Forms.Label();
            this.DateTimePickerRelease = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textDuration = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_movie
            // 
            this.pic_movie.BorderRadius = 10;
            this.pic_movie.Image = ((System.Drawing.Image)(resources.GetObject("pic_movie.Image")));
            this.pic_movie.ImageRotate = 0F;
            this.pic_movie.Location = new System.Drawing.Point(227, 86);
            this.pic_movie.Name = "pic_movie";
            this.pic_movie.Size = new System.Drawing.Size(150, 225);
            this.pic_movie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_movie.TabIndex = 12;
            this.pic_movie.TabStop = false;
            this.pic_movie.Click += new System.EventHandler(this.pic_movie_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxType.BorderColor = System.Drawing.Color.Gray;
            this.comboBoxType.BorderRadius = 5;
            this.comboBoxType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.comboBoxType.ItemHeight = 35;
            this.comboBoxType.Location = new System.Drawing.Point(43, 364);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(532, 41);
            this.comboBoxType.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(39, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Movie";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Gray;
            this.guna2ComboBox1.BorderRadius = 5;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.guna2ComboBox1.ItemHeight = 35;
            this.guna2ComboBox1.Location = new System.Drawing.Point(43, 462);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(532, 41);
            this.guna2ComboBox1.TabIndex = 32;
            // 
            // Cinema
            // 
            this.Cinema.AutoSize = true;
            this.Cinema.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinema.Location = new System.Drawing.Point(42, 428);
            this.Cinema.Name = "Cinema";
            this.Cinema.Size = new System.Drawing.Size(88, 23);
            this.Cinema.TabIndex = 31;
            this.Cinema.Text = "Cinema";
            // 
            // DateTimePickerRelease
            // 
            this.DateTimePickerRelease.BorderRadius = 5;
            this.DateTimePickerRelease.Checked = true;
            this.DateTimePickerRelease.FillColor = System.Drawing.Color.White;
            this.DateTimePickerRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerRelease.Location = new System.Drawing.Point(43, 669);
            this.DateTimePickerRelease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateTimePickerRelease.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerRelease.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerRelease.Name = "DateTimePickerRelease";
            this.DateTimePickerRelease.Size = new System.Drawing.Size(262, 41);
            this.DateTimePickerRelease.TabIndex = 40;
            this.DateTimePickerRelease.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 631);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Release date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 41;
            this.label1.Text = "Add Movie Schedule";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 5;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(41, 773);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(263, 41);
            this.guna2DateTimePicker1.TabIndex = 43;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 746);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Release date";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderRadius = 5;
            this.guna2DateTimePicker2.Checked = true;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(337, 773);
            this.guna2DateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(238, 41);
            this.guna2DateTimePicker2.TabIndex = 45;
            this.guna2DateTimePicker2.Value = new System.DateTime(2024, 10, 17, 9, 15, 17, 185);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 746);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Release date";
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.Gray;
            this.guna2ComboBox2.BorderRadius = 5;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.guna2ComboBox2.ItemHeight = 35;
            this.guna2ComboBox2.Location = new System.Drawing.Point(43, 564);
            this.guna2ComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(262, 41);
            this.guna2ComboBox2.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 46;
            this.label4.Text = "Room";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Seat Empty";
            // 
            // textDuration
            // 
            this.textDuration.BorderColor = System.Drawing.Color.Gray;
            this.textDuration.BorderRadius = 5;
            this.textDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textDuration.DefaultText = "";
            this.textDuration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textDuration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textDuration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDuration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textDuration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDuration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textDuration.Location = new System.Drawing.Point(337, 564);
            this.textDuration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textDuration.Name = "textDuration";
            this.textDuration.PasswordChar = '\0';
            this.textDuration.PlaceholderText = "Input Duration";
            this.textDuration.SelectedText = "";
            this.textDuration.Size = new System.Drawing.Size(238, 41);
            this.textDuration.TabIndex = 49;
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
            this.buttonAdd.Location = new System.Drawing.Point(43, 875);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(529, 59);
            this.buttonAdd.TabIndex = 50;
            this.buttonAdd.Text = "Add Movie";
            // 
            // Form_AddMovieSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 965);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDuration);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePickerRelease);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.Cinema);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pic_movie);
            this.Name = "Form_AddMovieSchedule";
            this.Text = "Form_AddMovieSchedule";
            this.Load += new System.EventHandler(this.Form_AddMovieSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_movie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox pic_movie;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxType;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label Cinema;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerRelease;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textDuration;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
    }
}