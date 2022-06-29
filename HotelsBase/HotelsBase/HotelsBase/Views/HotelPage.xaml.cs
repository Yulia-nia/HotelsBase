using HotelsBase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HotelsBase.Models;
using System.Collections.ObjectModel;

using System.ComponentModel;
namespace HotelsBase.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]   
    [DesignTimeVisible(false)]
    public partial class HotelPage : TabbedPage
    {
        public HotelViewModel ViewModel { get; private set; } 
        
        public HotelPage(HotelViewModel viewModel)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();           
            BindingContext =this.ViewModel = viewModel;
        }
    }
}