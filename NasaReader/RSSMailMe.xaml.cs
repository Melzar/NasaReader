﻿using System;
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
using Microsoft.Phone.Tasks;

namespace NasaReader
{
    public partial class RSSMailMe : PhoneApplicationPage
    {

        public Uri ImageSource { get; set; }

        public RSSMailMe()
        {
            InitializeComponent();
        }
		
		protected override void OnNavigatedTo(NavigationEventArgs e)
        {
          
        }

        private void Send_Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
        	EmailComposeTask emailcomposer = new EmailComposeTask();
            emailcomposer.To = "melwaw@wp.pl";
            emailcomposer.Subject = "Windows Phone Feedback";
            emailcomposer.Body = Message_content.Text;
            emailcomposer.Show();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                               