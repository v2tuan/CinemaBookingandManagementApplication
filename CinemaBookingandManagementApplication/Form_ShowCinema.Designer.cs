namespace CinemaBookingandManagementApplication
{
    partial class Form_ShowCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShowCinema));
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.buttonAddMovieSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonMenu = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAddCinema = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelCinema = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.buttonRefresh);
            this.guna2ShadowPanel1.Controls.Add(this.buttonAddMovieSchedule);
            this.guna2ShadowPanel1.Controls.Add(this.buttonDelete);
            this.guna2ShadowPanel1.Controls.Add(this.textBoxSearch);
            this.guna2ShadowPanel1.Controls.Add(this.buttonMenu);
            this.guna2ShadowPanel1.Controls.Add(this.buttonAddCinema);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1490, 52);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // buttonAddMovieSchedule
            // 
            this.buttonAddMovieSchedule.BorderRadius = 3;
            this.buttonAddMovieSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddMovieSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddMovieSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddMovieSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddMovieSchedule.FillColor = System.Drawing.Color.Transparent;
            this.buttonAddMovieSchedule.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMovieSchedule.ForeColor = System.Drawing.Color.Black;
            this.buttonAddMovieSchedule.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddMovieSchedule.Image")));
            this.buttonAddMovieSchedule.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonAddMovieSchedule.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonAddMovieSchedule.Location = new System.Drawing.Point(756, 10);
            this.buttonAddMovieSchedule.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddMovieSchedule.Name = "buttonAddMovieSchedule";
            this.buttonAddMovieSchedule.Size = new System.Drawing.Size(240, 32);
            this.buttonAddMovieSchedule.TabIndex = 4;
            this.buttonAddMovieSchedule.Text = "Add Movie Schedule";
            this.buttonAddMovieSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonAddMovieSchedule.Click += new System.EventHandler(this.buttonAddMovieSchedule_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BorderRadius = 3;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Black;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDelete.Location = new System.Drawing.Point(642, 10);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(108, 32);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSearch
            // 
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
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMenu.BorderRadius = 3;
            this.buttonMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonMenu.Location = new System.Drawing.Point(599, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(36, 32);
            this.buttonMenu.TabIndex = 1;
            // 
            // buttonAddCinema
            // 
            this.buttonAddCinema.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAddCinema.BorderRadius = 3;
            this.buttonAddCinema.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddCinema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddCinema.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAddCinema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAddCinema.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonAddCinema.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCinema.ForeColor = System.Drawing.Color.White;
            this.buttonAddCinema.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCinema.Image")));
            this.buttonAddCinema.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonAddCinema.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonAddCinema.Location = new System.Drawing.Point(403, 10);
            this.buttonAddCinema.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonAddCinema.Name = "buttonAddCinema";
            this.buttonAddCinema.Size = new System.Drawing.Size(195, 32);
            this.buttonAddCinema.TabIndex = 0;
            this.buttonAddCinema.Text = "Add Cinema";
            this.buttonAddCinema.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonAddCinema.Click += new System.EventHandler(this.buttonAddCinema_Click);
            // 
            // flowLayoutPanelCinema
            // 
            this.flowLayoutPanelCinema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCinema.AutoScroll = true;
            this.flowLayoutPanelCinema.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelCinema.Location = new System.Drawing.Point(18, 79);
            this.flowLayoutPanelCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelCinema.Name = "flowLayoutPanelCinema";
            this.flowLayoutPanelCinema.Size = new System.Drawing.Size(1450, 518);
            this.flowLayoutPanelCinema.TabIndex = 2;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRefresh.BorderRadius = 5;
            this.buttonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.White;
            this.buttonRefresh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonRefresh.Location = new System.Drawing.Point(1035, 10);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(159, 32);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form_ShowCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1490, 624);
            this.Controls.Add(this.flowLayoutPanelCinema);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ShowCinema";
            this.Text = "Form_ShowCinema";
            this.Load += new System.EventHandler(this.Form_ShowCinema_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button buttonAddMovieSchedule;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonMenu;
        private Guna.UI2.WinForms.Guna2Button buttonAddCinema;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCinema;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
    }
}