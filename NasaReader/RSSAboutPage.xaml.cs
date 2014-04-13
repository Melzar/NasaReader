using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace NasaReader
{
    public partial class RSSAboutPage : PhoneApplicationPage
    {
        public RSSAboutPage()
        {
            InitializeComponent();
        }

        private void Contact_Me_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	this.NavigationService.Navigate(new Uri("/RSSMailMe.xaml", UriKind.Relative));
        }
    }
}