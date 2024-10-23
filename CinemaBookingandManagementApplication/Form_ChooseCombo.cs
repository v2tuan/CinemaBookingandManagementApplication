using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
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
    public partial class Form_ChooseCombo : Form
    {
        // Cách tạo sự kiện có 3 tham số
        public delegate void ClickEventHandler(object sender, EventArgs e, Combo combo);
        public event ClickEventHandler addClick = null;
        public event ClickEventHandler minusClick = null;
        public Form_ChooseCombo()
        {
            InitializeComponent();
        }

        private void Form_ChooseCombo_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelCombo.Controls.Clear();
                ComboDaoImpl comboDao = new ComboDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = comboDao.GetComboList();
                byte[] pic = null;
                Form_detailMovie detailMovie = new Form_detailMovie();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Combo combo = new Combo();
                        combo.ComboId = dr["comboId"].ToString();
                        combo.ComboName = dr["comboName"].ToString();
                        combo.ComboPrice = decimal.Parse(dr["comboPrice"].ToString());
                        combo.Descriptions = dr["descriptions"].ToString();



                        if (dr["images"] != DBNull.Value)
                        {
                            pic = (byte[])dr["images"];
                            picture = new MemoryStream(pic);
                        }
                        else
                        {
                            picture = new MemoryStream();
                            Properties.Resources.nullImage.Save(picture, Properties.Resources.nullImage.RawFormat);
                        }
                        Image image_Food = Image.FromStream(picture);

                        combo.Image = image_Food;

                        UserControl_Combo control_EditCombo = new UserControl_Combo(combo);

                        control_EditCombo.minusClick += (ss, ee) =>
                        {
                            minusClick?.Invoke(this, e, combo);
                        };

                        control_EditCombo.addClick += (ss, ee) =>
                        {
                            addClick?.Invoke(this, e, combo);
                        };

                        control_EditCombo.Width = flowLayoutPanelCombo.Width;
                        flowLayoutPanelCombo.Controls.Add(control_EditCombo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
