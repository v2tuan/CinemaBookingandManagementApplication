namespace CinemaBookingandManagementApplication
{
    partial class Form_ChooseCombo
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelCombo = new System.Windows.Forms.FlowLayoutPanel();
            this.userControl_Combo1 = new CinemaBookingandManagementApplication.UserControls.UserControl_Combo();
            this.userControl_Combo2 = new CinemaBookingandManagementApplication.UserControls.UserControl_Combo();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Combo";
            // 
            // flowLayoutPanelCombo
            // 
            this.flowLayoutPanelCombo.AutoScroll = true;
            this.flowLayoutPanelCombo.AutoSize = true;
            this.flowLayoutPanelCombo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_Combo1);
            this.flowLayoutPanelCombo.Controls.Add(this.userControl_Combo2);
            this.flowLayoutPanelCombo.Location = new System.Drawing.Point(30, 72);
            this.flowLayoutPanelCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelCombo.MaximumSize = new System.Drawing.Size(1268, 0);
            this.flowLayoutPanelCombo.Name = "flowLayoutPanelCombo";
            this.flowLayoutPanelCombo.Size = new System.Drawing.Size(1268, 318);
            this.flowLayoutPanelCombo.TabIndex = 11;
            // 
            // userControl_Combo1
            // 
            this.userControl_Combo1.BackColor = System.Drawing.Color.White;
            this.userControl_Combo1.combo = null;
            this.userControl_Combo1.Location = new System.Drawing.Point(5, 5);
            this.userControl_Combo1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Combo1.Name = "userControl_Combo1";
            this.userControl_Combo1.Size = new System.Drawing.Size(1258, 149);
            this.userControl_Combo1.TabIndex = 0;
            // 
            // userControl_Combo2
            // 
            this.userControl_Combo2.BackColor = System.Drawing.Color.White;
            this.userControl_Combo2.combo = null;
            this.userControl_Combo2.Location = new System.Drawing.Point(5, 164);
            this.userControl_Combo2.Margin = new System.Windows.Forms.Padding(5);
            this.userControl_Combo2.Name = "userControl_Combo2";
            this.userControl_Combo2.Size = new System.Drawing.Size(1258, 149);
            this.userControl_Combo2.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 1025);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1338, 81);
            this.guna2Panel1.TabIndex = 12;
            // 
            // Form_ChooseCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1338, 1106);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.flowLayoutPanelCombo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChooseCombo";
            this.Text = "Form_ChooseCombo";
            this.Load += new System.EventHandler(this.Form_ChooseCombo_Load);
            this.flowLayoutPanelCombo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCombo;
        private UserControls.UserControl_Combo userControl_Combo1;
        private UserControls.UserControl_Combo userControl_Combo2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}