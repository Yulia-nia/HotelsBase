using System;

using HotelsBase.Models;

namespace HotelsBase.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Hotel Item { get; set; }
        public ItemDetailViewModel(Hotel item = null)
        {
            Title = item?.Name;
            Item = item;
        }
    }
}
