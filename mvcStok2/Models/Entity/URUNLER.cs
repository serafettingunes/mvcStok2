//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcStok2.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class URUNLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public URUNLER()
        {
            this.SATISLAR = new HashSet<SATISLAR>();
        }
    
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string MARKA { get; set; }
        public Nullable<decimal> FIYAT { get; set; }
        public Nullable<int> KATEGORI { get; set; }
        public Nullable<int> STOK { get; set; }
    
        public virtual KATEGORILER KATEGORILER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SATISLAR> SATISLAR { get; set; }
    }
}
