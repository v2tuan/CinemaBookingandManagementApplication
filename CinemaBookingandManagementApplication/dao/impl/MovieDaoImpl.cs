﻿using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class MovieDaoImpl : IMovieDao
    {
        public bool checkid(string id)
        {
           return Function.checkMovieID(id);
        }

        public void delete(Movies movie)
        {
            string mid = movie.Mid;
            Procedure.DeleteMovie(mid);
        }

        public List<Movies> findAll()
        {
            throw new NotImplementedException();
        }

        public Movies findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movies> findName(string keyword)
        {
            throw new NotImplementedException();
        }

        public float getRevenue(Movies movie)
        {
            throw new NotImplementedException();
        }

        public void insert(Movies movie)
        {
            try
            {
                string mid = movie.Mid;
                string moviename = movie.Moviename;
                int ageRestriction = movie.AgeRestriction;
                decimal revenue = movie.Revenue;
                string mtid = movie.Mtid;
                DateTime releaseDate = movie.ReleaseDate;
                int duration = movie.Duration;
                string descriptions = movie.Descriptions;

                MemoryStream pic = new MemoryStream();
                if (movie.Image != null)
                {
                    movie.Image.Save(pic, movie.Image.RawFormat);
                }
                Procedure.AddNewMovie(mid, moviename, ageRestriction, revenue, mtid, releaseDate, duration, descriptions, movie.Image != null ? pic : null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void update(Movies movie)
        {
            string mid = movie.Mid;
            string moviename = movie.Moviename;
            int ageRestriction = movie.AgeRestriction;
            decimal revenue = movie.Revenue;
            string mtid = movie.Mtid;
            DateTime releaseDate = movie.ReleaseDate;
            int duration = movie.Duration;
            string descriptions = movie.Descriptions;
            MemoryStream pic = new MemoryStream();
            movie.Image.Save(pic, movie.Image.RawFormat);
            Procedure.UpdateMovie(mid, moviename, ageRestriction, revenue, mtid, releaseDate, duration, descriptions, pic);

        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "M" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "M" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Movies", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            return Function.checkMovieID(id);
        }

        public System.Data.DataTable GetListMovie()
        {
            return Function.GetListMovie();
        }
        public System.Data.DataTable GetListMovieByCIDandTime(string cid, DateTime time )
        {
            return Function.GetMovieByCinemaAndTime(cid,time);
        }
        public System.Data.DataTable GetListMovieByTime( DateTime time)
        {
            return Function.GetMovieSchedulesByDate(time);
        }

    }
}
