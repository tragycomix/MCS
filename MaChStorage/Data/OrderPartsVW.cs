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
    
    public partial class OrderPartsVW
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double OrderedQuantity { get; set; }
        public Nullable<double> StoredQuantity { get; set; }
        public string Note { get; set; }
        public string Placement { get; set; }
    }
}
