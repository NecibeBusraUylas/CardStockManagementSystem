﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CardStockManagementSystemEntities1 : DbContext
    {
        public CardStockManagementSystemEntities1()
            : base("name=CardStockManagementSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BranchCardTransactions> BranchCardTransactions { get; set; }
        public virtual DbSet<BranchInfo> BranchInfo { get; set; }
        public virtual DbSet<CardType> CardType { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
    }
}
