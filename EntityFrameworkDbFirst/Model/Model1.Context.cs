﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDbFirst.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MYDATABASEEntities : DbContext
    {
        public MYDATABASEEntities()
            : base("name=MYDATABASEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<COUNTRY> COUNTRies { get; set; }
        public virtual DbSet<COURSE> COURSEs { get; set; }
        public virtual DbSet<ENROLLMENT> ENROLLMENTs { get; set; }
        public virtual DbSet<FOOTBALLCLUB> FOOTBALLCLUBs { get; set; }
        public virtual DbSet<PHONE> PHONEs { get; set; }
        public virtual DbSet<SIMCARD> SIMCARDs { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
    }
}