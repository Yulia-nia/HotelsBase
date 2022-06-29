using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HotelsBase.Views
{
    public class StartPage : ContentPage
    {
        public StartPage()
        {
            var b = new Button { Text = "Launch sample" };
            b.Clicked += (sender, e) => Navigation.PushAsync(new UrhoPage());
            Content = new StackLayout { Children = { b }, VerticalOptions = LayoutOptions.Center };
        }
    }
}
