﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace veryVerySad
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MycafeDBEntities : DbContext
    {
        public MycafeDBEntities()
            : base("name=MycafeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConfirmOrder_> ConfirmOrder_ { get; set; }
        public virtual DbSet<Employee_> Employee_ { get; set; }
        public virtual DbSet<EmpPosition_> EmpPosition_ { get; set; }
        public virtual DbSet<Expenses_> Expenses_ { get; set; }
        public virtual DbSet<Material_> Material_ { get; set; }
        public virtual DbSet<Menu_> Menu_ { get; set; }
        public virtual DbSet<Order_> Order_ { get; set; }
        public virtual DbSet<Payment_> Payment_ { get; set; }
        public virtual DbSet<PurchaseOrder_> PurchaseOrder_ { get; set; }
        public virtual DbSet<Quotation_> Quotation_ { get; set; }
        public virtual DbSet<Receipt_> Receipt_ { get; set; }
        public virtual DbSet<ReceiptOrder_> ReceiptOrder_ { get; set; }
        public virtual DbSet<Revenue_> Revenue_ { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeMenu_> TypeMenu_ { get; set; }
    }
}
