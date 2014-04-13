using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using NasaReader.Integration.Enums;
using NasaReader.Integration.Utils;
using System.Runtime.Serialization.Json;
using NasaReader.Integration.DataContracts.Feed;
using NasaReader.Integration.DataContracts;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Net.NetworkInformation;
using ImageTools.IO.Gif;

namespace NasaReader
{
    public partial class RSSFeedsPage : PhoneApplicationPage
    {

        public Uri ImageSource { get; set; }

        public RSSFeedsPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ImageTools.IO.Decoders.AddDecoder<GifDecoder>();
            this.DataContext = this;
            ImageSource = new Uri("/Assets/Images/loader.gif", UriKind.Relative);
            NasaEnums.NasaSources enums = (NasaEnums.NasaSources)PhoneApplicationService.Current.State["feed"];
            int code = (int)enums;
            this.Page_Title.Text = EnumUtil.getEnumDescription((NasaEnums.NasaTitles)code);
            PrepareRSSData(new Uri(EnumUtil.getEnumDescription(enums)));
        }

        private void PrepareRSSData(Uri src)
        {
                WebClient wc = new WebClient();
                wc.OpenReadCompleted += new OpenReadCompletedEventHandler(LoadNasaRSSData);
                wc.OpenReadAsync(src);               
        }

        private void LoadNasaRSSData(object sender, OpenReadCompletedEventArgs e)
        {
            if(e.Error == null)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(FeedsContractType));
                FeedsContractType feed = (FeedsContractType)serializer.ReadObject(e.Result) ?? new FeedsContractType();
                LayoutUtil.GenerateDynamicGridSkeleton(3, ContentPanel);
                ///Generating 3 column grid
                int row = 0, col = 0;
                for (int i = 0; i < feed.value.items.Length; i++)
                {
                    if (i > 0 && i % 3 == 0)
                    {
                        RowDefinition newrow = new RowDefinition();
                        ContentPanel.RowDefinitions.Add(newrow);
                        col = 0;
                        row++;
                    }
                    Grid grid = new Grid();
                    grid.Width = 145;
                    grid.Height = 145;
                    grid.Background = new SolidColorBrush(Color.FromArgb(255, 42, 58, 112));
                    TextBlock date = new TextBlock();
                    date.Text = DataUtil.UnixTimeStampToDateCustom(feed.value.items[i].published.utime, "MM/dd/yyyy");
                    date.VerticalAlignment = VerticalAlignment.Top;
                    date.HorizontalAlignment = HorizontalAlignment.Center;
                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri("/Assets/Images/rss.png", UriKind.Relative));
                    img.Width = 100;
                    img.Height = 85;
                    img.Opacity = 0.10;
                    Grid.SetColumn(grid, col++);
                    Grid.SetRow(grid, row);
                    grid.Resources.Add("feedindex", i);
                    grid.Tap += (o, ev) =>
                    {
                        Grid broadcaster = (Grid)o;
                        PhoneApplicationService.Current.State["allfeeds"] = feed.value.items;
                        PhoneApplicationService.Current.State["feedindex"] = broadcaster.Resources["feedindex"];
                        this.NavigationService.Navigate(new Uri("/RSSDataPage.xaml", UriKind.Relative));
                    };
                    grid.Children.Add(date);
                    grid.Children.Add(img);
                    ContentPanel.Children.Add(grid);
                }
            }
            else
                MessageBox.Show(EnumUtil.getEnumDescription(MessagesEnum.ConnectionErrors.NoConnectionError));
            Image.Opacity = 0.0;
        }

        private void About_Click(object sender, System.EventArgs e)
        {
        	this.NavigationService.Navigate(new Uri("/RSSAboutPage.xaml", UriKind.Relative));
        }

    }
}
