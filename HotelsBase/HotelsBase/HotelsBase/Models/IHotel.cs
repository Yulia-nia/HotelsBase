using System;
using System.Collections.Generic;
using System.Text;

namespace HotelsBase.Models
{
    interface IHotel
    {
        string Name { get; set; } //можно закинуть в интерфейс
        string Foto { get; set; } //можно закинуть в интерфейс
        // Services { get; set; } //можно закинуть в интерфейс
        string Information { get; set; }  //можно закинуть в интерфейс
    }
}
