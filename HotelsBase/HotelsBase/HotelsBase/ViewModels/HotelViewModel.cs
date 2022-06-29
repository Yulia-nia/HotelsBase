using HotelsBase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HotelsBase.ViewModels
{
    public class HotelViewModel : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        HotelsListViewModel lvm;
        
        public Hotel Hotel { get; set; }
        


        //public Hotel Hotel { get; private set; }

        public HotelViewModel(Hotel item = null)
        {
            Hotel = new Hotel();
        }

        //public HotelsListViewModel ListViewModel { get; set; }
        public HotelsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }
        public string Name
        {
            get { return Hotel.Name; }
            set
            {
                if (Hotel.Name != value)
                {
                    Hotel.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public string StrStars
        {
            get { return Hotel.StrStars; }
            set
            {
                if (Hotel.StrStars != value)
                {
                    Hotel.StrStars = value;
                    OnPropertyChanged("StrStars");
                }
            }
        }
        public string Foto
        {
            get { return Hotel.Foto; }
            set
            {
                if (Hotel.Foto != value)
                {
                    Hotel.Foto = value;
                    OnPropertyChanged("Foto");
                }
            }
        }

        public double Stars
        {
            get { return Hotel.Stars; }
            set
            {
                if (Hotel.Stars != value)
                {
                    Hotel.Stars = value;
                    OnPropertyChanged("Stars");
                }
            }
        }

        public string Information
        {
            get { return Hotel.Information; }
            set
            {
                if (Hotel.Information != value)
                {
                    Hotel.Information = value;
                    OnPropertyChanged("Information");
                }
            }
        }
        public int NumberOfRooms
        {
            get { return Hotel.NumberOfRooms; }
            set
            {
                if (Hotel.NumberOfRooms != value)
                {
                    Hotel.NumberOfRooms = value;
                    OnPropertyChanged("NumberOfRooms");
                }
            }
        }

        public int NumberOfStars
        {
            get { return Hotel.NumberOfStars; }
            set
            {
                if (Hotel.NumberOfStars != value)
                {
                    Hotel.NumberOfStars = value;
                    OnPropertyChanged("NumberOfStars");
                }
            }
        }
        //---------- Services
        public string Internet
        {
            get { return Hotel.Services.Internet; }
            set
            {
                if (Hotel.Services.Internet != value)
                {
                    Hotel.Services.Internet = value;
                    OnPropertyChanged("Internet");
                }
            }
        }
        public string Transfer
        {
            get { return Hotel.Services.Coast; }
            set
            {
                if (Hotel.Services.Coast != value)
                {
                    Hotel.Services.Coast = value;
                    OnPropertyChanged("Transfer");
                }
            }
        }
        public string Nutrition
        {
            get { return Hotel.Services.Nutrition; }
            set
            {
                if (Hotel.Services.Nutrition != value)
                {
                    Hotel.Services.Nutrition = value;
                    OnPropertyChanged("Nutrition");
                }
            }
        }
        public string ForChildren
        {
            get { return Hotel.Services.ForChildren; }
            set
            {
                if (Hotel.Services.ForChildren != value)
                {
                    Hotel.Services.ForChildren = value;
                    OnPropertyChanged("ForChildren");
                }
            }
        }

        public string Sport
        {
            get { return Hotel.Services.Sport; }
            set
            {
                if (Hotel.Services.Sport != value)
                {
                    Hotel.Services.Sport = value;
                    OnPropertyChanged("Sport");
                }
            }
        }
        public string Bars
        {
            get { return Hotel.Services.Bars; }
            set
            {
                if (Hotel.Services.Bars != value)
                {
                    Hotel.Services.Bars = value;
                    OnPropertyChanged("Bars");
                }
            }
        }
        public string AddServices
        {
            get { return Hotel.Services.AddServices; }
            set
            {
                if (Hotel.Services.AddServices != value)
                {
                    Hotel.Services.AddServices = value;
                    OnPropertyChanged("AddServices");
                }
            }
        }

        //--------------List<Room> Rooms
        public List<Room> Rooms
        {
            get { return Hotel.Rooms; }
            set
            {
                if (Hotel.Rooms != value)
                {
                    Hotel.Rooms = value;
                    OnPropertyChanged("Rooms");
                }
            }
        }

        public List<Review> Reviews
        {
            get { return Hotel.Reviews; }
            set
            {
                if (Hotel.Reviews != value)
                {
                    Hotel.Reviews = value;
                    OnPropertyChanged("Reviews");
                }
            }
        }

        public string Email
        {
            get { return Hotel.Contacts.Email; }
            set
            {
                if (Hotel.Contacts.Email != value)
                {
                    Hotel.Contacts.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string Telephone
        {
            get { return Hotel.Contacts.Telephone; }
            set
            {
                if (Hotel.Contacts.Telephone != value)
                {
                    Hotel.Contacts.Telephone = value;
                    OnPropertyChanged("Telephone");
                }
            }
        }
        public string Address
        {
            get { return Hotel.Contacts.Address; }
            set
            {
                if (Hotel.Contacts.Address != value)
                {
                    Hotel.Contacts.Address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        public string OfficialWebsite
        {
            get { return Hotel.Contacts.OfficialWebsite; }
            set
            {
                if (Hotel.Contacts.OfficialWebsite != value)
                {
                    Hotel.Contacts.OfficialWebsite = value;
                    OnPropertyChanged("OfficialWebsite");
                }
            }
        }
      

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                    (!string.IsNullOrEmpty(Telephone.Trim())) ||
                    (!string.IsNullOrEmpty(Email.Trim())));
            }
        }

        public string Id { get; internal set; }
        public Contact Contacts { get; internal set; }
        public Service Services { get; internal set; }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

}

