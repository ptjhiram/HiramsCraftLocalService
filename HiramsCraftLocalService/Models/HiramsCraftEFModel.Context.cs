﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiramsCraftLocalService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HiramGroupLocalDB : DbContext
    {
        public HiramGroupLocalDB()
            : base("name=HiramGroupLocalDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<HiramsCraftPO> HiramsCraftPOes { get; set; }
        public virtual DbSet<HiramsCraftProduct> HiramsCraftProducts { get; set; }
        public virtual DbSet<MaterialProvider> MaterialProviders { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
    }
}
