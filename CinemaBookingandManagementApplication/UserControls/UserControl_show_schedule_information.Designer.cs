namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_show_schedule_information
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl_show_schedule1 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.userControl_show_schedule2 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.userControl_show_schedule3 = new CinemaBookingandManagementApplication.UserControls.UserControl_show_schedule();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Galaxy Nguyễn Du";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.userControl_show_schedule1);
            this.flowLayoutPanel1.Controls.Add(this.userControl_show_schedule2);
            this.flowLayoutPanel1.Controls.Add(this.userControl_show_schedule3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 63);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1718, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1718, 55);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // userControl_show_schedule1
            // 
            this.userControl_show_schedule1.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule1.Location = new System.Drawing.Point(5, 5);
            this.userControl_show_schedule1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule1.Name = "userControl_show_schedule1";
            this.userControl_show_schedule1.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule1.TabIndex = 3;
            // 
            // userControl_show_schedule2
            // 
            this.userControl_show_schedule2.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule2.Location = new System.Drawing.Point(195, 5);
            this.userControl_show_schedule2.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule2.Name = "userControl_show_schedule2";
            this.userControl_show_schedule2.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule2.TabIndex = 4;
            // 
            // userControl_show_schedule3
            // 
            this.userControl_show_schedule3.BackColor = System.Drawing.Color.Transparent;
            this.userControl_show_schedule3.Location = new System.Drawing.Point(385, 5);
            this.userControl_show_schedule3.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_show_schedule3.Name = "userControl_show_schedule3";
            this.userControl_show_schedule3.Size = new System.Drawing.Size(180, 45);
            this.userControl_show_schedule3.TabIndex = 5;
            // 
            // UserControl_show_schedule_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_show_schedule_information";
            this.Size = new System.Drawing.Size(1805, 134);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControl_show_schedule userControl_show_schedule1;
        private UserControl_show_schedule userControl_show_schedule2;
        private UserControl_show_schedule userControl_show_schedule3;
    }
}
