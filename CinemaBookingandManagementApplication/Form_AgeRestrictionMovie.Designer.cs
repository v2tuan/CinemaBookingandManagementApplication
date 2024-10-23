namespace CinemaBookingandManagementApplication
{
    partial class Form_AgeRestrictionMovie
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
            this.flowLayoutPanelMovie = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMovie
            // 
            this.flowLayoutPanelMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMovie.AutoScroll = true;
            this.flowLayoutPanelMovie.Location = new System.Drawing.Point(12, 1);
            this.flowLayoutPanelMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMovie.Name = "flowLayoutPanelMovie";
            this.flowLayoutPanelMovie.Size = new System.Drawing.Size(1311, 478);
            this.flowLayoutPanelMovie.TabIndex = 9;
            // 
            // Form_AgeRestrictionMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 592);
            this.Controls.Add(this.flowLayoutPanelMovie);
            this.Name = "Form_AgeRestrictionMovie";
            this.Text = "Form_AgeRestrictionMovie";
            this.Load += new System.EventHandler(this.Form_AgeRestrictionMovie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMovie;
    }
}