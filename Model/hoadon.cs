//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadon()
        {
            this.cthoadons = new HashSet<cthoadon>();
        }
    
        public string mahd { get; set; }
        public string manv { get; set; }
        public string makh { get; set; }
        public Nullable<System.DateTime> ngaylap { get; set; }
        public Nullable<int> tthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cthoadon> cthoadons { private get; set; }
        public virtual khachhang khachhang { private get; set; }
        public virtual nhanvien nhanvien { private get; set; }
    }
}
