namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_show_schedule
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
            this.btn_time = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_time
            // 
            this.btn_time.CustomBorderColor = System.Drawing.Color.LightGray;
            this.btn_time.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btn_time.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_time.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_time.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_time.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_time.FillColor = System.Drawing.Color.White;
            this.btn_time.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_time.ForeColor = System.Drawing.Color.Black;
            this.btn_time.Location = new System.Drawing.Point(0, 0);
            this.btn_time.Margin = new System.Windows.Forms.Padding(5);
            this.btn_time.Name = "btn_time";
            this.btn_time.Size = new System.Drawing.Size(180, 45);
            this.btn_time.TabIndex = 2;
            this.btn_time.Text = "10:00";
            this.btn_time.Click += new System.EventHandler(this.btn_time_Click);
            // 
            // UserControl_show_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_time);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_show_schedule";
            this.Size = new System.Drawing.Size(180, 45);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_time;
    }
}
