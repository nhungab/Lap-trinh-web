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
    
    public partial class Tb_OderDetail
    {
        public int id { get; set; }
        public Nullable<int> OderID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<double> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Tb_Product Tb_Product { get; set; }
        public virtual Tb_Order Tb_Order { get; set; }
    }
}
