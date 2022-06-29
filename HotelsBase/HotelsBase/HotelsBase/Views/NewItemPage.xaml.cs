using System;
using System.Collections.Generic;
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
    public partial class NewItemPage : ContentPage
    {
        public Hotel Reviews { get; set; }
        public Review Review { get; set; }
        public HotelViewModel ViewModel { get; private set; } ///---
        public NewItemPage(HotelViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            this.BindingContext = ViewModel;
        }


        public NewItemPage()
        {
            InitializeComponent();
        }
        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Review);
            await Navigation.PopModalAsync();
        }
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void PickerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            StarsEntry.Text = pickerType.Items[pickerType.SelectedIndex];
        }

        private void StarsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }
    }
}