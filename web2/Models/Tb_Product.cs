//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tb_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Product()
        {
            this.Tb_OderDetail = new HashSet<Tb_OderDetail>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> ProductDate { get; set; }
        public Nullable<bool> Available { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
    
        public virtual Tb_Category Tb_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_OderDetail> Tb_OderDetail { get; set; }
    }
}