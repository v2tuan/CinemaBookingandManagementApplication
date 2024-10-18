using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    internal class Cinema
    {
        private string cid;
        private string cname;
        private string caddress;
        private string hotline;
        private string area;
        private Image image;

        public Cinema()
        {
        }

        public string Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Caddress { get => caddress; set => caddress = value; }
        public string Hotline { get => hotline; set => hotline = value; }
        public string Area { get => area; set => area = value; }
        public Image Image { get => image; set => image = value; }
    }
}
