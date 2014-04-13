using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
using NasaReader.Integration.Utils;
using NasaReader.Integration.Enums;

namespace NasaReader
{
    public partial class RSSFeedSourcesPage : PhoneApplicationPage
    {
        public RSSFeedSourcesPage()
        {
            InitializeComponent();
        }

        private void BreakingNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.BreakingNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));      
        }

        private void EducationNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.EducationNews;       	   
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void OnTheStation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.OnTheStation;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void KeplerMission_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.KeplerMission;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void InternationalSpaceStation_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.InternationalSpaceStation;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void SpaceStationNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.SpaceStationNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void SolarNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.SolarNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void UniverseNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.UniverseNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void EarthNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.EarthNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void AeronauticsNews_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.AeroanuticsNews;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void HurricaneUpdate_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	PhoneApplicationService.Current.State["feed"] = NasaEnums.NasaSources.HurricaneUpdate;
        	this.NavigationService.Navigate(new Uri("/RSSFeedsPage.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, System.EventArgs e)
        {
        	this.NavigationService.Navigate(new Uri("/RSSAboutPage.xaml", UriKind.Relative));
        }

    }
}