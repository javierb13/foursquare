using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Foursquare_Black
{
    public partial class loginPage : PhoneApplicationPage
    {
        public loginPage()
        {
            InitializeComponent();
            Loaded += loginPage_Loaded;
        }

        void loginPage_Loaded(object sender, RoutedEventArgs e)
        {
            //execute when page loads
            var url = "https://foursquare.com/oauth2/authorize?display=touch&client_id="
                        + App.clientId + "&client_secret=" + App.clientSecret + "&response_type=token&redirect_uri=http://www.foursquare.com";

            //navigate web browser to this link
            WebBrowserLogin.Navigate(new Uri(url, UriKind.RelativeOrAbsolute));
            WebBrowserLogin.Navigating += WebBrowserLogin_Navigating;
        }

        void WebBrowserLogin_Navigating(object sender, NavigatingEventArgs e)
        {
            if (e.Uri.Host.Equals("www.foursquare.com"))
            {
                //get the response string that has the access token
                string responseString = e.Uri.ToString();

                //take the response string and break it into two parts
                string[] splitAccessToken = responseString.Split(new char[] { '#', '=' });

                //take the array of string and place them into string and another into value pair
                //accessTokenString when split will hold the key which should be access_token
                //accessTokenValue should hold the actual token value. the long string of letters and numbers
                string accessTokenString = splitAccessToken.GetValue(1).ToString();
                string accessTokenValue = splitAccessToken.GetValue(2).ToString();

                //if the accessTokenString is equal to access_token then we know we have the correct item
                if (accessTokenString == "access_token")
                {
                    //store the accessTokenValue into accessToken variable which resides in App.xaml.cs for global use
                    App.accessToken = accessTokenValue;

                    //if the accessToken is not null then we have received the token value and we can navigate to previous page
                    if (App.accessToken != null)
                    {
                        //navigate to home page
                        //use go back instead of navigate so we dont make new resource for a page we already have
                        //GoBack will pop off this current page (loginPage.xaml) from the page stack
                        NavigationService.GoBack();
                    }

                }
                else
                {
                    //we failed to get the access_token display error message then return back to home page
                    //so the user can try and sign in again
                    NavigationService.GoBack();
                }

            }
        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {
            //execute when page loads
            var url = "https://foursquare.com/oauth2/authorize?display=touch&client_id="
                        + App.clientId + "&client_secret=" + App.clientSecret + "&response_type=token&redirect_uri=http://www.foursquare.com";

            //navigate web browser to this link
            WebBrowserLogin.Navigate(new Uri(url, UriKind.RelativeOrAbsolute));
            WebBrowserLogin.Navigating += WebBrowserLogin_Navigating;
        }
    }
}