using HotelsBase.Models;
using HotelsBase.ViewModels;
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
    public partial class RoomDetailPage : ContentPage
    {
        //private Hotel item;

        public HotelViewModel ViewModel { get; private set; } ///---
        public RoomDetailPage(HotelViewModel viewModel)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            //BindingContext = this.ViewModel = viewModel;
            ViewModel = viewModel;       //-----
            //BindingContext = new HotelsListViewModel() { Navigation = this.Navigation };
            this.BindingContext = ViewModel; //---
        }
        public RoomDetailPage()
        {
            InitializeComponent();
        }

       
    }
}