//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITMO_CSharp_DesktopApps_FinalProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ApressFinancialEntities : DbContext
    {
        public ApressFinancialEntities()
            : base("name=ApressFinancialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomersProducts> CustomersProducts { get; set; }
        public virtual DbSet<Shares> Shares { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<FinancialProducts> FinancialProducts { get; set; }
        public virtual DbSet<SharePrices> SharePrices { get; set; }
    }
}
