namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Room));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonRoom = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.buttonRoom);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(225, 225);
            this.guna2Panel1.TabIndex = 0;
            // 
            // buttonRoom
            // 
            this.buttonRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRoom.FillColor = System.Drawing.Color.Transparent;
            this.buttonRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.ForeColor = System.Drawing.Color.Black;
            this.buttonRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoom.Image")));
            this.buttonRoom.ImageOffset = new System.Drawing.Point(0, 10);
            this.buttonRoom.ImageSize = new System.Drawing.Size(80, 80);
            this.buttonRoom.Location = new System.Drawing.Point(0, 0);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(225, 225);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.TextOffset = new System.Drawing.Point(0, 10);
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // UserControl_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControl_Room";
            this.Size = new System.Drawing.Size(225, 225);
            this.Load += new System.EventHandler(this.UserControl_Room_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TileButton buttonRoom;
    }
}
