using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsBase.Models
{
    public class Room : IHotel
    {
        public decimal Coast { get; set; } //++++

        public int NumbersOfBeds { get; set; } 

        //public string IsBabyBed { get; set; } //+
        //public string IsLuxury { get; set; }//+

        public string Size { get; set; }  //++++



        public List<string> BathroomServices { get; set; }//++++
        public string Smoke { get; set; }  //++++

        public string Name { get; set; }  //++++
        public string Foto { get; set; }  //++++
        public List<string> Services { get; set; } //++++
        public string Information { get; set; }     //++++   
    }
}
