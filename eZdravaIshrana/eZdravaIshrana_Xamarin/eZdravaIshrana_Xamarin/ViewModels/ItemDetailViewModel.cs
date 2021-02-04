using System;

using eZdravaIshrana_Xamarin.Models;

namespace eZdravaIshrana_Xamarin.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
