using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HotelsBase.Models;
using HotelsBase.ViewModels;

namespace HotelsBase.Views
{
    
    public partial class HostelsViewPage : ContentPage
    {
        public HostelsViewPage()
        {
            InitializeComponent();
            //BindingContext = new FriendsListViewModel() { Navigation = this.Navigation };
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ((App)App.Current).ResumeAtTodoId = -1;
            MyListView.ItemsSource = await App.Database.GetItemsAsync();
        }
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new OfferDetailPage  //OfferPage
                {
                    BindingContext = e.SelectedItem as Offers
                });
            }
        }
        private async void CreateFriend(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OfferPage
            {
                BindingContext = new Offers()
            });
        }
    }
}
