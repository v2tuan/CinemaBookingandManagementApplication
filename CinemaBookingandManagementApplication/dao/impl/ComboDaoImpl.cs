using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string comboName = combo.ComboName;
            decimal comboPrice = combo.ComboPrice;
            string descriptions = combo.Descriptions;

            MemoryStream pic = new MemoryStream();
            combo.Image.Save(pic, combo.Image.RawFormat);
            Procedure.CreateNewCombo(comboName, comboPrice, descriptions, pic);
        }
    }
}
