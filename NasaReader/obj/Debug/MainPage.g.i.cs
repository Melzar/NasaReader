﻿#pragma checksum "G:\WindowsPhoneApps\NasaReader\NasaReader\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4A98DA725ECE4A1DB4D04585EB8FECF9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NasaReader {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage MainPage1;
        
        internal System.Windows.Media.Animation.Storyboard EnterStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock NasaTitle;
        
        internal System.Windows.Controls.Image NasaLogo;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/NasaReader;component/MainPage.xaml", System.UriKind.Relative));
            this.MainPage1 = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("MainPage1")));
            this.EnterStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("EnterStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.NasaTitle = ((System.Windows.Controls.TextBlock)(this.FindName("NasaTitle")));
            this.NasaLogo = ((System.Windows.Controls.Image)(this.FindName("NasaLogo")));
        }
    }
}

