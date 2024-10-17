namespace CinemaBookingandManagementApplication
{
    partial class Form1
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
            this.userControl_Movie1 = new CinemaBookingandManagementApplication.UserControls.UserControl_Movie();
            this.SuspendLayout();
            // 
            // userControl_Movie1
            // 
            this.userControl_Movie1.Location = new System.Drawing.Point(284, 47);
            this.userControl_Movie1.Name = "userControl_Movie1";
            this.userControl_Movie1.Size = new System.Drawing.Size(200, 300);
            this.userControl_Movie1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 372);
            this.Controls.Add(this.userControl_Movie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UserControl_Movie userControl_Movie1;
    }
}

