using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HotelsBase.Models;
using HotelsBase.Views;
using HotelsBase.ViewModels;
using HotelsBase.Services;
using System.Collections.ObjectModel;

namespace HotelsBase.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {            
            InitializeComponent();            
            this.BindingContext = new HotelsListViewModel() { Navigation = this.Navigation };                    
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        //private void SortByCoast_Clicked(object sender, EventArgs e)
        //{
        //    var lis = new List<HotelViewModel>();
        //    lis = h.GetHotels();

        //    var _nameList = new ObservableCollection<HotelViewModel>(lis.OrderBy(x => x.));
        //    HotelsListView.ItemsSource = _nameList;
        //}
        async void Button_Clicked(object sender, EventArgs e)
        {
            //WorkWithHostels getHotel = new WorkWithHostels();

            //getHotel.Write_Hotels_In_File();           

            await Navigation.PushModalAsync(new SortPage());
        }


        //async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string monkeyName = (e.CurrentSelection.FirstOrDefault() as HotelViewModel).Name;
        //    // This works because route names are unique in this application.
        //    await Shell.Current.GoToAsync($"monkeydetails?name={monkeyName}");
        //    // The full route is shown below.
        //    // await Shell.Current.GoToAsync($"//animals/monkeys/monkeydetails?name={monkeyName}");
        //}
    }
}