//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardStockManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class BranchCardTransactions
    {
        public int Id { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> CardType { get; set; }
        public string Number { get; set; }
    
        public virtual BranchInfo BranchInfo { get; set; }
        public virtual CardType CardType1 { get; set; }
    }
}