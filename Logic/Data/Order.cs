//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Logic.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int ToWareHouseID { get; set; }
        public int MaterialID { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual User User { get; set; }
        public virtual WareHouse WareHouse { get; set; }
        public virtual WareHouse WareHouse1 { get; set; }
    }
}
