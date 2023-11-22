﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirstLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SomeBankEntities : DbContext
    {
        public SomeBankEntities()
            : base("name=SomeBankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustTransaction> CustTransactions { get; set; }
        public virtual DbSet<TransferMoney> TransferMoneys { get; set; }
    
        [DbFunction("SomeBankEntities", "fn_ShowTransactionHistory")]
        public virtual IQueryable<fn_ShowTransactionHistory_Result> fn_ShowTransactionHistory(Nullable<int> p_custid)
        {
            var p_custidParameter = p_custid.HasValue ?
                new ObjectParameter("p_custid", p_custid) :
                new ObjectParameter("p_custid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_ShowTransactionHistory_Result>("[SomeBankEntities].[fn_ShowTransactionHistory](@p_custid)", p_custidParameter);
        }
    }
}
