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
    
    public partial class Oda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oda()
        {
            this.Ogrencilers = new HashSet<Ogrenciler>();
        }
    
        public int Oda_ID { get; set; }
        public Nullable<int> Kat { get; set; }
        public Nullable<int> Oda_No { get; set; }
        public Nullable<int> Kontenjan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<Ogrenciler> Ogrencilers { get; set; }
    }
}
