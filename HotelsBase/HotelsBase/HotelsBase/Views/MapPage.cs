using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HotelsBase.Models;
using HotelsBase.ViewModels;
using Xamarin.Forms.Maps;


namespace HotelsBase.Views
{
    //добавить страничку с картой всех отелей минска
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            //InitializeComponent();
            var map = new Map();
            map.IsShowingUser = true;

            var rootPage = new ContentPage();
            rootPage.Content = map;

            //MainPage = rootPage;
            //var map = new Map(
            //MapSpan.FromCenterAndRadius(
            //        new Position(37, -122), Distance.FromMiles(0.3)))
            //{
            //    IsShowingUser = true,
            //    HeightRequest = 100,
            //    WidthRequest = 960,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};
            //var stack = new StackLayout { Spacing = 0 };
            //stack.Children.Add(map);
            //Content = stack;
        }
    }
}
