using Newtonsoft.Json;
using Foursquare_Black.ClassFolder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Device.Location;
using Microsoft.Phone.Maps.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using Windows.System.Threading;

namespace Foursquare_Black.ViewModels
{
    class UserViewModel : ViewModel
    {

        //here is our httpclient which we will use to make our calls to the user endpoint
        //HttpClient is windows phone 8 only. normally use webrequest for lower windows phone versions
        HttpClient client;

        //And here is the url that we will use to get user info after sign in
        string url = "https://api.foursquare.com/v2/users/self?oauth_token=" + App.accessToken + "&v=" + App.date;

        //private list to hold user profile data
        ObservableCollection<UserItem> userProfile = new ObservableCollection<UserItem>();
        public ObservableCollection<UserItem> UserProfile
        {
            get { return userProfile; }
            set 
            { 
                userProfile = value;
                NotifyPropertyChanged("UserProfile");
            }
        }

        //lists to hold check in items
        ObservableCollection<checkInItem> checkInItems = new ObservableCollection<checkInItem>();
        public ObservableCollection<checkInItem> CheckInItems
        {
            get { return checkInItems; }
            set
            {
                checkInItems = value;
                NotifyPropertyChanged("CheckInItems");
            }
        }

        //list to hold badges
        ObservableCollection<BadgeItem> badgeItems = new ObservableCollection<BadgeItem>();
        public ObservableCollection<BadgeItem> BadgeItems
        {
            get { return badgeItems; }
            set
            {
                badgeItems = value;
                NotifyPropertyChanged("BadgeItems");
            }
        }

        ObservableCollection<FriendItem> friendItem = new ObservableCollection<FriendItem>();
        public ObservableCollection<FriendItem> FriendItem
        {
            get { return friendItem; }
            set
            {
                friendItem = value;
                NotifyPropertyChanged("FriendItem");
            }
        }

        ObservableCollection<TipsItem> tipItem = new ObservableCollection<TipsItem>();
        public ObservableCollection<TipsItem> TipItem
        {
            get { return tipItem; }
            set
            {
                tipItem = value;
                NotifyPropertyChanged("TipItem");
            }
        }

        ObservableCollection<mayorshipItem> mayorItem = new ObservableCollection<mayorshipItem>();
        public ObservableCollection<mayorshipItem> MayorItem
        {
            get { return mayorItem; }
            set
            {
                mayorItem = value;
                NotifyPropertyChanged("MayorItem");
            }
        }
        

        //We will store our map in this variable which is passed in the 
        //constructor
        Map MyMap;

        //class constructor
        public UserViewModel(Map map)
        {
            client = new HttpClient();
            this.MyMap = map;
        }
         
