//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaChStorage.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderPart
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public string Note { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
