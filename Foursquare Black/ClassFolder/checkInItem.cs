using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    public class checkInItem
    {
        //hold the string of what user said
        public string shout { get; set; }

        //venue name
        public string venueName { get; set;}

        //how long ago user was there
        public int timeAgo { get; set; }

        //string for image
        public string image { get; set; }

        //latitude and longitude
        public double longitude { get; set; }
        public double latitude { get; set; }
    }
}
