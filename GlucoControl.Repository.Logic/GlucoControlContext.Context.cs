﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlucoControl.Repository.Logic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GlucoControlEntities : DbContext
    {
        public GlucoControlEntities()
            : base("name=GlucoControlEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<Insulin> Insulin { get; set; }
        public virtual DbSet<InsulinType> InsulinType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
