using HotelsBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.Messaging;
using Xamarin.Forms.Maps;
using HotelsBase.Models;

namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferDetailPage : ContentPage
    {
       // Button phoneNumber;
        //public FriendViewModel ViewModel { get; private set; }
        //public OfferDetailPage(FriendViewModel vm)
        //{
        //    InitializeComponent();
        //    ViewModel = vm;
        //    this.BindingContext = ViewModel;
        //}
        public OfferDetailPage()
        {
            InitializeComponent();
        }

        async void OnChangeClicked(object sender, EventArgs e) //???
        {
            //if (e.SelectedItem != null)
            //{
            await Navigation.PushAsync(new OfferPage());  //OfferPage
                                                          //{
                                                          //    BindingContext =  Offers
                                                          //});
                                                          //}
                                                          //await Navigation.PushAsync(new OfferPage(ViewModel));
        }
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (Offers)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopModalAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        //для звонков
        private void Button_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(phoneNumber.Text); //тут поменять
        }

        async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new GoogleMapPage()));   ///=========
        }

       
    }
}