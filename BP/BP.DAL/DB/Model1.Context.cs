﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP.DAL.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BPEntities : DbContext
    {
        public BPEntities()
            : base("name=BPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyCargo> CompanyCargo { get; set; }
        public virtual DbSet<CompanyUser> CompanyUser { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Quarter> Quarter { get; set; }
        public virtual DbSet<Receiver> Receiver { get; set; }
        public virtual DbSet<ReceiverAdress> ReceiverAdress { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TaxAdministraition> TaxAdministraition { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<ShippingLog> ShippingLog { get; set; }
    }
}
