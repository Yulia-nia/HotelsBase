﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

using HotelsBase.ViewModels;


namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoogleMapPage : ContentPage
    {
        Map map;
        
        public GoogleMapPage()
        {
            InitializeComponent();
           
            // var map = new Map(
            //MapSpan.FromCenterAndRadius(
            //        new Position(37, -122), Distance.FromMiles(0.3)))
            // {
            //     IsShowingUser = true,
            //     HeightRequest = 100,
            //     WidthRequest = 960,
            //     VerticalOptions = LayoutOptions.FillAndExpand
            // };
            // var stack = new StackLayout { Spacing = 0 };
            // stack.Children.Add(map);
            // Content = stack;
        }
    }
    }
