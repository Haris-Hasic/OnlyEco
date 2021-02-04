using System;
using System.Collections.Generic;
using System.Text;

namespace eZdravaIshrana_Mob.Models
{
    public enum MenuItemType
    {
        Proizvodi,
        About,
        Aktivne,
        Historija,
        Zakljucene,
        AktivneDostave,
        MojProfil
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
