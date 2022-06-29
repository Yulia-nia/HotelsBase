using Android.Content.Res;
using HotelsBase.Models;
using HotelsBase.ViewModels;
using HotelsBase.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HotelsBase.Services
{
    public class HotelSearchHandler : SearchHandler
    {       
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            HotelsListViewModel h = new HotelsListViewModel();

            var lis = new List<HotelViewModel>();
            lis = h.GetHotels();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = lis.Where(monkey => monkey.Name.ToLower().Contains(newValue.ToLower()))
                    .ToList<HotelViewModel>();
            }
        }
        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);
            var pet = item as HotelViewModel;
            if (pet is null) return;
            await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new HotelPage(pet)));
        }
    }
}
