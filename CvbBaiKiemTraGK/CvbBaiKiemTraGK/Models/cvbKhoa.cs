//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvbBaiKiemTraGK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cvbKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cvbKhoa()
        {
            this.cvbSinhVien = new HashSet<cvbSinhVien>();
        }
    
        public string CvbMaKH { get; set; }
        public string CvbTenKH { get; set; }
        public Nullable<bool> CvbTrangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cvbSinhVien> cvbSinhVien { get; set; }
    }
}
