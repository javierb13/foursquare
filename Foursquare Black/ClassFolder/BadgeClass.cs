using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    class BadgeClass
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

        public class Image
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class Group
        {
            public string type { get; set; }
            public string name { get; set; }
            public Image image { get; set; }
            public List<string> items { get; set; }
            public List<object> groups { get; set; }
        }

        public class Sets
        {
            public List<Group> groups { get; set; }
        }

        public class Image2
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class Contact
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
            public Contact contact { get; set; }
            public Location location { get; set; }
            public List<Category> categories { get; set; }
            public bool verified { get; set; }
            public Stats stats { get; set; }
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

        public class __invalid_type__5302d9ef498e579a57a9d66d
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string unlockMessage { get; set; }
            public string description { get; set; }
            public string badgeText { get; set; }
            public Image2 image { get; set; }
            public List<Unlock> unlocks { get; set; }
        }

        public class Image3
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

        public class Menu2
        {
            public string type { get; set; }
            public string label { get; set; }
            public string anchor { get; set; }
            public string url { get; set; }
            public string mobileUrl { get; set; }
        }

        public class Venue2
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact2 contact { get; set; }
            public Location2 location { get; set; }
            public List<Category2> categories { get; set; }
            public bool verified { get; set; }
            public Stats2 stats { get; set; }
            public string url { get; set; }
            public Menu2 menu { get; set; }
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

        public class Checkin2
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
            public Venue2 venue { get; set; }
            public Photos2 photos { get; set; }
            public Posts2 posts { get; set; }
            public Comments2 comments { get; set; }
            public Source2 source { get; set; }
        }

        public class Unlock2
        {
            public List<Checkin2> checkins { get; set; }
        }

        public class __invalid_type__530a4e20498e52d7a3c710af
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string unlockMessage { get; set; }
            public string description { get; set; }
            public string badgeText { get; set; }
            public Image3 image { get; set; }
            public List<Unlock2> unlocks { get; set; }
        }

        public class Image4
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class Contact3
        {
            public string twitter { get; set; }
        }

        public class Location3
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

        public class Venue3
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact3 contact { get; set; }
            public Location3 location { get; set; }
            public List<Category3> categories { get; set; }
            public bool verified { get; set; }
            public Stats3 stats { get; set; }
            public string url { get; set; }
        }

        public class Photos3
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Posts3
        {
            public int count { get; set; }
            public int textCount { get; set; }
        }

        public class Comments3
        {
            public int count { get; set; }
        }

        public class Source3
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Checkin3
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
            public Venue3 venue { get; set; }
            public Photos3 photos { get; set; }
            public Posts3 posts { get; set; }
            public Comments3 comments { get; set; }
            public Source3 source { get; set; }
        }

        public class Unlock3
        {
            public List<Checkin3> checkins { get; set; }
        }

        public class __invalid_type__5308db3d498ed26412c064b4
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string unlockMessage { get; set; }
            public string description { get; set; }
            public string badgeText { get; set; }
            public Image4 image { get; set; }
            public List<Unlock3> unlocks { get; set; }
        }

        public class Image5
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class Contact4
        {
            public string phone { get; set; }
            public string formattedPhone { get; set; }
            public string twitter { get; set; }
        }

        public class Location4
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

        public class Icon4
        {
            public string prefix { get; set; }
            public string suffix { get; set; }
        }

        public class Category4
        {
            public string id { get; set; }
            public string name { get; set; }
            public string pluralName { get; set; }
            public string shortName { get; set; }
            public Icon4 icon { get; set; }
            public bool primary { get; set; }
        }

        public class Stats4
        {
            public int checkinsCount { get; set; }
            public int usersCount { get; set; }
            public int tipCount { get; set; }
        }

        public class Menu3
        {
            public string type { get; set; }
            public string label { get; set; }
            public string anchor { get; set; }
            public string url { get; set; }
            public string mobileUrl { get; set; }
        }

        public class Venue4
        {
            public string id { get; set; }
            public string name { get; set; }
            public Contact4 contact { get; set; }
            public Location4 location { get; set; }
            public List<Category4> categories { get; set; }
            public bool verified { get; set; }
            public Stats4 stats { get; set; }
            public string url { get; set; }
            public Menu3 menu { get; set; }
            public string storeId { get; set; }
        }

        public class Photos4
        {
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Posts4
        {
            public int count { get; set; }
            public int textCount { get; set; }
        }

        public class Comments4
        {
            public int count { get; set; }
        }

        public class Source4
        {
            public string name { get; set; }
            public string url { get; set; }
        }

        public class Checkin4
        {
            public string id { get; set; }
            public int createdAt { get; set; }
            public string type { get; set; }
            public string shout { get; set; }
            public int timeZoneOffset { get; set; }
            public Venue4 venue { get; set; }
            public Photos4 photos { get; set; }
            public Posts4 posts { get; set; }
            public Comments4 comments { get; set; }
            public Source4 source { get; set; }
        }

        public class Unlock4
        {
            public List<Checkin4> checkins { get; set; }
        }

        public class __invalid_type__530f36f5498ef5b35590f684
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string unlockMessage { get; set; }
            public string description { get; set; }
            public int level { get; set; }
            public string badgeText { get; set; }
            public string levelText { get; set; }
            public string categorySummary { get; set; }
            public Image5 image { get; set; }
            public List<Unlock4> unlocks { get; set; }
        }

        public class Image6
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbac202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image6 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image7
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbad202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image7 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image8
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbae202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image8 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image9
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbaf202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image9 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image10
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbb0202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image10 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image11
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbb1202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image11 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image12
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbb2202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image12 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image13
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbb3202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image13 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image14
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__502ae142011c88ba3d9bfe5b
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image14 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image15
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbce202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image15 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image16
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbcf202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image16 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image17
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbd0202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image17 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image18
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbc3202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image18 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image19
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbda202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image19 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image20
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbdb202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image20 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image21
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbdc202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image21 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image22
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbdd202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image22 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image23
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbdf202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image23 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image24
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbe0202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image24 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image25
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08667a0803bbe1202ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image25 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image26
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c4f08677a0803bb4e212ab7
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image26 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image27
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c7d1dd0978976b0c7cee939
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image27 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image28
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4c7d1deb978976b064cfe939
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image28 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image29
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4caa535f30bd9eb05be32923
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image29 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image30
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4cec5f0bf7ac8eecd229e51e
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image30 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image31
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4cf5199da41a60fcf71d2fc0
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image31 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image32
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4d0925ed304460fc7117da63
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image32 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image33
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4d36211d2e4076ebeca814e6
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image33 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image34
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4d3efab1ac038eec826d6cfc
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image34 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image35
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4d5ac1585e7788bf97e98f9e
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image35 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image36
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4dbae35b4159a4e20f525b96
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image36 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image37
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ddbf6161520f579d65d87e0
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image37 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image38
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4df23ba9922e8e1ea8903cca
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image38 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image39
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4dfbc8e5922e5ece12ea29ba
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image39 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image40
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4e454b72922ee4def2921e93
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image40 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image41
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4e988be87beb567e777d83e9
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image41 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image42
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ebb04b27bebd6a83f111f11
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image42 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image43
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ebb07357bebd6a83f116c24
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image43 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image44
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ebb078f7bebd6a83f1176bd
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image44 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image45
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ecbdacb7beb20ebed8d3e6a
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image45 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image46
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ecbdd9e7beb20ebed8da36d
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image46 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image47
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4ecbdf417beb20ebed8ddfe4
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image47 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image48
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4f0da0207bebfc145ffdad57
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image48 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image49
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4f4d5fa07beb270824a95b7b
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image49 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image50
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4f6a487e7beb7e5831d4d730
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public Image50 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image51
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4f6a48ae7beb7e5831d4dffe
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public Image51 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image52
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__4f6a48fa7beb7e5831d4eb25
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public Image52 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image53
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__5086bdd2011c9d54f4a18635
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image53 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Image54
        {
            public string prefix { get; set; }
            public List<int> sizes { get; set; }
            public string name { get; set; }
        }

        public class __invalid_type__50b64929011cb887b3335244
        {
            public string id { get; set; }
            public string badgeId { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string hint { get; set; }
            public Image54 image { get; set; }
            public List<object> unlocks { get; set; }
        }

        public class Badges
        {
            public __invalid_type__5302d9ef498e579a57a9d66d __invalid_name__5302d9ef498e579a57a9d66d { get; set; }
            public __invalid_type__530a4e20498e52d7a3c710af __invalid_name__530a4e20498e52d7a3c710af { get; set; }
            public __invalid_type__5308db3d498ed26412c064b4 __invalid_name__5308db3d498ed26412c064b4 { get; set; }
            public __invalid_type__530f36f5498ef5b35590f684 __invalid_name__530f36f5498ef5b35590f684 { get; set; }
            public __invalid_type__4c4f08667a0803bbac202ab7 __invalid_name__4c4f08667a0803bbac202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbad202ab7 __invalid_name__4c4f08667a0803bbad202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbae202ab7 __invalid_name__4c4f08667a0803bbae202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbaf202ab7 __invalid_name__4c4f08667a0803bbaf202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbb0202ab7 __invalid_name__4c4f08667a0803bbb0202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbb1202ab7 __invalid_name__4c4f08667a0803bbb1202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbb2202ab7 __invalid_name__4c4f08667a0803bbb2202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbb3202ab7 __invalid_name__4c4f08667a0803bbb3202ab7 { get; set; }
            public __invalid_type__502ae142011c88ba3d9bfe5b __invalid_name__502ae142011c88ba3d9bfe5b { get; set; }
            public __invalid_type__4c4f08667a0803bbce202ab7 __invalid_name__4c4f08667a0803bbce202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbcf202ab7 __invalid_name__4c4f08667a0803bbcf202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbd0202ab7 __invalid_name__4c4f08667a0803bbd0202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbc3202ab7 __invalid_name__4c4f08667a0803bbc3202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbda202ab7 __invalid_name__4c4f08667a0803bbda202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbdb202ab7 __invalid_name__4c4f08667a0803bbdb202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbdc202ab7 __invalid_name__4c4f08667a0803bbdc202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbdd202ab7 __invalid_name__4c4f08667a0803bbdd202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbdf202ab7 __invalid_name__4c4f08667a0803bbdf202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbe0202ab7 __invalid_name__4c4f08667a0803bbe0202ab7 { get; set; }
            public __invalid_type__4c4f08667a0803bbe1202ab7 __invalid_name__4c4f08667a0803bbe1202ab7 { get; set; }
            public __invalid_type__4c4f08677a0803bb4e212ab7 __invalid_name__4c4f08677a0803bb4e212ab7 { get; set; }
            public __invalid_type__4c7d1dd0978976b0c7cee939 __invalid_name__4c7d1dd0978976b0c7cee939 { get; set; }
            public __invalid_type__4c7d1deb978976b064cfe939 __invalid_name__4c7d1deb978976b064cfe939 { get; set; }
            public __invalid_type__4caa535f30bd9eb05be32923 __invalid_name__4caa535f30bd9eb05be32923 { get; set; }
            public __invalid_type__4cec5f0bf7ac8eecd229e51e __invalid_name__4cec5f0bf7ac8eecd229e51e { get; set; }
            public __invalid_type__4cf5199da41a60fcf71d2fc0 __invalid_name__4cf5199da41a60fcf71d2fc0 { get; set; }
            public __invalid_type__4d0925ed304460fc7117da63 __invalid_name__4d0925ed304460fc7117da63 { get; set; }
            public __invalid_type__4d36211d2e4076ebeca814e6 __invalid_name__4d36211d2e4076ebeca814e6 { get; set; }
            public __invalid_type__4d3efab1ac038eec826d6cfc __invalid_name__4d3efab1ac038eec826d6cfc { get; set; }
            public __invalid_type__4d5ac1585e7788bf97e98f9e __invalid_name__4d5ac1585e7788bf97e98f9e { get; set; }
            public __invalid_type__4dbae35b4159a4e20f525b96 __invalid_name__4dbae35b4159a4e20f525b96 { get; set; }
            public __invalid_type__4ddbf6161520f579d65d87e0 __invalid_name__4ddbf6161520f579d65d87e0 { get; set; }
            public __invalid_type__4df23ba9922e8e1ea8903cca __invalid_name__4df23ba9922e8e1ea8903cca { get; set; }
            public __invalid_type__4dfbc8e5922e5ece12ea29ba __invalid_name__4dfbc8e5922e5ece12ea29ba { get; set; }
            public __invalid_type__4e454b72922ee4def2921e93 __invalid_name__4e454b72922ee4def2921e93 { get; set; }
            public __invalid_type__4e988be87beb567e777d83e9 __invalid_name__4e988be87beb567e777d83e9 { get; set; }
            public __invalid_type__4ebb04b27bebd6a83f111f11 __invalid_name__4ebb04b27bebd6a83f111f11 { get; set; }
            public __invalid_type__4ebb07357bebd6a83f116c24 __invalid_name__4ebb07357bebd6a83f116c24 { get; set; }
            public __invalid_type__4ebb078f7bebd6a83f1176bd __invalid_name__4ebb078f7bebd6a83f1176bd { get; set; }
            public __invalid_type__4ecbdacb7beb20ebed8d3e6a __invalid_name__4ecbdacb7beb20ebed8d3e6a { get; set; }
            public __invalid_type__4ecbdd9e7beb20ebed8da36d __invalid_name__4ecbdd9e7beb20ebed8da36d { get; set; }
            public __invalid_type__4ecbdf417beb20ebed8ddfe4 __invalid_name__4ecbdf417beb20ebed8ddfe4 { get; set; }
            public __invalid_type__4f0da0207bebfc145ffdad57 __invalid_name__4f0da0207bebfc145ffdad57 { get; set; }
            public __invalid_type__4f4d5fa07beb270824a95b7b __invalid_name__4f4d5fa07beb270824a95b7b { get; set; }
            public __invalid_type__4f6a487e7beb7e5831d4d730 __invalid_name__4f6a487e7beb7e5831d4d730 { get; set; }
            public __invalid_type__4f6a48ae7beb7e5831d4dffe __invalid_name__4f6a48ae7beb7e5831d4dffe { get; set; }
            public __invalid_type__4f6a48fa7beb7e5831d4eb25 __invalid_name__4f6a48fa7beb7e5831d4eb25 { get; set; }
            public __invalid_type__5086bdd2011c9d54f4a18635 __invalid_name__5086bdd2011c9d54f4a18635 { get; set; }
            public __invalid_type__50b64929011cb887b3335244 __invalid_name__50b64929011cb887b3335244 { get; set; }
        }

        public class Response
        {
            public Sets sets { get; set; }
            public Badges badges { get; set; }
            public string defaultSetType { get; set; }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Notification> notifications { get; set; }
            public Response response { get; set; }
        }
    }
}
