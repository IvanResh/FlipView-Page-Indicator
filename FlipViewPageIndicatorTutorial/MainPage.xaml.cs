﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FlipViewPageIndicatorTutorial
{
        
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<string> Images { get; private set; }

        public MainPage()
        {
            this.InitializeComponent();
            Images = new ObservableCollection<string>()
            {
                "/1.jpg",
                "/2.jpg",
                "/3.jpg",
                "/4.jpg",
                "/5.jpg"
            };
        }
    }
}
