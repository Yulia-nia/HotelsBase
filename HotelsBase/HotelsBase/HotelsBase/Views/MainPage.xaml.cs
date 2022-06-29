using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ItemsPage());
        }

        async void Button_Clicked1Async1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HostelsViewPage());
        }
    }
}