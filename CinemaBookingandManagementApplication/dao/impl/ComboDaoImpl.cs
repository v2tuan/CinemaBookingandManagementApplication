﻿using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class ComboDaoImpl
    {
        public DataTable GetComboList()
        {
            return Function.GetComboList();
        }
        public void CreateNewCombo(Combo combo)
        {
            try
            {
                string comboName = combo.ComboName;
                decimal comboPrice = combo.ComboPrice;
                string descriptions = combo.Descriptions;

                MemoryStream pic = new MemoryStream();
                if (combo.Image != null)
                {
                    combo.Image.Save(pic, combo.Image.RawFormat);
                }
                Procedure.CreateNewCombo(comboName, comboPrice, descriptions, combo.Image != null ? pic : null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void delete(Combo combo)
        {
            string comboId = combo.ComboId;
            Procedure.DeleteCombo(comboId);
        }
        public void update(Combo combo)
        {
            string comboId = combo.ComboId;
            string comboName = combo.ComboName;
            decimal comboPrice = combo.ComboPrice;
            string descriptions = combo.Descriptions;

            MemoryStream pic = new MemoryStream();
            combo.Image.Save(pic, combo.Image.RawFormat);
            Procedure.UpdateCombo(comboId, comboName, comboPrice, pic, descriptions);
        }
    }
}
