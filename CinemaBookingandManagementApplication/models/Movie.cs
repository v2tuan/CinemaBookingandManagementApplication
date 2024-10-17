using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    internal class Movie
    {
        private string mid;
        private string moviename;
        private int ageRestriction;
        private float revenue;
        private string mtid;
        private DateTime releaseDate;
        private int duration;
        private string descriptions;
        private Image image;

        public Movie(string mid, string moviename, int ageRestriction, float revenue, string mtid, DateTime releaseDate, int duration, string descriptions, Image image)
        {
            this.mid = mid;
            this.moviename = moviename;
            this.AgeRestriction = ageRestriction;
            this.Revenue = revenue;
            this.Mtid = mtid;
            this.ReleaseDate = releaseDate;
            this.Duration = duration;
            this.Descriptions = descriptions;
            this.Image = image;
        }

        public string Mid { get => mid; set => mid = value; }
        public string Moviename { get => moviename; set => moviename = value; }
        public int AgeRestriction { get => ageRestriction; set => ageRestriction = value; }
        public float Revenue { get => revenue; set => revenue = value; }
        public string Mtid { get => mtid; set => mtid = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Descriptions { get => descriptions; set => descriptions = value; }
        public Image Image { get => image; set => image = value; }
    }
}
