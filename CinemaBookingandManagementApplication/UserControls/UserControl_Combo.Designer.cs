namespace CinemaBookingandManagementApplication.UserControls
{
    partial class UserControl_Combo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Combo));
            this.pictureBoxCombo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txt_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCombo
            // 
            this.pictureBoxCombo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxCombo.BorderRadius = 10;
            this.pictureBoxCombo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCombo.Image")));
            this.pictureBoxCombo.ImageRotate = 0F;
            this.pictureBoxCombo.Location = new System.Drawing.Point(24, 16);
            this.pictureBoxCombo.Name = "pictureBoxCombo";
            this.pictureBoxCombo.Size = new System.Drawing.Size(201, 114);
            this.pictureBoxCombo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCombo.TabIndex = 0;
            this.pictureBoxCombo.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(250, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(224, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "iCombo 1 Big Extra STD";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(250, 54);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(328, 21);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "1 Ly nước ngọt size L + 01 Hộp bắp + 1 Snack";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(250, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(138, 28);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Giá: 109.000 ₫";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_quantity.DefaultText = "0";
            this.txt_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_quantity.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_quantity.IconLeft")));
            this.txt_quantity.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_quantity.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_quantity.IconRight")));
            this.txt_quantity.IconRightSize = new System.Drawing.Size(30, 30);
            this.txt_quantity.Location = new System.Drawing.Point(1093, 89);
            this.txt_quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.PasswordChar = '\0';
            this.txt_quantity.PlaceholderText = "";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.SelectedText = "";
            this.txt_quantity.Size = new System.Drawing.Size(130, 41);
            this.txt_quantity.TabIndex = 4;
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantity.IconLeftClick += new System.EventHandler(this.txt_quantity_IconLeftClick);
            this.txt_quantity.IconRightClick += new System.EventHandler(this.txt_quantity_IconRightClick);
            // 
            // UserControl_Combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxCombo);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserControl_Combo";
            this.Size = new System.Drawing.Size(1258, 149);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCombo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxCombo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private Guna.UI2.WinForms.Guna2TextBox txt_quantity;
    }
}
