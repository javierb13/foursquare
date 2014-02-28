using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    public class UserClass
    {
        public class Meta
        {
            public int code { get; set; }
        }

        public class Item
        {
            public int unreadCount { get; set; }
        }

        public class Notification
        {
            public string type { get; set; }
            public Item item { get; set; }
        }

        public class Photo
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Group
        {
            public string type { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Friends
        {
            public int count { get; set; }
            public List<Group> groups { get; set; }
        }

        public class Tips
        {
            public int count { get; set; }
        }

        public class Contact
        {
            public string email { get; set; }
            public string facebook { get; set; }
        }

        public class Image
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class Contact2
        {
            public string phone { get; set; }
            public string formattedPhone { get; set; }
        }

        public class Location
        {
            public string address { get; set; }
            public string crossStreet { get; set; }
            public double lat { get; set; }
            public double lng { get; set; }
            public string postalCode { get; set; }
            public string cc { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Icon
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Category
        {
            public string id { get; set; }
            public string name { get; set; }
            public string pluralName { get; set; }
            public string shortName { get; set; }
            public Icon icon { get; set; }
            public bool primary { get; set; }
        }

        public class Stats
        {
            public int checkinsCount { get; set; }
            public int usersCount { get; set; }
            public int tipCount { get; set; }
        }

        public class Menu
        {
            public string type { get; set; }
            public string label { get; set; }
            public string anchor { get; set; }
            public string url { get; set; }
            public string mobileUrl { get; set; }
        }

        public class Venue
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact2 contact { get; set; }
            public Location location { get; set; }
            public List<Category> categories { get; set; }
            public bool verified { get; set; }
            public Stats stats { get; set; }
            public string url { get; set; }
            public Menu menu { get; set; }
        }

        public class Photos
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Posts
        {
            public int count { get; set; }
            public int textCount { get; set; }
        }

        public class Comments
        {
            public int count { get; set; }
        }

        public class Source
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Checkin
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
            public Venue venue { get; set; }
            public Photos photos { get; set; }
            public Posts posts { get; set; }
            public Comments comments { get; set; }
            public Source source { get; set; }
        }

        public class Unlock
        {
            public List<Checkin> checkins { get; set; }
        }

        public class Item2
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string unlockMessage { get; set; }
            public string description { get; set; }
            public string badgeText { get; set; }
            public Image image { get; set; }
            public List<Unlock> unlocks { get; set; }
        }

        public class Badges
        {
            public int count { get; set; }
            public List<Item2> items { get; set; }
        }

        public class Mayorships
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Contact3
        {
            public string phone { get; set; }
            public string formattedPhone { get; set; }
            public string twitter { get; set; }
        }

        public class Location2
        {
            public string address { get; set; }
            public string crossStreet { get; set; }
            public double lat { get; set; }
            public double lng { get; set; }
            public string postalCode { get; set; }
            public string cc { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Icon2
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Category2
        {
            public string id { get; set; }
            public string name { get; set; }
            public string pluralName { get; set; }
            public string shortName { get; set; }
            public Icon2 icon { get; set; }
            public bool primary { get; set; }
        }

        public class Stats2
        {
            public int checkinsCount { get; set; }
            public int usersCount { get; set; }
            public int tipCount { get; set; }
        }

        public class Group2
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Likes
        {
            public int count { get; set; }
            public List<Group2> groups { get; set; }
            public string summary { get; set; }
        }

        public class BeenHere
        {
            public int count { get; set; }
            public bool marked { get; set; }
        }

        public class Venue2
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact3 contact { get; set; }
            public Location2 location { get; set; }
            public List<Category2> categories { get; set; }
            public bool verified { get; set; }
            public Stats2 stats { get; set; }
            public string url { get; set; }
            public Likes likes { get; set; }
            public bool like { get; set; }
            public BeenHere beenHere { get; set; }
        }

        public class Likes2
        {
            public int count { get; set; }
            public List<object> groups { get; set; }
        }

        public class Photos2
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Posts2
        {
            public int count { get; set; }
            public int textCount { get; set; }
        }

        public class Comments2
        {
            public int count { get; set; }
        }

        public class Source2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Item3
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
            public Venue2 venue { get; set; }
            public Likes2 likes { get; set; }
            public bool like { get; set; }
            public Photos2 photos { get; set; }
            public Posts2 posts { get; set; }
            public Comments2 comments { get; set; }
            public Source2 source { get; set; }
        }

        public class Checkins
        {
            public int count { get; set; }
            public List<Item3> items { get; set; }
        }

        public class Group3
        {
            public string type { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Following
        {
            public int count { get; set; }
            public List<Group3> groups { get; set; }
        }

        public class Requests
        {
            public int count { get; set; }
        }

        public class Group4
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Lists
        {
            public int count { get; set; }
            public List<Group4> groups { get; set; }
        }

        public class Source3
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Contact4
        {
            public string phone { get; set; }
            public string formattedPhone { get; set; }
            public string twitter { get; set; }
        }

        public class Location3
        {
            public string address { get; set; }
            public double lat { get; set; }
            public double lng { get; set; }
            public string postalCode { get; set; }
            public string cc { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Icon3
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Category3
        {
            public string id { get; set; }
            public string name { get; set; }
            public string pluralName { get; set; }
            public string shortName { get; set; }
            public Icon3 icon { get; set; }
            public bool primary { get; set; }
        }

        public class Stats3
        {
            public int checkinsCount { get; set; }
            public int usersCount { get; set; }
            public int tipCount { get; set; }
        }

        public class Group5
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Likes3
        {
            public int count { get; set; }
            public List<Group5> groups { get; set; }
            public string summary { get; set; }
        }

        public class BeenHere2
        {
            public int count { get; set; }
            public bool marked { get; set; }
        }

        public class Venue3
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact4 contact { get; set; }
            public Location3 location { get; set; }
            public List<Category3> categories { get; set; }
            public bool verified { get; set; }
            public Stats3 stats { get; set; }
            public string url { get; set; }
            public Likes3 likes { get; set; }
            public bool like { get; set; }
            public BeenHere2 beenHere { get; set; }
            public string storeId { get; set; }
        }

        public class Checkin2
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
        }

        public class Item4
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public Source3 source { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string visibility { get; set; }
            public Venue3 venue { get; set; }
            public Checkin2 checkin { get; set; }
        }

        public class Photos3
        {
            public int count { get; set; }
            public List<Item4> items { get; set; }
        }

        public class Scores
        {
            public int recent { get; set; }
            public int max { get; set; }
            public int checkinsCount { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string relationship { get; set; }
            public Photo photo { get; set; }
            public Friends friends { get; set; }
            public Tips tips { get; set; }
            public string homeCity { get; set; }
            public string bio { get; set; }
            public Contact contact { get; set; }
            public string checkinPings { get; set; }
            public bool pings { get; set; }
            public string type { get; set; }
            public Badges badges { get; set; }
            public Mayorships mayorships { get; set; }
            public Checkins checkins { get; set; }
            public Following following { get; set; }
            public Requests requests { get; set; }
            public Lists lists { get; set; }
            public Photos3 photos { get; set; }
            public Scores scores { get; set; }
            public int createdAt { get; set; }
            public string referralId { get; set; }
        }

        public class Response
        {
            public User user { get; set; }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Notification> notifications { get; set; }
            public Response response { get; set; }
        }
    }
}
