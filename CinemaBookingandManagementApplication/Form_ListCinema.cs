using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.UserControls;
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
    public partial class Form_ListCinema : Form
    {
        public Form_ListCinema()
        {
            InitializeComponent();
        }

        private void Form_ListCinema_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelCinema.Controls.Clear();
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = cinemaDaoImpl.GetListCinema();

                byte[] pic = null;

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Cinemas cinema = new UserControl_Cinemas(); // Khởi tạo UserControl ở đây

                        // Gán giá trị cho cinema từ DataRow
                        cinema.cinema.Cid = dr["cid"].ToString(); // Lưu cid
                        cinema.cinema.Cname = dr["cname"].ToString(); // Lưu tên rạp
                        cinema.cinema.Caddress = dr["caddress"].ToString(); // Lưu địa chỉ
                        cinema.cinema.Hotline = dr["hotline"].ToString(); // Lưu hotline
                        cinema.cinema.Area = dr["area"].ToString(); // Lưu khu vực

                        if (dr["images"] != DBNull.Value)
                        {
                            pic = (byte[])dr["images"];
                            picture = new MemoryStream(pic);
                        }
                        else
                        {
                            // Xử lý khi không có hình ảnh
                            picture = new MemoryStream();
                            MessageBox.Show("Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat)");
                        }

                        // Chuyển đổi MemoryStream thành Image
                        Image image_Cinema = Image.FromStream(picture);
                        cinema.cinema.Image = image_Cinema;

                        cinema.restart();
                        flowLayoutPanelCinema.Controls.Add(cinema);

                        // Sự kiện khi nhấn nút
                        cinema.buttonClick += (ss, ee) =>
                        {
                            // Tạo form editcinema với tham số cinema
                            Form_EditCinema editcinema = new Form_EditCinema(cinema.cinema); // Truyền đối tượng cinema hiện tại
                            editcinema.ShowDialog();
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form_AddCinema form_AddCinema = new Form_AddCinema();
            form_AddCinema.ShowDialog();
        }
    }
}
