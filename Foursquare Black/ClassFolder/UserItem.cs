using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    //used for user profile data
    public class UserItem
    {
        //hold image url for users profile
        public string image { get; set; }

        //hold friend count for user
        public int friendCount { get; set; }

        //hold the hometown location
        public string hometown { get; set; }

        //holds email address
        public string email { get; set; }

        //holds check-in count
        public int checkInCount { get; set; }

        //display number for total of badges
        public int badgesCount { get; set; }

        //display number for tips
        public int tipCount { get; set; }

        //hold first name
        public string firstName { get; set; }

        //holds last name
        public string lastName { get; set; }

        //holds recent score
        public int recentScore { get; set; }

        //holds max score
        public int maxScore { get; set; }

        //holds the mayorship count
        public int mayorshipCount { get; set; }

        //holds last location text
        public string lastLocation { get; set; }

        //longitude and latitude for last location
        public double lastLongitudeLocation { get; set; }
        public double lastLatitudeLocation { get; set; }

    }
}
