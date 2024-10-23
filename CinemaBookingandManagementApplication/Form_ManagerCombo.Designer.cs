namespace CinemaBookingandManagementApplication
{
    partial class Form_ManagerCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ManagerCombo));
            this.flowLayoutPanelCombo = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.buttonMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCombo = new Guna.UI2.WinForms.Guna2Button();
            this.userControl_EditCombo1 = new CinemaBookingandManagementApplication.UserControls.UserControl_EditCombo();
            this.userControl_EditCombo2 = new CinemaBookingandManagementApplication.UserControls.UserControl_EditCombo();
            this.userControl_EditCombo3 = new CinemaBookingandManagementApplication.UserControls.UserControl_EditCombo();
            this.userControl_EditCombo4 = new CinemaBookingandManagementApplication.UserControls.UserControl_EditCombo();
            this.buttonRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanelCombo.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCombo
            // 
            this.flowLayoutPanelCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelCombo.AutoScroll = true;
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_EditCombo1);
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_EditCombo2);
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_EditCombo3);
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_EditCombo4);
            this.flowLayoutPanelCombo.Location = new System.Drawing.Point(18, 78);
            this.flowLayoutPanelCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelCombo.Name = "flowLayoutPanelCombo";
            this.flowLayoutPanelCombo.Size = new System.Drawing.Size(1468, 587);
            this.flowLayoutPanelCombo.TabIndex = 10;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.buttonRefresh);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Button1);
            this.guna2ShadowPanel1.Controls.Add(this.textBoxSearch);
            this.guna2ShadowPanel1.Controls.Add(this.buttonMenu);
            this.guna2ShadowPanel1.Controls.Add(this.btnAddCombo);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 3;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.guna2ShadowPanel1.ShadowDepth = 50;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1509, 52);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(47)))), ((int)(((byte)(39)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(1015, 11);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(172, 32);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Best Seller";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonMenu.BorderRadius = 3;
            this.buttonMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(47)))), ((int)(((byte)(39)))));
            this.buttonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMenu.ForeColor = System.Drawing.Color.White;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonMenu.Location = new System.Drawing.Point(577, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(36, 32);
            this.buttonMenu.TabIndex = 1;
            // 
            // btnAddCombo
            // 
            this.btnAddCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCombo.BorderRadius = 3;
            this.btnAddCombo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCombo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCombo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(47)))), ((int)(((byte)(39)))));
            this.btnAddCombo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCombo.ForeColor = System.Drawing.Color.White;
            this.btnAddCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCombo.Image")));
            this.btnAddCombo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddCombo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddCombo.Location = new System.Drawing.Point(404, 10);
            this.btnAddCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddCombo.Name = "btnAddCombo";
            this.btnAddCombo.Size = new System.Drawing.Size(172, 32);
            this.btnAddCombo.TabIndex = 0;
            this.btnAddCombo.Text = "Add Combo";
            this.btnAddCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddCombo.Click += new System.EventHandler(this.btnAddCombo_Click);
            // 
            // userControl_EditCombo1
            // 
            this.userControl_EditCombo1.BackColor = System.Drawing.Color.White;
            this.userControl_EditCombo1.combo = null;
            this.userControl_EditCombo1.Location = new System.Drawing.Point(3, 2);
            this.userControl_EditCombo1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_EditCombo1.Name = "userControl_EditCombo1";
            this.userControl_EditCombo1.Size = new System.Drawing.Size(1465, 119);
            this.userControl_EditCombo1.TabIndex = 0;
            // 
            // userControl_EditCombo2
            // 
            this.userControl_EditCombo2.BackColor = System.Drawing.Color.White;
            this.userControl_EditCombo2.combo = null;
            this.userControl_EditCombo2.Location = new System.Drawing.Point(3, 125);
            this.userControl_EditCombo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_EditCombo2.Name = "userControl_EditCombo2";
            this.userControl_EditCombo2.Size = new System.Drawing.Size(1465, 119);
            this.userControl_EditCombo2.TabIndex = 1;
            // 
            // userControl_EditCombo3
            // 
            this.userControl_EditCombo3.BackColor = System.Drawing.Color.White;
            this.userControl_EditCombo3.combo = null;
            this.userControl_EditCombo3.Location = new System.Drawing.Point(3, 248);
            this.userControl_EditCombo3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_EditCombo3.Name = "userControl_EditCombo3";
            this.userControl_EditCombo3.Size = new System.Drawing.Size(1465, 119);
            this.userControl_EditCombo3.TabIndex = 2;
            // 
            // userControl_EditCombo4
            // 
            this.userControl_EditCombo4.BackColor = System.Drawing.Color.White;
            this.userControl_EditCombo4.combo = null;
            this.userControl_EditCombo4.Location = new System.Drawing.Point(3, 371);
            this.userControl_EditCombo4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControl_EditCombo4.Name = "userControl_EditCombo4";
            this.userControl_EditCombo4.Size = new System.Drawing.Size(1465, 119);
            this.userControl_EditCombo4.TabIndex = 3;
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
            this.buttonRefresh.Location = new System.Drawing.Point(741, 10);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(159, 32);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form_ManagerCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 669);
            this.Controls.Add(this.flowLayoutPanelCombo);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ManagerCombo";
            this.Text = "Form_ManagerCombo";
            this.Load += new System.EventHandler(this.Form_ManagerCombo_Load);
            this.flowLayoutPanelCombo.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCombo;
        private UserControls.UserControl_EditCombo userControl_EditCombo1;
        private UserControls.UserControl_EditCombo userControl_EditCombo2;
        private UserControls.UserControl_EditCombo userControl_EditCombo3;
        private UserControls.UserControl_EditCombo userControl_EditCombo4;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
        private Guna.UI2.WinForms.Guna2Button buttonMenu;
        private Guna.UI2.WinForms.Guna2Button btnAddCombo;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button buttonRefresh;
    }
}