using HotelsBase.Models;
using HotelsBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.ComponentModel;

namespace HotelsBase.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    // [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RoomPage : ContentPage
    {        
        public HotelViewModel ViewModel { get; private set; } ///---
        public RoomPage(HotelViewModel viewModel)
        {
            InitializeComponent();

            //BindingContext = this.ViewModel = viewModel;
            ViewModel = viewModel;       //-----           
            this.BindingContext = ViewModel; //---
        }
       
        public RoomPage()
        {
            InitializeComponent();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Room selectedFriend = (Room)e.SelectedItem;
            RoomDetailPage friendPage = new RoomDetailPage();
            friendPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(friendPage);
        }

      

        //async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    //if (args.SelectedItem == null)
        //    //  return;
        //    //((ListView)sender).SelectedItem = null;
        //    // await ViewModel.na((HotelViewModel)args.SelectedItem);
        //    // MainPage.NavigateToPage(((MenuItem)((ListView)sender).SelectedItem).ID)

        //----------------------------------------
        //    HotelViewModel tempFriend = ViewModel;
        //    await Navigation.PushModalAsync(new RoomDetailPage(tempFriend));
        //----------------------------------------


        //   // var item = args.SelectedItem as HotelViewModel;

        //    //RoomDetailPage friendPage = new RoomDetailPage(item);
        //    //friendPage.BindingContext = item;
        //    //await Navigation.PushModalAsync(friendPage);
        //    // HotelViewModel tempFriend = value;
        //    //await Navigation.PushAsync(new RoomDetailPage(ViewModel));

        //    // Manually deselect item.
        //   // MyListView.SelectedItem = null;
        //}

    }
}
