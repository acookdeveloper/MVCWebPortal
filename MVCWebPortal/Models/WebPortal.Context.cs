﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCWebPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DevPortalEntities : DbContext
    {
        public DevPortalEntities()
            : base("name=DevPortalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<UA_PortalLogin> UA_PortalLogin { get; set; }
        public virtual DbSet<Assessment_Questions> Assessment_Questions { get; set; }
        public virtual DbSet<Assessment_QuestionSets> Assessment_QuestionSets { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<MenuAccessLevel> MenuAccessLevels { get; set; }
    }
}