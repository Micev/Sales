//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoadDataToMySQL.SupermarketsChain.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public decimal Id { get; set; }
        public System.DateTime SoldOn { get; set; }
        public decimal SupermarketId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Quantity { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Supermarket Supermarket { get; set; }
    }
}
