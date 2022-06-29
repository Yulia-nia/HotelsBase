using HotelsBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SortPage : ContentPage
    {
        HotelsListViewModel h = new HotelsListViewModel();
        public SortPage()
        {
            InitializeComponent();
            BindingContext = new HotelsListViewModel() { Navigation = this.Navigation };
        }
        private void SortByNumberOfStars_Clicked(object sender, EventArgs e)
        {
            var lis = new List<HotelViewModel>();
            lis = h.GetHotels();
            var _nameList = new ObservableCollection<HotelViewModel>(lis.OrderByDescending(x => x.NumberOfStars));
            HotelsListView.ItemsSource = _nameList;
        }

        private void SortByNumberOfRooms_Clicked(object sender, EventArgs e)
        {
            var lis = new List<HotelViewModel>();
            lis = h.GetHotels();
            var _nameList = new ObservableCollection<HotelViewModel>(lis.OrderByDescending(x => x.NumberOfRooms));
            HotelsListView.ItemsSource = _nameList;
        }

        private void StartSortByPopular_Clicked(object sender, EventArgs e) //сначала популярные
        {
            var lis = new List<HotelViewModel>();
            lis = h.GetHotels();
            var _nameList = new ObservableCollection<HotelViewModel>(lis.OrderByDescending(x => x.Stars));
            HotelsListView.ItemsSource = _nameList;
        }

        private void EndSortByPopular_Clicked(object sender, EventArgs e) //сначала непопулярные 
        {
            var lis = new List<HotelViewModel>();
            lis = h.GetHotels();
            var _nameList = new ObservableCollection<HotelViewModel>(lis.OrderBy(x => x.Stars));
            HotelsListView.ItemsSource = _nameList;
        }

    }
}