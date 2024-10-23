using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using CinemaBookingandManagementApplication.configs;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_TopCombo : Form
    {
        public Form_TopCombo()
        {
            InitializeComponent();
            ShowTop5BestSellingCombos();
        }
        private void ShowTop5BestSellingCombos()
        {
            try
            {
                flowLayoutPanelMovie.Controls.Clear(); // Xóa các điều khiển hiện tại
                DataTable topCombos = Views.GetTop5BestSellingCombos(); // Lấy top 5 combo bán chạy nhất
                MemoryStream picture;
                byte[] pic = null;

                foreach (DataRow row in topCombos.Rows)
                {
                    Combo combo = new Combo
                    {
                        ComboId = row["comboId"].ToString(),
                        ComboName = row["comboName"].ToString(),
                        ComboPrice = decimal.Parse(row["comboPrice"].ToString()),
                        Descriptions = row["TotalRevenue"].ToString() // hoặc thông tin mô tả khác
                    };

                    
                    if (row["images"] != DBNull.Value)
                    {
                        pic = (byte[])row["images"];
                        picture = new MemoryStream(pic);
                    }
                    else
                    {
                        picture = new MemoryStream();
                        MessageBox.Show("Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat)");
                        //Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat);
                    }
                    Image image_Food = Image.FromStream(picture);

                    combo.Image = image_Food;

                    // Tạo UserControl cho combo
                    UserControl_EditCombo control_EditCombo = new UserControl_EditCombo(combo);
                    flowLayoutPanelMovie.Controls.Add(control_EditCombo);

                    // Thiết lập sự kiện cho click vào UserControl
                    control_EditCombo.editClick += (ss, ee) =>
                    {
                        Form_EditCombo form_EditCombo = new Form_EditCombo(combo);
                        form_EditCombo.ShowDialog();
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
