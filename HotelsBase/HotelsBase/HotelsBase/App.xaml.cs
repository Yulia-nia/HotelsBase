using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HotelsBase.Services;
using HotelsBase.Views;
using HotelsBase.ViewModels;
using System.IO;

namespace HotelsBase
{
    public partial class App : Application
    {
        //public const string DATABASE_NAME = "Offers.db";
        //public static FriendRepository database;
        //public static FriendRepository Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new FriendRepository(DATABASE_NAME);
        //        }
        //        return database;
        //    }
        //}
        //public const string DATABASE_NAME = "Offers.db";
        //public static FriendAsyncRepository database;
        //public static FriendAsyncRepository Database
        //{
        //    get
        //    {
        //        if (database == null)
        //        {
        //            database = new FriendAsyncRepository(DATABASE_NAME);
        //        }
        //        return database;
        //    }
        //}


        static OfferDatabase database;
        public static string CurrentLanguage = "ru";
        public App()
        {
           
            InitializeComponent();

            //WorkWithHostels getHotel = new WorkWithHostels();

            //getHotel.Write_Hotels_In_File();


            //Resources = new ResourceDictionary();
            //Resources.Add("primaryGreen", Color.FromHex("91CA47"));
            //Resources.Add("primaryDarkGreen", Color.FromHex("6FA22E"));

            //var nav = new NavigationPage(new TodoListPage());
            //nav.BarBackgroundColor = (Color)App.Current.Resources["primaryGreen"];
            //nav.BarTextColor = Color.White;

            //MainPage = nav;

            //if (Device.OS != TargetPlatform.WinPhone)
            //{
            //    Resource.Culture = DependencyService.Get<ILocalize>()
            //                        .GetCurrentCultureInfo();
            //}


            DependencyService.Register<MockDataStore>();
                 
            MainPage = new NavigationPage(new SplashPage());
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("#FE6960"));


            //{
            //    BarBackgroundColor = Color.FromHex("#FE6960"),
            //    BarTextColor = Color.White,
            //};
        }

        public static OfferDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new OfferDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Offers.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
