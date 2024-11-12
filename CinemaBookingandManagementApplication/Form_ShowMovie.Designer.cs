namespace CinemaBookingandManagementApplication
{
    partial class Form_ShowMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShowMovie));
            this.flowLayoutPanelMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dateTimePickerDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMovie
            // 
            this.flowLayoutPanelMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMovie.AutoScroll = true;
            this.flowLayoutPanelMovie.Location = new System.Drawing.Point(18, 65);
            this.flowLayoutPanelMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMovie.Name = "flowLayoutPanelMovie";
            this.flowLayoutPanelMovie.Size = new System.Drawing.Size(1468, 587);
            this.flowLayoutPanelMovie.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearch.BorderColor = System.Drawing.Color.Black;
            this.textBoxSearch.BorderRadius = 5;
            this.textBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSearch.DefaultText = "";
            this.textBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("textBoxSearch.IconLeft")));
            this.textBoxSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.textBoxSearch.Location = new System.Drawing.Point(18, 10);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(378, 32);
            this.textBoxSearch.TabIndex = 2;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.dateTimePickerDate);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.textBoxSearch);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1509, 52);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Checked = true;
            this.dateTimePickerDate.FillColor = System.Drawing.Color.White;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDate.Location = new System.Drawing.Point(611, 12);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(259, 29);
            this.dateTimePickerDate.TabIndex = 8;
            this.dateTimePickerDate.Value = new System.DateTime(2024, 10, 15, 0, 50, 20, 592);
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chọn ngày chiếu:";
            // 
            // Form_ShowMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 669);
            this.Controls.Add(this.flowLayoutPanelMovie);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ShowMovie";
            this.Text = "Form_ShowMovie";
            this.Load += new System.EventHandler(this.Form_ShowMovie_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovie;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label7;
    }
}