        #region loading methods
        //method we will call to get the users data
        //pass in grid so we can switch visibility when data is ready
        public async void getSignedInUser(Grid userProfileGrid, ProgressBar progressBar)
        {

            //variable to hold response
            string returnedUserJson=null;
            //use this bool to check for any errors that occur
            bool hasError = false;

            //place web calls in try catch block just incase a network error occurs
            //try catch will also stop app from crashing if error does occur
            try
            {
                //client.getStringAsync will make the asynchronous call to the desired url
                //the response (json string) will be stored into the returnedUser string
                returnedUserJson = await client.GetStringAsync(url);
            }
            catch
            {
                //set error to true because a web exception occurred
                hasError = true;
            }
            

            //if has error is false then we can deserialize the string
            if(!hasError)
            {
                //bool to signify error
                bool jsonError = false;

                //the object we will deserialize to
                UserClass.RootObject uc = null;

                //try catch json incase some unknown error happens like an int being set to null
                try
                {
                    //let Json.Net deserialize the json string. passing in the json string we recieved and the typeof
                    uc = (UserClass.RootObject)JsonConvert.DeserializeObject(returnedUserJson, typeof(UserClass.RootObject));
                }
                catch
                {
                    //if there was an error
                    jsonError = true;
                }
                
                //if there was no error then let us set our variables
                if(!jsonError)
                {
                    
                    //we take the variables we need from the json and put it into our userProfile list
                    //UserProfile.Add(new UserProfile()
                    //{
                    //    firstName = uc.response.user.firstName,
                    //    lastName = uc.response.user.lastName,
                    //    hometown = uc.response.user.homeCity,
                    //    tipCount = uc.response.user.tips.count,
                    //    badgesCount = uc.response.user.badges.count,
                    //    checkInCount = uc.response.user.checkins.count,
                    //    friendCount = uc.response.user.friends.count,
                    //    email = uc.response.user.contact.email,
                    //    image = uc.response.user.photo.prefix + "original" + uc.response.user.photo.suffix,
                    //    maxScore = uc.response.user.scores.max,
                    //    recentScore = uc.response.user.scores.recent,
                    //    mayorshipCount = uc.response.user.mayorships.count,
                    //    lastLocation = uc.response.user.firstName + " " +uc.response.user.lastName + " at " + uc.response.user.checkins.items.First().venue.name,
                    //    lastLongitudeLocation = uc.response.user.checkins.items.First().venue.location.lng,
                    //    lastLatitudeLocation =uc.response.user.checkins.items.First().venue.location.lat
                    //});

                    //set variables the long way because of null classes that can be sent back if you have an unused account
                    UserItem up = new ClassFolder.UserItem();
                        up.firstName = uc.response.user.firstName;
                        up.lastName = uc.response.user.lastName;
                        up.hometown = uc.response.user.homeCity;
                        up.tipCount = uc.response.user.tips.count;
                        up.badgesCount = uc.response.user.badges.count;
                        up.checkInCount = uc.response.user.checkins.count;
                        up.friendCount = uc.response.user.friends.count;
                        up.email = uc.response.user.contact.email;
                        up.image = uc.response.user.photo.prefix + "original" + uc.response.user.photo.suffix;

                        //when a user has no recent or max score the server returns null to the class
                        //we need to do this so that the any variables used inside scores class have a default value
                        if (uc.response.user.scores == null)
                        {
                            up.maxScore = 0;
                            up.recentScore = 0;
                        }    
                        else
                        {
                            up.maxScore = uc.response.user.scores.max;
                            up.recentScore = uc.response.user.scores.recent;
                        }
                        
                        up.mayorshipCount = uc.response.user.mayorships.count;

                        //have to check count of checkin items. for someone who has never checked in the class will be null
                        //causing the application to crash
                        if(uc.response.user.checkins.items.Count > 0)
                        {
                            up.lastLocation = uc.response.user.firstName + " " + uc.response.user.lastName + " at " + uc.response.user.checkins.items.First().venue.name;
                            up.lastLongitudeLocation = uc.response.user.checkins.items.First().venue.location.lng;
                            up.lastLatitudeLocation = uc.response.user.checkins.items.First().venue.location.lat;

                            //finally add user to list
                            UserProfile.Add(up);
                            up = null;

                            //set map coordinates if there was a last known place
                            setMapToLastVisitedLocation(new GeoCoordinate() { Latitude = UserProfile[0].lastLatitudeLocation, Longitude = userProfile[0].lastLongitudeLocation });
                        }
                        else
                        {
                            up.lastLocation = uc.response.user.firstName + " " + uc.response.user.lastName + " has no last known location";

                            //finally add user to list
                            UserProfile.Add(up);
                            up = null;
                            
                        }
                        
                    //change visibility to make profile grid visible
                    //and make visibility of progress bar collapsed
                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            
                            userProfileGrid.Visibility = Visibility.Visible;
                            progressBar.Visibility = Visibility.Collapsed;
                            progressBar.IsEnabled = false;
                        });

                    
                }
                

            }
            //there was an error so just stop the loading and pop up a message box
            else
            {

            }

        }

        //load check ins pass in grid and progressbar to change visibility
        public async void loadCheckIns(Grid checkInGrid, ProgressBar progressBar)
        {
            //check ins url
            var url = "https://api.foursquare.com/v2/users/self/checkins?oauth_token=" + App.accessToken + "&limit=10" + "&v=" + App.date;

            //string that will hold json string response
            string response = null;

            //bool for errors
            bool error = false;

            //try catch around our network call
            try
            {
                //make call to url and store returned json string into response variable
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //set error to true if exception is caught
                error = true;
            }

            if(!error)
            {
                //temp bool for json error
                bool jsonError = false;
                //temporary list to deserialize json to
                CheckIn.RootObject checkInList = null;
                try
                {
                    //deserialize json
                    checkInList = JsonConvert.DeserializeObject<CheckIn.RootObject>(response);
                }
                catch
                {
                    //set error to true if exception caught
                    jsonError = true;
                }

                //do this if there was no error
                if(!jsonError)
                {
                    for(int x = 0; x < checkInList.response.checkins.items.Count; x++)
                    {
                        CheckInItems.Add(new checkInItem()
                        {
                            shout = checkInList.response.checkins.items[x].shout,
                            venueName = checkInList.response.checkins.items[x].venue.name,
                            latitude = checkInList.response.checkins.items[x].venue.location.lat,
                            longitude = checkInList.response.checkins.items[x].venue.location.lng,
                            timeAgo = checkInList.response.checkins.items[x].timeZoneOffset,
                            image = checkInList.response.checkins.items[x].venue.categories[0].icon.prefix + "bg_64" + checkInList.response.checkins.items[x].venue.categories[0].icon.suffix
                        });
                    }

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            checkInGrid.Visibility = Visibility.Visible;
                            progressBar.Visibility = Visibility.Collapsed;
                            progressBar.IsEnabled = false;
                        });
                }

            }


        }

        //load badges. pass in grid and progressbar to change visibility
        public async void loadBadges(Grid badgeGrid, ProgressBar progressBar)
        {
            //url to load badges
            var url = "https://api.foursquare.com/v2/users/self/badges?oauth_token=" + App.accessToken + "&v=" + App.date;

            //string response
            string response = null;

            //error for web call
            bool error = false;

            //BadgeClass
            BadgeClass.RootObject badge = null;

            //try catch to catch any web errors
            try
            {
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //set error to true when exception is caught
                error = true;
            }

            //if there was no error then deserialize
            if(!error)
            {
                //bool for json errors
                bool jsonError = false;
                try
                {
                    //deserialize
                    badge = JsonConvert.DeserializeObject<BadgeClass.RootObject>(response);
                }
                catch
                {
                    jsonError = true;
                }

                //if no error then let us continue
                if(!jsonError)
                {
                    //badges are weird in their return. so we get a count of total badges given and add them up
                    int counter = 0;
                    int groupCount = badge.response.sets.groups.Count;

                    for (int x = 0; x < groupCount; x++ )
                    {
                        //going to count all badges combined in 3 groups
                        counter += badge.response.sets.groups[x].items.Count;
                    }

                    List<BadgeItem> tempItems = new List<BadgeItem>();
                    tempItems.Add(new BadgeItem() {image = badge.response.badges.__invalid_name__4c4f08667a0803bbac202ab7.image.prefix + badge.response.badges.__invalid_name__4c4f08667a0803bbac202ab7.image.sizes[2] + badge.response.badges.__invalid_name__4c4f08667a0803bbac202ab7.image.name
                        , name = badge.response.badges.__invalid_name__4c4f08667a0803bbac202ab7.name});
                   
                        for (int x = 0; x < groupCount; x++)
                        {
                            BadgeItems.Add(new BadgeItem()
                                {

                                    name = badge.response.sets.groups[x].name,
                                    image = badge.response.sets.groups[x].image.prefix + badge.response.sets.groups[x].image.sizes[2] + badge.response.sets.groups[x].image.name
                                });


                        }

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            badgeGrid.Visibility = Visibility.Visible;
                            progressBar.Visibility = Visibility.Collapsed;
                            progressBar.IsEnabled = false;
                        });
                }
                
            }

        }

        //load friends list
        public async void loadFriends(Grid friendGrid, ProgressBar progressBar)
        {
            //the url to get our friends
            var url = "https://api.foursquare.com/v2/users/self/friends?oauth_token=" + App.accessToken + "&v=" + App.date;

            //bool for error
            bool error = false;

            //string to hold response
            string response=null;

            try
            {
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //set error to true if exception was thrown
                error = true;
            }

            //if no error then deserialize
            if(!error)
            {
                //bool for json errors
                bool jsonError = false;

                //object to deserialize to
                FriendsClass.RootObject fc = null;
                try
                {
                    //deserialize data
                    fc = JsonConvert.DeserializeObject<FriendsClass.RootObject>(response);
                }
                catch
                {
                    jsonError = true;
                }

                //if no error lets put items into list
                if(!jsonError)
                {
                    for(int x = 0; x < fc.response.friends.count; x++)
                    {
                        FriendItem.Add(new FriendItem()
                            {
                                hometown = fc.response.friends.items[x].homeCity,
                                id = fc.response.friends.items[x].id,
                                name = fc.response.friends.items[x].firstName + " " + fc.response.friends.items[x].lastName,
                                image = fc.response.friends.items[x].photo.prefix + "100x100" + fc.response.friends.items[x].photo.suffix
                            });
                    }

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            friendGrid.Visibility = Visibility.Visible;
                            progressBar.Visibility = Visibility.Collapsed;
                            progressBar.IsEnabled = false;
                        });
                }
            }

        }

        //load Tips
        public async void loadTips(Grid tipGrid, ProgressBar progressBar)
        {
            //bool for error
            bool error = false;

            //url
            string url = "https://api.foursquare.com/v2/users/self/tips?sort=recent&oauth_token=" + App.accessToken + "&v=" + App.date;

            //string will store json response
            string response = null;

            try
            {
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //set error to true for caught exception
                error = true;
            }

            //if no error then deserialize
            if(!error)
            {
                //bool for json errors
                bool jsonError = false;

                //object to parts json
                TipClass.RootObject tc = null;

                //try catch incase json fails
                try
                {
                    tc = JsonConvert.DeserializeObject<TipClass.RootObject>(response);
                }
                catch
                {
                    //make true if exception caught
                    jsonError = true;
                }

                //if no error then continue
                if(!jsonError)
                {
                    for(int x = 0; x < tc.response.tips.count; x++)
                    {
                        TipItem.Add(new TipsItem()
                        {
                            restName = tc.response.tips.items[x].venue.name,
                            id = tc.response.tips.items[x].venue.id,
                            tipNote = tc.response.tips.items[x].text
                        });
                    }

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                        {
                            progressBar.Visibility = Visibility.Collapsed;
                            progressBar.IsEnabled = false;
                            tipGrid.Visibility = Visibility.Visible;
                        });
                }

            }
        }

        //load mayoriship
        public async void loadMayorShip(Grid mayorGrid, ProgressBar progressBar)
        {
            //bool for error
            bool error = false;

            //url string
            string url = "https://api.foursquare.com/v2/users/self/mayorships?oauth_token=" + App.accessToken + "&v=" + App.date;

            //variable to hold response
            string response = null;

            //try catch to catch any web errors
            try
            {
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //catch error
                error = true;
            }

            //if no error then deserialize
            if(!error)
            {
                //bool for json errors
                bool jsonError = false;
                //json object to deserialize to
                mayorshipClass.RootObject mc = null;

                try
                {
                    mc = JsonConvert.DeserializeObject<mayorshipClass.RootObject>(response);
                }
                catch
                {
                    //set to true when error caught
                    jsonError = true;
                }

                //if no error
                if(!jsonError)
                {
                    for(int x = 0; x < mc.response.mayorships.items.Count; x++)
                    {
                        MayorItem.Add(new mayorshipItem()
                        {
                            category = mc.response.mayorships.items[x].venue.categories[0].name,
                            id = mc.response.mayorships.items[x].venue.id,
                            venueName = mc.response.mayorships.items[x].venue.name,
                            image = mc.response.mayorships.items[x].venue.categories[0].icon.prefix +"bg_64" + mc.response.mayorships.items[x].venue.categories[0].icon.suffix
                        });
                    }

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                    {
                        mayorGrid.Visibility = Visibility.Visible;
                        progressBar.Visibility = Visibility.Collapsed;
                        progressBar.IsEnabled = false;
                    });
                }


            }

        }


        #endregion

        //We will use this method to set our map location on the ui
        public void setMapToLastVisitedLocation(GeoCoordinate coordinates)
        {
            //clear any markings on the map
            MyMap.Layers.Clear();

            //create a new layer to place on the map
            MapLayer mapLayer = new MapLayer();

            //check if coordinates have a value
            if(coordinates != null)
            {
                DrawMapMarker(coordinates, Colors.Black, mapLayer);
            }

            //after marker is drawn add it to map layers
            MyMap.Layers.Add(mapLayer);
            MyMap.SetView(coordinates, 15);

        }

        private void DrawMapMarker(GeoCoordinate coordinate, Color color, MapLayer mapLayer)
        {
            // Create a map marker
            Polygon polygon = new Polygon();
            polygon.Points.Add(new Point(0, 0));
            polygon.Points.Add(new Point(0, 75));
            polygon.Points.Add(new Point(25, 0));
            polygon.Fill = new SolidColorBrush(color);

            // Create a MapOverlay and add marker
            MapOverlay overlay = new MapOverlay();
            overlay.Content = polygon;
            overlay.GeoCoordinate = new GeoCoordinate(coordinate.Latitude, coordinate.Longitude);
            overlay.PositionOrigin = new Point(0.0, 1.0);
            mapLayer.Add(overlay);
        }


    }
}
