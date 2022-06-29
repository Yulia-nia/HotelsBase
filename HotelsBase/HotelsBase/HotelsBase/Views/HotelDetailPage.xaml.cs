using HotelsBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HotelsBase.Models;
using Plugin.Messaging;
using Android.Media;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Xamarin.Essentials;
using Plugin.TextToSpeech;

namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelDetailPage : ContentPage
    {
        public HotelViewModel ViewModel { get; private set; } ///---
        //public List<HotelViewModel> Favorite_Hotels { get; private set; } ///---
       public HotelDetailPage(HotelViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;       //-----
            this.BindingContext = ViewModel; //---

            //SetIsEnabledButtonState(false, true);
            //image.Opacity = 0;
            //image.FadeTo(1, 4000);
            //SetIsEnabledButtonState(true, false);

          
        }
        public HotelDetailPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
           // SetIsEnabledButtonState(false, true);
            image.Opacity = 0;
            await image.FadeTo(1, 4000);
            //SetIsEnabledButtonState(true, false);
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var text = AnimatedTextControl.Text;            
            CrossTextToSpeech.Current.Speak(text);
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            AnimatedTextControl.IsRunning = !AnimatedTextControl.IsRunning;
        }

        //cal
        private void Button_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall(phoneNumberEntry.Text);
        }

        //email
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail(Button_email.Text);
            }
        }

        //web
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://" + $"{Button_web.Text}"));           
        }        
    }
}