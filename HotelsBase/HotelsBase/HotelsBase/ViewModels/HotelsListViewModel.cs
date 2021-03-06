using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using HotelsBase.Views;
using HotelsBase.Models;

using System.IO;
using static Android.InputMethodServices.InputMethodService;

namespace HotelsBase.ViewModels
{
    public class HotelsListViewModel 
    {
        public ObservableCollection<HotelViewModel> Hotels { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;

        public ICommand MoveToTopCommand { protected set; get; }
        public ICommand MoveToBottomCommand { protected set; get; }
        public ICommand RemoveCommand { protected set; get; }



        public ICommand CreateFriendCommand1 { protected set; get; }
        public ICommand DeleteFriendCommand1 { protected set; get; }
        public ICommand SaveFriendCommand1 { protected set; get; }
        public ICommand BackCommand1 { protected set; get; }
        HotelViewModel selectedFriend;


       


        public INavigation Navigation { get; set; }
        public IList<HotelViewModel> Hotelss { get; private set; }

        public IList<HotelViewModel> Favorite_Hotels { get; private set; } //---favorite

        //public List<HotelViewModel> GetFavorite_Hotels()
        //{
        //    HotelDetailPage hdp = new HotelDetailPage();
        //    var lis = new List<HotelViewModel>();
        //    lis = hdp.GetHotels1();
        //    return lis;
        //}


        public List<HotelViewModel> GetHotels()
        {
            var lis = new List<HotelViewModel>();
            foreach (var item in Hotels)
            {
                lis.Add(item);
            }
            return lis;
        }

        public HotelsListViewModel()
        {
            //WorkWithHostels getHotel = new WorkWithHostels();

            //getHotel.Write_Hotels_In_File();

           
            Hotels = new ObservableCollection<HotelViewModel>
            {
                new HotelViewModel()
            {
                    Stars=9.1,

                    Id = Guid.NewGuid().ToString(),
                Name = "Double Tree by Hilton Hotel Minsk",
                NumberOfStars = 5,
                StrStars="⭐⭐⭐⭐⭐",
                NumberOfRooms = 193,
                Contacts = new Contact
                {
                    Address = "Пpоспект Победителей 9",
                    Email = "doubletreeminsk.info@hilton.com",
                    OfficialWebsite = "www.hilton.ru",
                    Telephone = "+375 17 309-80-00"
                },
                Foto = "doubletree.jpg",    //----
                Services = new Service
                {
                    Sport = "В распоряжении гостей современный круглосуточный фитнес-центр с тренажерами TechnoGym",

                    Bars =  "В лаундж-баре Sky Lounge BAR:DOT XX1 на 22 этаже есть широчайший выбор шампанского и фирменных коктейлей. Кроме того, в мерцающем интерьере лаундж-бара играет живая музыка, выступает диджей и проводятся зажигательные вечеринки. \n" +
                    "В ресторане Ember представлена обширная коллекция вин, а с террасы Ember 7th Heaven открывается потрясающий вид.\n" +
                    "Лобби-кафе Beans&Leaves с залитой солнцем террасой идеально подходит для деловых и дружеских встреч.",
                    ForChildren = "Развлекательный комплекс для детей",
                    AddServices = "Свадбы\n" +
                    "Мероприятия\n" +
                    "В отеле оборудован полноценный конференц-зал вместимостью до 350 человек, а также бесплатный круглосуточный бизнес-центр.",
                    Internet = "Бесплатный вай-фай",
                    Nutrition = "Бесплатные завтраки",
                    Coast = "Частный трансфер идет 45 минут от международного аэропорта Минска в гостиницу\n" +
                    "Центральный железнодорожный вокзал находится в 3,5 км. Расстояние до международного аэропорта Минска составляет 45 км."
                },
                Information = "Отель DoubleTree by Hilton Minsk расположен рядом с историческим центром Минска и в 5 минутах ходьбы от станции метро «Немига». Во всех помещениях подключен бесплатный Wi-Fi.\n\n" +
                "В числе удобств каждого номера — телевизор с плоским экраном и рабочий стол с эргономичным креслом. Из больших окон открывается живописный вид на город. В собственной ванной комнате с душем имеются бесплатные туалетно-косметические принадлежности.\n\n" +
                "Посетителей панорамного ресторана BarDotXX1, который находится на 21-м этаже, ожидает захватывающий вид на реку Свислочь и центр города. Гостям предложат блюда тайской и сингапурской кухни, коктейли, вина разных стран, шампанское, крепкие алкогольные напитки. Настоящие каменные печи, расположенные в ресторане и баре Ember, создают уютную атмосферу, в которой можно попробовать традиционную белорусскую и европейскую кухню. В отеле действует лобби-кафе Beans & Leaves с богатым выбором горячих напитков и закусок, в том числе и на вынос.\n\n" +
                "Гостям нового минского отеля доступен весь набор услуг и возможностей, которые предоставляет бренд DoubleTree by Hilton. В их числе – завтраки Wake Up DoubleTree, чай и кофе в номерах, натуральные средства по уходу за кожей Aroma Actives Essentials\n\n" +
                "Гости минского DoubleTree by Hilton, который является частью международной сети Hilton, могут участвовать в программе лояльности Hilton HHonors. Участники программы Hilton HHonors, которые бронируют отели напрямую через сайт Hilton, экономят время и деньги и получают следующие преимущества: эксклюзивную скидку более чем в 4 500 отелях по всему миру; возможность использовать бонусные баллы для оплаты номеров; электронную регистрацию с возможностью выбора номера; посещение эксклюзивных концертов и престижных мероприятий.",
                Reviews = new List<Review>
                {
                    new Review()
                    {
                        Foto = "doubletree.jpg",  //---стандартное 
                        Name = "Анатолий",
                        Stars = 5,
                        YourReview = "Великолепный отель. " +
                        "Роскошное местоположение. Прекрасные вкусные завтракию Приветливый, отзывчивый персонал."
                    }
                },
                Rooms = new List<Room>
                {
                     new Room()
                    {
                        Name ="Двухместный номер с 2 отдельными кроватями",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/195624342.jpg?k=cbe2b7bef820eb16380a2845973744315e38eee657cf5bc6812e9fa5190dfc83&o=",    //----
                        Information ="Двухместный номер с 2 отдельными кроватями и телевизором с плоским экраном.",
                        Coast =215,
                        Size="28 м²",
                       BathroomServices = new List<string>
                        { "• Душ","• Ванна","• Туалет"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                            "• Кофеварка/чайник","• Мини-бар","• Телефон","• Радио","• Гладильные принадлежности"," Сейф для ноутбука",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Вешалка для одежды"

                        }
                    },

                    new Room()
                    {
                        Name ="Номер с кроватью размера «king-size»",
                        Foto ="https://r-cf.bstatic.com/xdata/images/hotel/max1024x768/87106135.jpg?k=2f344f5a7c5fdf7fe2aacf04ec132d57355ea6fc6925e77819c183c94761082d&o=",  //---
                        Information ="Трехместный номер с мини-баром, кондиционером и принадлежностями для чая/кофе.",
                        Coast = 204,
                       Size="28 м²",
                       BathroomServices = new List<string>
                       { "• Фен", "• Туалет"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =3,
                        Services = new List<string>
                        {
                            "• Кофеварка/чайник","• Мини-бар","• Кондиционер","• Гладильные принадлежности","• Телевизор с плоским экраном","• Вешалка для одежды"
                        }
                    },
                    //---
                    new Room()
                    {
                        Name ="Номер с кроватью размера «king-size» и видом на реку",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/86619515.jpg?k=0f244381bb0de2472ed47ca08f57ef9b07d5857b2550f739d899139755aad203&o=",  //---
                        Information ="Трехместный номер с мини-баром, кондиционером и принадлежностями для чая/кофе.",
                        Coast = 220,
                       Size="28 м²",
                       BathroomServices = new List<string>
                       { "• Туалет"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                            "• Телефон","• Кондиционер","• Рабочий стол","• Услуга «звонок-будильник»","• Раскладная кровать",
                            "• Кофеварка/чайник","• Мини-бар","• Кондиционер","• Гладильные принадлежности","• Телевизор с плоским экраном","• Вешалка для одежды"
                        }
                    },
                    new Room()
                    {
                        Name ="Двухместный номер с 2 отдельными кроватями и террасой",
                        Foto ="https://r-cf.bstatic.com/xdata/images/hotel/max1024x768/141017662.jpg?k=6e22059ebca7e545796169f3e513d61f6c4b00d0fe4ec915971984247ae8d3c2&o=",     //-----
                        Information ="Двухместный номер с 2 отдельными кроватями и телевизором с плоским экраном.",
                        Coast =280,
                       Size="30 м²",
                       BathroomServices = new List<string>
                        { "• Туалет"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                            "• Телевизор с плоским экраном","• Терраса","• Вешалка для одежды"
                        }
                    },
                    new Room()
                    {
                        Name ="Люкс с кроватью размера «king-size»",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/93619007.jpg?k=695ff3159855e1b55a2a997ebffa977063ec7eff3027139b173afcd1205c890e&o=",    //----
                        Information ="1 очень большая двуспальная кровать и 1 диван-кровать. \n Люкс с диваном, гостиной зоной и кондиционером.",
                        Coast =350,
                        Size="68 м²",
                       BathroomServices = new List<string>
                        { "• Душ","• Ванна","• Туалет", "• Фен", "• Халат","• Тапочки"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =3,
                        Services = new List<string>
                        {
                           "• Кондиционер", "• Рабочий стол","• Сейф для ноутбука","• Диван","• Кофемашина",
                            "• Кофеварка/чайник","• Мини-бар","• Телефон","• Радио","• Гладильные принадлежности"," Сейф для ноутбука",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Вешалка для одежды"

                        }
                    }
                }
                },

                //StrStars="⭐⭐⭐⭐⭐",
                new HotelViewModel()
            {
                     Stars=8.4,
                Id = Guid.NewGuid().ToString(),
                Name = "Willing Hotel",
                NumberOfStars = 3,
                StrStars="⭐⭐⭐",
                NumberOfRooms = 98,
                Contacts = new Contact
                {
                    Address = "Ленина 50",
                    Email = "reservation@willinghotel.by",
                    OfficialWebsite = "willinghotel.by",
                    Telephone = "+375 29 336-90-16"
                },
                Foto = "https://q-cf.bstatic.com/images/hotel/max1024x768/121/121569611.jpg",
                Services = new Service
                {
                    Sport = "Прокат велосипедов \nСпа и оздоровительный центр\nФитнес-центр",
                    Bars = "Бар\nРесторан" ,
                    ForChildren = "Детские телеканалы\nАниматоры" ,
                    AddServices = "Бизнес центр с доступом в интернет\nКонференц залы",
                    Internet = "Бесплатный Wi-Fi",
                    Nutrition = "По утрам подают завтрак «шведский стол».",
                    Coast = "Трансфер от/до аэропорта"
                },
                Information = "Отель Willing расположен в Минске, в 18 минутах ходьбы от Белорусского национального художественного музея и 1,6 км Национального академического театра имени Янки Купалы. К услугам гостей номера с бесплатным Wi-Fi, кондиционером и собственной ванной комнатой. Этот 3-звездочный отель находится в Ленинском районе.\n\n" +
                "Все номера оснащены телевизором с плоским экраном. Среди удобств письменный стол.\n\n" +
                "Белорусский государственный цирк находится в 1,7 км от отеля Willing, а музей Великой Отечественной войны — в 1,9 км. До Национального аэропорта Минска — 30 км.\n\n" +
                "Ленинский район — отличный выбор, если вам интересны чистота, гостеприимные люди и еда.",
                Reviews = new List<Review>
                {
                    new Review()
                    {
                        Foto = "https://q-cf.bstatic.com/images/hotel/max1024x768/121/121569611.jpg",
                        Name = "Лиля",
                        Stars = 5,
                        YourReview = "Мне очень понравился отель, наш номер находился на 4 этажею Убора была каждый день, смена полотенец, шампуни и др средства гигиены менялись " +
                        "и дополнялись каждый день. Окна выходили на Ратушу. Понравилось, что отель находиться в центре города"
                    }
                },
                Rooms = new List<Room>
                {
                    new Room()
                    {
                        Name ="Одноместный номер",
                        Foto ="https://willinghotel.by/upload/iblock/85d/85dc5cf545fe5536072be85aff667ab5.jpg",
                        Information ="В этом одноместном номере есть кондиционер, мини-бар и электрический чайник.",
                        Coast =70,
                        Size="20 м²",
                       BathroomServices = new List<string>
                        { "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =1,
                        Services = new List<string>
                        {
                            "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                            "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                        }
                    },
                    new Room()
                    {
                        Name ="Двухместный номер с 1 кроватью",
                        Foto ="https://r-cf.bstatic.com/xdata/images/hotel/max1024x768/121569924.jpg?k=8f2072bc4703ae9105dfa61a278781d102b4c946943360547e73432b9a9b7d71&o=",
                        Information ="Двухместный номер с 1 кроватью, мини-баром, принадлежностями для чая/кофе и телевизором с кабельными каналами.",
                         Size="20 м²",
                          Coast =84,
                       BathroomServices = new List<string>
                        { "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца"
                       },
                       Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                           "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                            "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                        }
                    },

                     new Room()
                    {
                        Name ="Двухместный номер с 2 отдельными кроватями",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/132140225.jpg?k=2e3d8ad6b3b4da84d5172997932c8b55b7e57f0cf4f9224a18bec6d9ce4c2f4e&o=",
                        Information ="Двухместный номер с 2 отдельными кроватями, мини-баром, электрическим чайником и телевизором с плоским экраном.",
                         Coast =84,
                         Size ="21 м²",
                       BathroomServices = new List<string>
                        { "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца"
                       },
                        Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                           "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                            "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                        }
                    },


                     //---------------
                    new Room()
                    {
                        Name ="Номер-студио",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/132138531.jpg?k=935b0ed6edc28439202259fdd8f102643b28b2469aeabd728aaab0af03778e7d&o=",
                        Information ="Номер-студио с кондиционером, мини-баром и кабельным телевидением.",
                        Size ="30 м²",
                         Coast =180,
                        BathroomServices = new List<string>
                        {
                            "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца",
                            "• Халат","• Тапочки"
                        },
                        Smoke="запрещено",
                        NumbersOfBeds =2,
                        Services = new List<string>
                        {
                           "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                            "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                        }
                       },



                    new Room()
                    {
                        Name =" Апартаменты",
                        Foto ="https://q-cf.bstatic.com/xdata/images/hotel/max1024x768/164960369.jpg?k=25082ad322d05e27cf509dab8f80751181eee8a6aa99cec74ff7785115768ac3&o=",
                        Information ="Спальня 1: 1 большая двуспальная кровать\nГостиная: 1 диван-кровать ",
                        Size ="70 м²",
                         Coast =250,
                        BathroomServices = new List<string>
                        {
                            "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца","• Дополнительный туалет"
                        },
                        Smoke="запрещено",
                        NumbersOfBeds =4,
                        Services = new List<string>
                        {
                           "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                            "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                            "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                        }
                       }


                    //new Room()
                    //{
                    //    Name ="",
                    //    Foto ="",
                    //    Information ="",
                    //    Size ="20 м²",
                    //    BathroomServices = new List<string>
                    //    {
                    //        "• Фен","• Бесплатные туалетно-косметические принадлежности","• Ванна или душ","• Полотенца"
                    //    },
                    //    Smoke="запрещено",
                    //    NumbersOfBeds =2,
                    //    Services = new List<string>
                    //    {
                    //       "• Мини-бар","• Телефон","• Кондиционер","• Рабочий стол","• Отопление","• Кабельные каналы","• Ковровое покрытие",
                    //        "• Телевизор с плоским экраном","• Услуга «звонок-будильник»","• Электрический чайник","• Шкаф или гардероб",
                    //        "• Белье","• Лифт для доступа к верхним этажам","• Вешалка для одежды"
                    //    }
                    //   },


                }
                },

                //StrStars="⭐⭐⭐⭐⭐",
                new HotelViewModel()
            {
                     Stars=1.2,
                     StrStars="⭐⭐⭐⭐⭐",
                Id = Guid.NewGuid().ToString(),
                Name = "hotel3",
                NumberOfStars = 5,
                NumberOfRooms = 98,
                Contacts = new Contact
                {
                    Address = "Фолюш",
                    Email = "email",
                    OfficialWebsite = "www...by",
                    Telephone = "+37529"
                },
                Foto = "foto",
                Services = new Service
                {
                    Sport = "Фотнес центр с современным тренажерным залом, Бассейн, Джакузи, Крытый бассейн",
                    Bars = "Бар, Ресторан, Гостинная, Банкетный зал",
                    ForChildren = "Игровая площадка, Аниматоры",
                    AddServices = "Бизнес центр с доступом в интернет, Проведение свадеб, Конференц залы" ,
                    Internet = "Бесплатный интернет",
                    Nutrition = "Завтрак шведский стол",
                    Coast = "Частный трансфер доставит Вас от международного аэропорта Минска до гостиницы"
                },
                Information = "\n\n" +
                "\n\n" +
                "\n\n",
                Reviews = new List<Review>
                {
                    new Review()
                    {
                        Foto = "foto",
                        Name = "Лиля",
                        Stars = 5,
                        YourReview = "Мне очень понравился отель, наш номер находился на 4 этажею Убора была каждый день, смена полотенец, шампуни и др средства гигиены менялись " +
                        "и дополнялись каждый день. Окна выходили на Ратушу. Понравилось, что отель находиться в центре города"
                    }
                },
                Rooms = new List<Room>
                {
                    new Room()
                    {
                        Name ="RoomName",
                        Foto ="Room Foto",
                        Information ="RoomInfa",
                        Coast =268,
                        Size="",
                       BathroomServices = new List<string>
                        { "ff"
                       },
                       Smoke="",
                        NumbersOfBeds =3,
                        Services = new List<string>
                        {
                            "Телевизор",
                            "Интернет",
                            "Ванная комната",
                            "Дополнительная кровать",
                            "Кондиционер",
                            "Холодильник",
                            "Минибар"
                        }
                    },
                     new Room()
                    {
                        Name ="RoomName2",
                        Foto ="Room Foto",
                        Information ="RoomInfa",
                        Coast =268,
                         Size="",
                       BathroomServices = new List<string>
                        { "ff"
                       },
                       Smoke="",
                        NumbersOfBeds =3,
                        Services = new List<string>
                        {
                            "Телевизор",
                            "Интернет",
                            "Ванная комната",
                            "Кондиционер",
                            "Холодильник"
                        }
                    }
                } }
                //StrStars="⭐⭐⭐⭐⭐",
            };


            //Hotels = new ObservableCollection<HotelViewModel>();
            CreateFriendCommand1 = new Command(CreateFriend);
            DeleteFriendCommand1 = new Command(DeleteFriend);
            SaveFriendCommand1 = new Command(SaveFriend);
            BackCommand1 = new Command(Back);


            MoveToTopCommand = new Command(MoveToTop);
            MoveToBottomCommand = new Command(MoveToBottom);
            RemoveCommand = new Command(Remove);



            //Hotelss = new List<HotelViewModel>();
            //foreach(var item in Hotels)
            //{
            //    Hotelss.Add(item);
            //}
        }

        
        public HotelViewModel SelectedFriend
        {
            get { return selectedFriend; }
            set
            {
                if (selectedFriend != value)
                {
                    HotelViewModel tempFriend = value;
                    selectedFriend = null;
                    //OnPropertyChanged("SelectedFriend");
                    Navigation.PushModalAsync(new NavigationPage(new HotelPage(tempFriend)));  ////----------
                }
            }
        }


        //protected void OnPropertyChanged(string propName)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //}


        private void MoveToTop(object phoneObj)
        {
            HotelViewModel phone = phoneObj as HotelViewModel;
            if (phone == null) return;
            int oldIndex = Hotels.IndexOf(phone);
            if (oldIndex > 0)
                Hotels.Move(oldIndex, oldIndex - 1);
        }
        private void MoveToBottom(object phoneObj)
        {
            HotelViewModel phone = phoneObj as HotelViewModel;
            if (phone == null) return;
            int oldIndex = Hotels.IndexOf(phone);
            if (oldIndex < Hotels.Count - 1)
                Hotels.Move(oldIndex, oldIndex + 1);
        }
        private void Remove(object phoneObj)
        {
            HotelViewModel phone = phoneObj as HotelViewModel;
            if (phone == null) return;

            Hotels.Remove(phone);
        }


        private void CreateFriend()
        {
            Navigation.PushAsync(new HotelPage(new HotelViewModel() { ListViewModel = this })); ///------------ на ItemDetailPage поменять и сделать этот IDP Toolbar
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveFriend(object friendObject)
        {
            HotelViewModel friend = friendObject as HotelViewModel;
            if (friend.Reviews != null && friend.IsValid)
            {
                Hotels.Add(friend);
            }
            Back();
        }
        private void DeleteFriend(object friendObject)
        {
            HotelViewModel friend = friendObject as HotelViewModel;
            if (friend != null)
            {
                Hotels.Remove(friend);
            }
            Back();
        }


       


    }
}
