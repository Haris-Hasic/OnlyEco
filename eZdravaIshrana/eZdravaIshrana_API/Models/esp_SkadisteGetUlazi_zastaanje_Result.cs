//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eZdravaIshrana_API.Models
{
    using System;
    
    public partial class esp_SkadisteGetUlazi_zastaanje_Result
    {
        public int SkladisteID { get; set; }
        public int ProizvodID { get; set; }
        public string Skladiste { get; set; }
        public string Adresa { get; set; }
        public string Proizvod { get; set; }
        public string Vrsta { get; set; }
        public string Sorta { get; set; }
        public string Ime_proizvodjac { get; set; }
        public string Prezime_proizvodjaca { get; set; }
        public Nullable<int> Stanje { get; set; }
    }
}
