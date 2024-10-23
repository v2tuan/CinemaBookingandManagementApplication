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
            CinemaBookingandManagementApplication.models.Cinemas cinemas1 = new CinemaBookingandManagementApplication.models.Cinemas();
            CinemaBookingandManagementApplication.models.Cinemas cinemas2 = new CinemaBookingandManagementApplication.models.Cinemas();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.buttonAddMovieSchedule = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonMenu = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAddCinema = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelCinema = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl_Cinemas1 = new CinemaBookingandManagementApplication.UserControls.UserControl_Cinemas();
            this.userControl_Cinemas2 = new CinemaBookingandManagementApplication.UserControls.UserControl_Cinemas();
            this.guna2ShadowPanel1.SuspendLayout();
            this.flowLayoutPanelCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.buttonAddMovieSchedule);
            this.guna2ShadowPanel1.Controls.Add(this.buttonDelete);
            this.guna2ShadowPanel1.Controls.Add(this.textBoxSearch);
            this.guna2ShadowPanel1.Controls.Add(this.buttonMenu);
            this.guna2ShadowPanel1.Controls.Add(this.buttonAddCinema);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1676, 65);
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
            this.buttonAddMovieSchedule.Location = new System.Drawing.Point(851, 13);
            this.buttonAddMovieSchedule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddMovieSchedule.Name = "buttonAddMovieSchedule";
            this.buttonAddMovieSchedule.Size = new System.Drawing.Size(270, 40);
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
            this.buttonDelete.Location = new System.Drawing.Point(722, 13);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(121, 40);
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
            this.textBoxSearch.Location = new System.Drawing.Point(20, 13);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PasswordChar = '\0';
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.SelectedText = "";
            this.textBoxSearch.Size = new System.Drawing.Size(425, 40);
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
            this.buttonMenu.Location = new System.Drawing.Point(674, 13);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 40);
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
            this.buttonAddCinema.Location = new System.Drawing.Point(453, 13);
            this.buttonAddCinema.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddCinema.Name = "buttonAddCinema";
            this.buttonAddCinema.Size = new System.Drawing.Size(219, 40);
            this.buttonAddCinema.TabIndex = 0;
            this.buttonAddCinema.Text = "Add Cinema";
            this.buttonAddCinema.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonAddCinema.Click += new System.EventHandler(this.buttonAddCinema_Click);
            // 
            // flowLayoutPanelCinema
            // 
            this.flowLayoutPanelCinema.AutoSize = true;
            this.flowLayoutPanelCinema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelCinema.Controls.Add(this.userControl_Cinemas1);
            this.flowLayoutPanelCinema.Controls.Add(this.userControl_Cinemas2);
            this.flowLayoutPanelCinema.Location = new System.Drawing.Point(20, 93);
            this.flowLayoutPanelCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelCinema.MaximumSize = new System.Drawing.Size(1615, 0);
            this.flowLayoutPanelCinema.Name = "flowLayoutPanelCinema";
            this.flowLayoutPanelCinema.Size = new System.Drawing.Size(1604, 392);
            this.flowLayoutPanelCinema.TabIndex = 12;
            // 
            // userControl_Cinemas1
            // 
            this.userControl_Cinemas1.BackColor = System.Drawing.Color.Transparent;
            cinemas1.Area = null;
            cinemas1.Caddress = null;
            cinemas1.Cid = null;
            cinemas1.Cname = null;
            cinemas1.Hotline = null;
            cinemas1.Image = null;
            this.userControl_Cinemas1.cinema = cinemas1;
            this.userControl_Cinemas1.CinemaId = null;
            this.userControl_Cinemas1.Location = new System.Drawing.Point(6, 6);
            this.userControl_Cinemas1.Margin = new System.Windows.Forms.Padding(6);
            this.userControl_Cinemas1.Name = "userControl_Cinemas1";
            this.userControl_Cinemas1.Size = new System.Drawing.Size(1592, 184);
            this.userControl_Cinemas1.TabIndex = 0;
            // 
            // userControl_Cinemas2
            // 
            this.userControl_Cinemas2.BackColor = System.Drawing.Color.Transparent;
            cinemas2.Area = null;
            cinemas2.Caddress = null;
            cinemas2.Cid = null;
            cinemas2.Cname = null;
            cinemas2.Hotline = null;
            cinemas2.Image = null;
            this.userControl_Cinemas2.cinema = cinemas2;
            this.userControl_Cinemas2.CinemaId = null;
            this.userControl_Cinemas2.Location = new System.Drawing.Point(6, 202);
            this.userControl_Cinemas2.Margin = new System.Windows.Forms.Padding(6);
            this.userControl_Cinemas2.Name = "userControl_Cinemas2";
            this.userControl_Cinemas2.Size = new System.Drawing.Size(1592, 184);
            this.userControl_Cinemas2.TabIndex = 1;
            // 
            // Form_ShowCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1676, 780);
            this.Controls.Add(this.flowLayoutPanelCinema);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "Form_ShowCinema";
            this.Text = "Form_ShowCinema";
            this.Load += new System.EventHandler(this.Form_ShowCinema_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.flowLayoutPanelCinema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button buttonAddMovieSchedule;
        private Guna.UI2.WinForms.Guna2Button buttonDelete;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonMenu;
        private Guna.UI2.WinForms.Guna2Button buttonAddCinema;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCinema;
        private UserControls.UserControl_Cinemas userControl_Cinemas1;
        private UserControls.UserControl_Cinemas userControl_Cinemas2;
    }
}