using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foursquare_Black.ClassFolder
{
    public class FriendsClass
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

        public class Tips
        {
            public int count { get; set; }
        }

        public class Group
        {
            public string type { get; set; }
            public int count { get; set; }
            public List<object> items { get; set; }
        }

        public class Lists
        {
            public List<Group> groups { get; set; }
        }

        public class Contact
        {
            public string phone { get; set; }
            public string email { get; set; }
            public string twitter { get; set; }
            public string facebook { get; set; }
        }

        public class Item2
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string relationship { get; set; }
            public Photo photo { get; set; }
            public Tips tips { get; set; }
            public Lists lists { get; set; }
            public string homeCity { get; set; }
            public string bio { get; set; }
            public Contact contact { get; set; }
        }

        public class Friends
        {
            public int count { get; set; }
            public List<Item2> items { get; set; }
        }

        public class Response
        {
            public Friends friends { get; set; }
            public string checksum { get; set; }
        }

        public class RootObject
        {
            public Meta meta { get; set; }
            public List<Notification> notifications { get; set; }
            public Response response { get; set; }
        }
    }
}
