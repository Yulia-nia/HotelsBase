using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HotelsBase.Models
{
    //[Table("Offers")]
    public class Offers
    {
        //Фото

        //поделиться с помощью (?)
        //геолокация (кнопка) или карта)

        //боьшими буквами по центру адрес
        //сбоку комната/квартира  (через выпадающий список)
        //цена 
        //$130 (267)  - конвертируем с долларом (найти в метаните (получение данных с сервера и умножать))

        //кнопка с номером телефона
        //под ним по центру ФИО

        //описание

        //большая кнопка на всю строку (изменить)


        [PrimaryKey, AutoIncrement]
        //[PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string FIO { get; set; }   //+                       // имя фамилия человечка 
        public string Number { get; set; }   //+                      // Лена Полено (+375 29 562 23 12)
        public string Street { get; set; }
            
            
            //+       }             // Минск, ул. Козлова 3
                           
        public string LeaseTtype { get; set; } //+
        // Цена: 80$
        public string Foto { get; set; }        //+                 // Фото
        public string Information { get; set; } //+

        public int Coast { get; set; }   //+
    }
}
