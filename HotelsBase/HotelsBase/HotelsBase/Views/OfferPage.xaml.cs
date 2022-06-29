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
using System.IO;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

using Plugin.Media;
using Plugin.Media.Abstractions;

namespace HotelsBase.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        //public FriendViewModel ViewModel { get; private set; }
        //public OfferPage(FriendViewModel vm)
        //{
        //    InitializeComponent();
        //    ViewModel = vm;
        //    this.BindingContext = ViewModel;


        //}

        public OfferPage()
        {
            InitializeComponent();
        }


        //-----------------------
        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as Button).IsEnabled = false;

            System.IO.Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }
            (sender as Button).IsEnabled = true;

            //image = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"

            //entryPhoto.Text = image.Source.ToString();
        }

        //---------------------------


        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (Offers)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (Offers)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            entryType.Text = pickerType.Items[pickerType.SelectedIndex];
        }
        void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            entryPhoto.Text = "NoPhoto.png";
        }

        //async void Button_Clicked(object sender, EventArgs e)
        //{ 
        ////{
        ////    if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
        ////    {

        //        MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
        //        {
        //            SaveToAlbum = true,
        //            Directory = "Sample",
        //            Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
        //        });

        //        if (file == null)
        //            return;

        //        image.Source = ImageSource.FromFile(file.Path);
        //   // }
        //}

        //void OnSpeakClicked(object sender, EventArgs e)
        //{
        //    var todoItem = (Offers)BindingContext;
        //    DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
        //}


        //для звонков
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var phoneDialer = CrossMessaging.Current.PhoneDialer;
        //    if (phoneDialer.CanMakePhoneCall)
        //        phoneDialer.MakePhoneCall(phoneNumberEntry.Text);
        //}
    }
}