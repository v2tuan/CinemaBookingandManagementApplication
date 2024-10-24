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
            this.panelBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCinemaName
            // 
            this.labelCinemaName.AutoSize = true;
            this.labelCinemaName.BackColor = System.Drawing.Color.Transparent;
            this.labelCinemaName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCinemaName.Location = new System.Drawing.Point(43, 22);
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
            this.flowLayoutPanelShowTime.Location = new System.Drawing.Point(48, 62);
            this.flowLayoutPanelShowTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelShowTime.MaximumSize = new System.Drawing.Size(1354, 0);
            this.flowLayoutPanelShowTime.Name = "flowLayoutPanelShowTime";
            this.flowLayoutPanelShowTime.Size = new System.Drawing.Size(1354, 0);
            this.flowLayoutPanelShowTime.TabIndex = 1;
            // 
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.Controls.Add(this.labelCinemaName);
            this.panelBackground.Controls.Add(this.flowLayoutPanelShowTime);
            this.panelBackground.CustomBorderColor = System.Drawing.Color.Gainsboro;
            this.panelBackground.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1614, 150);
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
            this.MinimumSize = new System.Drawing.Size(1436, 150);
            this.Name = "UserControl_CinemaShowTime";
            this.Size = new System.Drawing.Size(1614, 150);
            this.Load += new System.EventHandler(this.UserControl_CinemaShowTime_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCinemaName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelShowTime;
        private Guna.UI2.WinForms.Guna2Panel panelBackground;
    }
}
