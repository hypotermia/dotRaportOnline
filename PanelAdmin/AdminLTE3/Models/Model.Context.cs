﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLTE3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineRaporEntities : DbContext
    {
        public OnlineRaporEntities()
            : base("name=OnlineRaporEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ALAMAT> ALAMAT { get; set; }
        public DbSet<ASPEK> ASPEK { get; set; }
        public DbSet<DEPARTEMEN> DEPARTEMEN { get; set; }
        public DbSet<DETAIL_ASPEK> DETAIL_ASPEK { get; set; }
        public DbSet<JABATAN> JABATAN { get; set; }
        public DbSet<KARYAWAN> KARYAWAN { get; set; }
        public DbSet<LOGIN> LOGIN { get; set; }
        public DbSet<RAPOR> RAPOR { get; set; }
        public DbSet<SUB_ASPEK> SUB_ASPEK { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<WILAYAH> WILAYAH { get; set; }
    }
}
