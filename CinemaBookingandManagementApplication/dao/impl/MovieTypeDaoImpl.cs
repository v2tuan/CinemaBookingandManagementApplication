using CinemaBookingandManagementApplication.configs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class MovieTypeDaoImpl
    {
        public static DataTable getListMovieType()
        {
            return Function.getListMovieType();
        }
    }
}
