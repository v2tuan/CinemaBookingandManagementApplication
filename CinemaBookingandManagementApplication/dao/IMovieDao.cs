using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao
{
    internal interface IMovieDao
    {
        List<Movies> findAll();
        Movies findById(int id);
        void insert(Movies movie);
        void update(Movies category);
        void delete(int id);
        List<Movies> findName(String keyword);
        float getRevenue(Movies movie);

        bool checkid(string id);

        DataTable GetListMovie();
    }
}
