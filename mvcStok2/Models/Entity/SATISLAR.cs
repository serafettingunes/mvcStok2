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
    
    public partial class SATISLAR
    {
        public int SATISID { get; set; }
        public Nullable<int> MUSTERI { get; set; }
        public Nullable<int> URUN { get; set; }
        public string FIYAT { get; set; }
        public Nullable<decimal> ADET { get; set; }
    
        public virtual MUSTERILER MUSTERILER { get; set; }
        public virtual URUNLER URUNLER { get; set; }
    }
}
