using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    public class VenueItem
    {
        //mayor name
        public string MayorName { get; set; }
       

        //mayor image
        public string MayorImage { get; set; }


        //category name
        public string CategoryName { get; set; }


        //category image
        public string CategoryImage { get; set; }


        //category type
        public string CategoryType { get; set; }


        //rating
        public double Rating { get; set; }

        
        //likes
        public int Likes { get; set; }


        //check in stats
        public int CheckInStats { get; set; }


        //check in visitors
        public int CheckInVisitors { get; set; }


        //longitude
        public double Longitude { get; set; }


        //latitude
        public double Latitude { get; set; }


        //hours of operation string
        public string description { get; set; }

        //venue name
        public string venueName { get; set; }

    }
}
