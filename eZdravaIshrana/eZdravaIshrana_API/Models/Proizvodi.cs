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
    
    public partial class Proizvodi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proizvodi()
        {
            this.NarudzbaStavke = new HashSet<NarudzbaStavke>();
            this.Ocjene = new HashSet<Ocjene>();
            this.UlazStavke = new HashSet<UlazStavke>();
            this.IzlazStavke = new HashSet<IzlazStavke>();
        }
    
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public int VrstaID { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool Status { get; set; }
        public int ProizvodjacID { get; set; }
        public Nullable<int> SortaID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        public virtual Proizvodjac Proizvodjac { get; set; }
        public virtual SortaProizvoda SortaProizvoda { get; set; }
        public virtual VrsteProizvoda VrsteProizvoda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UlazStavke> UlazStavke { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IzlazStavke> IzlazStavke { get; set; }
    }
}
