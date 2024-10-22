namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_EditCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_EditCombo));
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxCombo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(256, 90);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(138, 28);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Giá: 109.000 ₫";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(256, 55);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(328, 21);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "1 Ly nước ngọt size L + 01 Hộp bắp + 1 Snack";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(256, 17);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(224, 28);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "iCombo 1 Big Extra STD";
            // 
            // pictureBoxCombo
            // 
            this.pictureBoxCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxCombo.BorderRadius = 10;
            this.pictureBoxCombo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCombo.Image")));
            this.pictureBoxCombo.ImageRotate = 0F;
            this.pictureBoxCombo.Location = new System.Drawing.Point(30, 17);
            this.pictureBoxCombo.Name = "pictureBoxCombo";
            this.pictureBoxCombo.Size = new System.Drawing.Size(201, 114);
            this.pictureBoxCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCombo.TabIndex = 5;
            this.pictureBoxCombo.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(47)))), ((int)(((byte)(39)))));
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(1543, 46);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonEdit.Size = new System.Drawing.Size(50, 50);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // UserControl_EditCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCombo);
            this.Name = "UserControl_EditCombo";
            this.Size = new System.Drawing.Size(1648, 149);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCombo;
        private Guna.UI2.WinForms.Guna2CircleButton buttonEdit;
    }
}
