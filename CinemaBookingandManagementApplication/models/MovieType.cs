using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    internal class MovieType
    {
        private string mtid;
        private string typename;

        public MovieType(string mtid, string typename)
        {
            this.Mtid = mtid;
            this.Typename = typename;
        }

        public string Mtid { get => mtid; set => mtid = value; }
        public string Typename { get => typename; set => typename = value; }
    }
}
