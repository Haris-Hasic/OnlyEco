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
    
    public partial class esp_Dobavljaci_Pretraga_Result
    {
        public int DobavljacID { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string ZiroRacuni { get; set; }
        public Nullable<int> BrojNabavki { get; set; }
        public Nullable<decimal> UkupnaPotrosnja { get; set; }
    }
}
