//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fashion.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BoSuuTap
    {
        public BoSuuTap()
        {
            this.SanPham = new HashSet<SanPham>();
        }
    
        public int MaBST { get; set; }
        public string TenBST { get; set; }
    
        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}