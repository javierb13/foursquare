using Foursquare_Black.ClassFolder;
using Newtonsoft.Json;
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

namespace Foursquare_Black.ViewModels
{
    class ExploreViewModel : ViewModel
    {
        public ExploreViewModel()
        {
            client = new HttpClient();
        }

        ObservableCollection<GroupItem> exploreGroups = new ObservableCollection<GroupItem>();
        public ObservableCollection<GroupItem> ExploreGroups
        {
            get { return exploreGroups; }
            set
            {
                exploreGroups = value;
                NotifyPropertyChanged("ExploreGroups");
            }
        }

        ObservableCollection<exploreItem> exploreItems = new ObservableCollection<exploreItem>();
        public ObservableCollection<exploreItem> ExploreItems
        {
            get {return exploreItems;}
            set
            {
                exploreItems = value;
                NotifyPropertyChanged("ExploreItems");
            }
        }

        #region Load Explore Content. find everything related to explore here
        //http client used for load explore
        HttpClient client;

        //load explore. loading new york city by default
        //on normal occassion we would link gps location to this method to be passed in

        public async void loadExplore(ProgressBar progressBar, ListBox exploreListBox)
        {
            
            //bool for errors during network calls
            bool error = false;
            //string to hold json response
            string response = null;
            //url
            string url = "https://api.foursquare.com/v2/venues/explore?near=new york city,ny&client_id=" + App.clientId + "&client_secret=" + App.clientSecret + "&v=" + App.date;

            //try catch around network call
            try
            {
                response = await client.GetStringAsync(url);
            }
            catch(HttpRequestException e)
            {
                error = true;
            }

            //if there is no error then deserialize
            if (!error)
            {
                //bool for json error
                bool jsonError = false;
                //object to deserialize to
                ExploreClass.RootObject ec = null;

                //try catch around deserializing
                try
                {
                    ec = JsonConvert.DeserializeObject<ExploreClass.RootObject>(response);
                }
                catch
                {
                    jsonError = true;
                }


                if (!jsonError)
                {
                    //extract group names
                    for (int x = 0; x < ec.response.groups.Count; x++)
                    {
                        ExploreGroups.Add(new GroupItem()
                        {
                            groupName = ec.response.groups[x].name
                        });

                        for (int y = 0; y < ec.response.groups[x].items.Count; y++)
                        {
                            ExploreItems.Add(new exploreItem() 
                            {
                                name = ec.response.groups[x].items[y].venue.name,
                                catName = ec.response.groups[x].items[y].venue.categories[0].name,
                                catImage = ec.response.groups[x].items[y].venue.categories[0].icon.prefix + "bg_64" + ec.response.groups[x].items[y].venue.categories[0].icon.suffix,
                                longitude = ec.response.groups[x].items[y].venue.location.lng,
                                latitude = ec.response.groups[x].items[y].venue.location.lat
                            });
                        }
                    }

                }
                //groups
                Deployment.Current.Dispatcher.BeginInvoke(() =>
                {
                    progressBar.Visibility = Visibility.Collapsed;
                    progressBar.IsEnabled = false;
                    exploreListBox.Visibility = Visibility.Visible;
                });
            }

        }

        #endregion
    }
}
