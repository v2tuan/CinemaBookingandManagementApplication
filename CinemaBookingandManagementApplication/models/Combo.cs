using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CinemaBookingandManagementApplication.models
{
    public class Combo
    {
        
        public string ComboId { get; set; }
        public string ComboName { get; set; }
        public decimal ComboPrice { get; set; }
        public string Descriptions { get; set; }

        public Image Image { get; set; }

        public Combo()
        {
        }

        public Combo(Combo combo)
        {
            ComboId = combo.ComboId;
            ComboName = combo.ComboName;
            ComboPrice = combo.ComboPrice;
            Descriptions = combo.Descriptions;
            Image = combo.Image;
        }

        // Override phương thức Equals
        //public override bool Equals(object obj)
        //{
        //    if (obj is Combo other)
        //    {
        //        return ComboName == other.ComboName && ComboId == other.ComboId;
        //    }
        //    return false;
        //}
    }
}
