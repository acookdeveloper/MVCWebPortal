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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual int sp_UA_CreateAccount(string email, string passwordA, string passwordB, Nullable<int> companyID)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordAParameter = passwordA != null ?
                new ObjectParameter("PasswordA", passwordA) :
                new ObjectParameter("PasswordA", typeof(string));
    
            var passwordBParameter = passwordB != null ?
                new ObjectParameter("PasswordB", passwordB) :
                new ObjectParameter("PasswordB", typeof(string));
    
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UA_CreateAccount", emailParameter, passwordAParameter, passwordBParameter, companyIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_UA_Login(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_UA_Login", emailParameter, passwordParameter);
        }
    
        public virtual int sp_UA_SetPassword(Nullable<int> userID, string passwordA, string passwordB)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var passwordAParameter = passwordA != null ?
                new ObjectParameter("PasswordA", passwordA) :
                new ObjectParameter("PasswordA", typeof(string));
    
            var passwordBParameter = passwordB != null ?
                new ObjectParameter("PasswordB", passwordB) :
                new ObjectParameter("PasswordB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UA_SetPassword", userIDParameter, passwordAParameter, passwordBParameter);
        }
    }
}
