using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    public class VenueClass
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

        public class Contact
        {
            public string phone { get; set; }
            public string formattedPhone { get; set; }
            public string twitter { get; set; }
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

        public class Photo
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Item2
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo photo { get; set; }
        }

        public class Group
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<Item2> items { get; set; }
        }

        public class Likes
        {
            public int count { get; set; }
            public List<Group> groups { get; set; }
            public string summary { get; set; }
        }

        public class Photo2
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string relationship { get; set; }
            public Photo2 photo { get; set; }
        }

        public class Item3
        {
            public int visitedCount { get; set; }
            public bool liked { get; set; }
            public bool disliked { get; set; }
            public User user { get; set; }
        }

        public class FriendVisits
        {
            public int count { get; set; }
            public string summary { get; set; }
            public List<Item3> items { get; set; }
        }

        public class BeenHere
        {
            public int count { get; set; }
            public bool marked { get; set; }
        }

        public class Specials
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Source
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Photo3
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User2
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo3 photo { get; set; }
        }

        public class Item4
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public Source source { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public User2 user { get; set; }
            public string visibility { get; set; }
        }

        public class Group2
        {
            public string type { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<Item4> items { get; set; }
        }

        public class Photos
        {
            public int count { get; set; }
            public List<Group2> groups { get; set; }
        }

        public class HereNow
        {
            public int count { get; set; }
            public string summary { get; set; }
            public List<object> groups { get; set; }
        }

        public class Target2
        {
            public string type { get; set; }
            public string url { get; set; }
        }

        public class Object
        {
            public string id { get; set; }
            public string type { get; set; }
            public Target2 target { get; set; }
            public bool ignorable { get; set; }
        }

        public class Target
        {
            public string type { get; set; }
            public Object @object { get; set; }
        }

        public class Item5
        {
            public string summary { get; set; }
            public string type { get; set; }
            public string reasonName { get; set; }
            public Target target { get; set; }
            public int count { get; set; }
        }

        public class Reasons
        {
            public int count { get; set; }
            public List<Item5> items { get; set; }
        }

        public class Photo4
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User3
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo4 photo { get; set; }
        }

        public class Mayor
        {
            public int count { get; set; }
            public User3 user { get; set; }
        }

        public class Group4
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Likes2
        {
            public int count { get; set; }
            public List<Group4> groups { get; set; }
            public string summary { get; set; }
        }

        public class Todo
        {
            public int count { get; set; }
        }

        public class Photo5
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User4
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo5 photo { get; set; }
        }

        public class Source2
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Photo6
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public Source2 source { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Item6
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string text { get; set; }
            public string canonicalUrl { get; set; }
            public string lang { get; set; }
            public Likes2 likes { get; set; }
            public bool like { get; set; }
            public bool logView { get; set; }
            public Todo todo { get; set; }
            public User4 user { get; set; }
            public Photo6 photo { get; set; }
            public string photourl { get; set; }
        }

        public class Group3
        {
            public string type { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<Item6> items { get; set; }
        }

        public class Tips
        {
            public int count { get; set; }
            public List<Group3> groups { get; set; }
        }

        public class Photo7
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User5
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo7 photo { get; set; }
        }

        public class Photo9
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User6
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo9 photo { get; set; }
        }

        public class Photo8
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public User6 user { get; set; }
            public string visibility { get; set; }
        }

        public class Followers
        {
            public int count { get; set; }
        }

        public class Photo11
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class User7
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public Photo11 photo { get; set; }
        }

        public class Photo10
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string prefix { get; set; }
            public string suffix { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public User7 user { get; set; }
            public string visibility { get; set; }
        }

        public class Item8
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public Photo10 photo { get; set; }
        }

        public class ListItems
        {
            public int count { get; set; }
            public List<Item8> items { get; set; }
        }

        public class Item7
        {
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string type { get; set; }
            public User5 user { get; set; }
            public bool editable { get; set; }
            public bool @public { get; set; }
            public bool collaborative { get; set; }
            public string url { get; set; }
            public string canonicalUrl { get; set; }
            public int createdAt { get; set; }
            public int updatedAt { get; set; }
            public Photo8 photo { get; set; }
            public Followers followers { get; set; }
            public ListItems listItems { get; set; }
        }

        public class Group5
        {
            public string type { get; set; }
            public string name { get; set; }
            public int count { get; set; }
            public List<Item7> items { get; set; }
        }

        public class Listed
        {
            public int count { get; set; }
            public List<Group5> groups { get; set; }
        }

        public class Entity
        {
            public List<int> indices { get; set; }
            public string type { get; set; }
        }

        public class Sample
        {
            public List<Entity> entities { get; set; }
            public string text { get; set; }
        }

        public class Phras
        {
            public string phrase { get; set; }
            public Sample sample { get; set; }
            public int count { get; set; }
        }

        public class Open
        {
            public string renderedTime { get; set; }
        }

        public class Timeframe
        {
            public string days { get; set; }
            public bool includesToday { get; set; }
            public List<Open> open { get; set; }
            public List<object> segments { get; set; }
        }

        public class Hours
        {
            public string status { get; set; }
            public bool isOpen { get; set; }
            public List<Timeframe> timeframes { get; set; }
        }

        public class Open2
        {
            public string renderedTime { get; set; }
        }

        public class Timeframe2
        {
            public string days { get; set; }
            public bool includesToday { get; set; }
            public List<Open2> open { get; set; }
            public List<object> segments { get; set; }
        }

        public class Popular
        {
            public bool isOpen { get; set; }
            public List<Timeframe2> timeframes { get; set; }
        }

        public class PageUpdates
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Item9
        {
            public string displayName { get; set; }
            public string displayValue { get; set; }
        }

        public class Group6
        {
            public string type { get; set; }
            public string name { get; set; }
            public string summary { get; set; }
            public int count { get; set; }
            public List<Item9> items { get; set; }
        }

        public class Attributes
        {
            public List<Group6> groups { get; set; }
        }

        public class Venue
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact contact { get; set; }
            public Location location { get; set; }
            public string canonicalUrl { get; set; }
            public List<Category> categories { get; set; }
            public bool verified { get; set; }
            public Stats stats { get; set; }
            public string url { get; set; }
            public Likes likes { get; set; }
            public bool like { get; set; }
            public bool dislike { get; set; }
            public double rating { get; set; }
            public FriendVisits friendVisits { get; set; }
            public BeenHere beenHere { get; set; }
            public Specials specials { get; set; }
            public Photos photos { get; set; }
            public HereNow hereNow { get; set; }
            public Reasons reasons { get; set; }
            public string description { get; set; }
            public string storeId { get; set; }
            public int createdAt { get; set; }
            public Mayor mayor { get; set; }
            public Tips tips { get; set; }
            public List<string> tags { get; set; }
            public string shortUrl { get; set; }
            public string timeZone { get; set; }
            public Listed listed { get; set; }
            public List<Phras> phrases { get; set; }
            public Hours hours { get; set; }
            public Popular popular { get; set; }
            public PageUpdates pageUpdates { get; set; }
            public Attributes attributes { get; set; }
        }

        public class Response
        {
            public Venue venue { get; set; }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Notification> notifications { get; set; }
            public Response response { get; set; }
        }
    }
}
