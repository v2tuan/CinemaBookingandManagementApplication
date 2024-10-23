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
    public partial class Form_ManagerCombo : Form
    {
        public Form_ManagerCombo()
        {
            InitializeComponent();
        }

        private void btnAddCombo_Click(object sender, EventArgs e)
        {
            Form_AddCombo frm = new Form_AddCombo();
            frm.ShowDialog();
        }

        private void Form_ManagerCombo_Load(object sender, EventArgs e)
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

                        UserControl_EditCombo control_EditCombo = new UserControl_EditCombo(combo);

                        flowLayoutPanelCombo.Controls.Add(control_EditCombo);

                        //edit
                        control_EditCombo.editClick += (ss, ee) =>
                        {
                            //Form_EditCombo form_EditCombo = new Form_EditCombo();
                            
                            Form_EditCombo form_EditCombo = new Form_EditCombo(combo);
                            form_EditCombo.ShowDialog();
                        };
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
