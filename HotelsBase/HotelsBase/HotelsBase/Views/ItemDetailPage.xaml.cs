using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HotelsBase.Models;
using HotelsBase.ViewModels;


namespace HotelsBase.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        public HotelViewModel ViewModel { get; private set; } ///---
        public ItemDetailPage(HotelViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;       //-----
            this.BindingContext = ViewModel; //---            
            // BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
        }
        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

    }
}