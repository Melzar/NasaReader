using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;
using NasaReader.Integration.DataContracts;
using NasaReader.Integration.Enums;
using NasaReader.Integration.Utils;
using NasaReader.Integration.DataContracts.Feed;
using System.Reflection;

namespace NasaReader
{
    public partial class RSSDataPage : PhoneApplicationPage
    {

        public RSSDataPage()
        {
            InitializeComponent();
            Loaded += RSSDataPage_Loaded;        
        }

        void RSSDataPage_Loaded(object sender, RoutedEventArgs e)
        {
            FeedContractType[] contracts = (FeedContractType[])PhoneApplicationService.Current.State["allfeeds"];
            for (int i = 0; i < contracts.Length; i++)
            {
                TextBlock text = this.FindName("Title_Box" + i) as TextBlock;
                TextBlock data = this.FindName("Data_Box" + i) as TextBlock;
                TextBlock contract = this.FindName("RSS_Content" + i) as TextBlock;
                HyperlinkButton hyperlink = this.FindName("Hyperlink" + i) as HyperlinkButton;
                text.Text = contracts[i].title;
                data.Text = DataUtil.FormatDataFromContract(contracts[i]);
                contract.Text = contracts[i].description;
                hyperlink.NavigateUri = new Uri (contracts[i].link, UriKind.Absolute);
                hyperlink.Content = "Go to Source Page";
                hyperlink.TargetName = "_blank";
            }
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            setDefaultPivotPage((int)PhoneApplicationService.Current.State["feedindex"]);
        }

        private void setDefaultPivotPage(int index)
        {
            PivotFeeds.SelectedIndex =  index ;
        }

        private void About_Click(object sender, System.EventArgs e)
        {
        	this.NavigationService.Navigate(new Uri("/RSSAboutPage.xaml", UriKind.Relative));
        }

    }
}