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
    using System.Collections.Generic;
    
    public partial class OcjeneDostavljaca
    {
        public int OcjenaDostavljacID { get; set; }
        public int DostavljacID { get; set; }
        public int KupacID { get; set; }
        public System.DateTime Datum { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
    
        public virtual Dostavljaci Dostavljaci { get; set; }
        public virtual Kupci Kupci { get; set; }
    }
}
