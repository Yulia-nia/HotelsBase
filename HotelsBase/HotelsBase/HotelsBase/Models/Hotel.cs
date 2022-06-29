using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HotelsBase.Models
{   
        public class Hotel : IHotel, INotifyPropertyChanged
        {        
            public string Id { get; set; }
            public string Name { get; set; } //+   можно закинуть в интерфейс  //+
            public string Foto { get; set; } //+  можно закинуть в интерфейс
            public string Information { get; set; } // +   можно закинуть в интерфейс
                                                    //public List<string> Services { get; set; } //можно закинуть в интерфейс

            public string StrStars { get; set; }
            public double Stars { get; set; } 
           public int NumberOfRooms { get; set; } //+
            public int NumberOfStars { get; set; } //+
            public List<Room> Rooms { get; set; }
            public List<Review> Reviews { get; set; }
            public Contact Contacts { get; set; }   //+
            public Service Services { get; set; } //+
            public event PropertyChangedEventHandler PropertyChanged;
       
            private void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
            }

        public static implicit operator Hotel(Review v)
        {
            throw new NotImplementedException();
        }
    }
}

