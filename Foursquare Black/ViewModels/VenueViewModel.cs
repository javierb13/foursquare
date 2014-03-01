using Foursquare_Black.ClassFolder;
using Microsoft.Phone.Maps.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Device.Location;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace Foursquare_Black.ViewModels
{
    class VenueViewModel : ViewModel
    {
        #region variables and properties
        //VenueItem variable
        VenueItem singleVenueItem = new VenueItem();
        public VenueItem SingleVenueItem
        {
            get { return singleVenueItem; }
            set
            {
                singleVenueItem = value;
                NotifyPropertyChanged("SingleVenueItem");
            }
        }

        ObservableCollection<VenueItem> venueItems = new ObservableCollection<VenueItem>();
        public ObservableCollection<VenueItem> VenueItems
        {
            get { return venueItems; }
            set
            {
                venueItems = value;
                NotifyPropertyChanged("VenueItems");
            }
        }

        //holds all photos returned of a vanue
        ObservableCollection<VenuePhotoItem> photoItems = new ObservableCollection<VenuePhotoItem>();
        public ObservableCollection<VenuePhotoItem> PhotoItems
        {
            get { return photoItems; }
            set
            {
                photoItems = value;
                NotifyPropertyChanged("PhotoItems");
            }
        }

        //holds all tip comments about a venue
        ObservableCollection<VenueTipItem> tipItems = new ObservableCollection<VenueTipItem>();
        public ObservableCollection<VenueTipItem> TipItems
        {
            get { return tipItems; }
            set
            {
                tipItems = value;
                NotifyPropertyChanged("TipItems");
            }
        }

        //add classes into this view model because the classes are so small
        public class VenuePhotoItem
        {
            //hold image url
            public string image { get; set; }
        }

        public class VenueTipItem
        {
            //tip comment that user has left
            public string comment { get; set; }

            //user name
            public string userName { get; set; }

            //users ID
            public string userId { get; set; }
        }

        //httpclient
        HttpClient client;

        //the map
        Map MyMap;
        #endregion

        public VenueViewModel(Map map)
        {
            //store our map
            this.MyMap = map;
            //call new on our client
            client = new HttpClient();
        }

        //load the venue data for selected store
        public async void loadVenueData(Grid venueGrid, ProgressBar progressBar, string venueId)
        {
            //bool for errors
            bool error = false;
            //variable to hold json response
            string response = null;
            //url
            string url = "https://api.foursquare.com/v2/venues/" + venueId + "?oauth_token=" + App.accessToken + "&v=" + App.date;

            //try catch block around our network request
            try
            {
                response = await client.GetStringAsync(url);
            }
            catch
            {
                //catch error and set to true
                error = true;
            }

            //if there is no error then deserialize the content
            if(!error)
            {
                //bool for json errors
                bool jsonError = false;
                //variable to deserialize to
                VenueClass.RootObject vc = null;

                try
                {
                    vc = JsonConvert.DeserializeObject<VenueClass.RootObject>(response);
                }
                catch
                {
                    
                    jsonError = true;
                }

                //if there was no error then continue
                if(!jsonError)
                {
                    //we will only add a couple of pictures to our photo list to avoid having to download all photos
                    //lets limit it to 3 photos
                    if(vc.response.venue.photos.count > 3)
                    {
                        for(int x = 0; x < 3; x++)
                        {
                            PhotoItems.Add(new VenuePhotoItem()
                            {
                                //we use hard code zero just because group 0 is venue photos
                                image = vc.response.venue.photos.groups[0].items[x].prefix + "original" + vc.response.venue.photos.groups[0].items[x].suffix
                            });
                        }
                    }

                    //next add our tips to the tips list
                    //we can add them all since text is light and we wont need to download from internet like photos
                    //hard code 0 because 0 is other tips
                    for(int x = 0; x < vc.response.venue.tips.groups[0].items.Count; x++)
                    {
                        TipItems.Add(new VenueTipItem()
                        {
                            userId = vc.response.venue.tips.groups[0].items[x].user.id,
                            userName = vc.response.venue.tips.groups[0].items[x].user.firstName + " " + vc.response.venue.tips.groups[0].items[x].user.lastName,
                            comment = vc.response.venue.tips.groups[0].items[x].text
                        });
                    }

                    VenueItem temp = new VenueItem();
                    //now we just set our variables up
                    temp.MayorName = vc.response.venue.mayor.user.firstName + " " + vc.response.venue.mayor.user.lastName;
                    temp.MayorImage = vc.response.venue.mayor.user.photo.prefix + "64x64" + vc.response.venue.mayor.user.photo.suffix;
                    temp.CategoryName = vc.response.venue.categories.First().name;
                    temp.CategoryImage = vc.response.venue.categories.First().icon.prefix + "bg_64" + vc.response.venue.categories.First().icon.suffix;
                    temp.Rating = vc.response.venue.rating;
                    temp.Likes = vc.response.venue.likes.count;
                    temp.CheckInStats = vc.response.venue.stats.checkinsCount;
                    temp.CheckInVisitors = vc.response.venue.stats.usersCount;
                    temp.Longitude = vc.response.venue.location.lng;
                    temp.Latitude = vc.response.venue.location.lat;
                    temp.description = vc.response.venue.description;
                    temp.venueName = vc.response.venue.name;

                    VenueItems.Add(temp);

                    Deployment.Current.Dispatcher.BeginInvoke(() =>
                    {
                        venueGrid.Visibility = Visibility.Visible;
                        progressBar.IsEnabled = false;
                        progressBar.Visibility = Visibility.Collapsed;
                    });

                    setMapToLastVisitedLocation(new GeoCoordinate() { Longitude = singleVenueItem.Longitude, Latitude = singleVenueItem.Latitude }, MyMap);
                }
            }

        }

        //We will use this method to set our map location on the ui
        public void setMapToLastVisitedLocation(GeoCoordinate coordinates, Map MyMap)
        {
            //clear any markings on the map
            MyMap.Layers.Clear();

            //create a new layer to place on the map
            MapLayer mapLayer = new MapLayer();

            //check if coordinates have a value
            if (coordinates != null)
            {
                DrawMapMarker(coordinates, Colors.Black, mapLayer);
            }

            //after marker is drawn add it to map layers
            MyMap.Layers.Add(mapLayer);
            MyMap.SetView(coordinates, 16);

        }

        private void DrawMapMarker(GeoCoordinate coordinate, System.Windows.Media.Color color, MapLayer mapLayer)
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
