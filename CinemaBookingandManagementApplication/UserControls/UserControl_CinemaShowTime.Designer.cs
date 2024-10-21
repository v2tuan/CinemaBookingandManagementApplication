namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_CinemaShowTime
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
            this.labelCinemaName = new System.Windows.Forms.Label();
            this.flowLayoutPanelShowTime = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl_show_schedule1 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.userControl_show_schedule2 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.userControl_show_schedule3 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelShowTime.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCinemaName
            // 
            this.labelCinemaName.AutoSize = true;
            this.labelCinemaName.BackColor = System.Drawing.Color.Transparent;
            this.labelCinemaName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinemaName.Location = new System.Drawing.Point(43, 23);
            this.labelCinemaName.Name = "labelCinemaName";
            this.labelCinemaName.Size = new System.Drawing.Size(290, 30);
            this.labelCinemaName.TabIndex = 0;
            this.labelCinemaName.Text = "Galaxy Kinh Dương Vương";
            // 
            // flowLayoutPanelShowTime
            // 
            this.flowLayoutPanelShowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelShowTime.AutoSize = true;
            this.flowLayoutPanelShowTime.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelShowTime.Controls.Add(this.userControl_show_schedule1);
            this.flowLayoutPanelShowTime.Controls.Add(this.userControl_show_schedule2);
            this.flowLayoutPanelShowTime.Controls.Add(this.userControl_show_schedule3);
            this.flowLayoutPanelShowTime.Location = new System.Drawing.Point(48, 72);
            this.flowLayoutPanelShowTime.MaximumSize = new System.Drawing.Size(1354, 0);
            this.flowLayoutPanelShowTime.Name = "flowLayoutPanelShowTime";
            this.flowLayoutPanelShowTime.Size = new System.Drawing.Size(1330, 55);
            this.flowLayoutPanelShowTime.TabIndex = 1;
            // 
            // userControl_show_schedule1
            // 
            this.userControl_show_schedule1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule1.Location = new System.Drawing.Point(5, 5);
            this.userControl_show_schedule1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule1.movieSchedule = null;
            this.userControl_show_schedule1.Name = "userControl_show_schedule1";
            this.userControl_show_schedule1.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule1.TabIndex = 0;
            // 
            // userControl_show_schedule2
            // 
            this.userControl_show_schedule2.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule2.Location = new System.Drawing.Point(195, 5);
            this.userControl_show_schedule2.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule2.movieSchedule = null;
            this.userControl_show_schedule2.Name = "userControl_show_schedule2";
            this.userControl_show_schedule2.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule2.TabIndex = 1;
            // 
            // userControl_show_schedule3
            // 
            this.userControl_show_schedule3.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule3.Location = new System.Drawing.Point(385, 5);
            this.userControl_show_schedule3.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule3.movieSchedule = null;
            this.userControl_show_schedule3.Name = "userControl_show_schedule3";
            this.userControl_show_schedule3.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule3.TabIndex = 2;
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.Controls.Add(this.labelCinemaName);
            this.panelBackground.Controls.Add(this.flowLayoutPanelShowTime);
            this.panelBackground.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.panelBackground.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1435, 150);
            this.panelBackground.TabIndex = 2;
            // 
            // UserControl_CinemaShowTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBackground);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1435, 150);
            this.Name = "UserControl_CinemaShowTime";
            this.Size = new System.Drawing.Size(1435, 150);
            this.Load += new System.EventHandler(this.UserControl_CinemaShowTime_Load);
            this.flowLayoutPanelShowTime.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCinemaName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShowTime;
        private UserControl_show_schedule userControl_show_schedule1;
        private UserControl_show_schedule userControl_show_schedule2;
        private UserControl_show_schedule userControl_show_schedule3;
        private Guna.UI2.WinForms.Guna2Panel panelBackground;
    }
}
