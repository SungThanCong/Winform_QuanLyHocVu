//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom1_QuanLyHocVu.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHOAHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOAHOC()
        {
            this.KHOAHOCMONs = new HashSet<KHOAHOCMON>();
        }
    
        public string MaKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public Nullable<int> NamBatDau { get; set; }
        public Nullable<int> NamKetThuc { get; set; }
        public string MaChuongTrinh { get; set; }
    
        public virtual CHUONGTRINH CHUONGTRINH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAHOCMON> KHOAHOCMONs { get; set; }
    }
}
