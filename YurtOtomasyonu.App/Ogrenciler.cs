//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YurtOtomasyonu.App
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogrenciler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ogrenciler()
        {
            this.Odas = new HashSet<Oda>();
        }
    
        public int ogrenciId { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string tc { get; set; }
        public string anneAd { get; set; }
        public string anneSoyad { get; set; }
        public string babaAd { get; set; }
        public string babaSoyad { get; set; }
        public Nullable<int> okulId { get; set; }
        public Nullable<int> iletisimId { get; set; }
    
        public  Okul Okul { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Oda> Odas { get; set; }
    }
}
