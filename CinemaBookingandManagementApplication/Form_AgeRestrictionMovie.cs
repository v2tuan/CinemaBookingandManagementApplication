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
    public partial class Form_AgeRestrictionMovie : Form
    {
        public Form_AgeRestrictionMovie()
        {
            InitializeComponent();
        }

        private void Form_AgeRestrictionMovie_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelMovie.Controls.Clear(); // Xóa các điều khiển hiện tại
                DataTable moviesAbove18 = Views.GetMoviesAbove18(); // Lấy danh sách phim có ageRestriction > 18
                MemoryStream picture;
                byte[] pic = null;
                if (moviesAbove18 != null)
                {
                    foreach (DataRow row in moviesAbove18.Rows)
                    {
                        UserControl_EditMovie movie = new UserControl_EditMovie(); // Khởi tạo UserControl

                        movie.movie.Mid = row["mid"].ToString();
                        movie.movie.Moviename = row["moviename"].ToString();
                        movie.movie.AgeRestriction = int.Parse(row["ageRestriction"].ToString());
                        movie.movie.Revenue = decimal.Parse(row["revenue"].ToString());
                        movie.movie.Mtid = row["mtid"].ToString();
                        movie.movie.ReleaseDate = DateTime.Parse(row["releaseDate"].ToString());
                        movie.movie.Duration = int.Parse(row["duration"].ToString());
                        movie.movie.Descriptions = row["descriptions"].ToString();

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

                        movie.movie.Image = image_Food;

                        movie.restart(); // Gọi lại phương thức khởi tạo lại nếu cần
                        flowLayoutPanelMovie.Controls.Add(movie); // Thêm UserControl vào flowLayoutPanel

                        // Thiết lập sự kiện cho click vào UserControl
                        movie.buttonClick += (ss, ee) =>
                        {
                            Form_EditMovie editMovie = new Form_EditMovie(movie.movie); // Mở form chỉnh sửa
                            editMovie.ShowDialog();
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
