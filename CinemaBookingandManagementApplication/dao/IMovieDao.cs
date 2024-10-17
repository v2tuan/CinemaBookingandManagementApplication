using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao
{
    internal interface IMovieDao
    {
        List<Movie> findAll();
        Movie findById(int id);
        void insert(Movie movie);
        void update(Movie category);
        void delete(int id);
        List<Movie> findName(String keyword);
        float getRevenue(Movie movie);

        bool checkid(string id);
    }
}
