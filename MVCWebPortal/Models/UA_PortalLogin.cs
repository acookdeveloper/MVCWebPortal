//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class UA_PortalLogin
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public Nullable<System.Guid> Salt { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Nullable<int> AccessLevelID { get; set; }
        public Nullable<System.Guid> UserGUID { get; set; }
        public Nullable<System.Guid> PasswordToken { get; set; }
        public Nullable<System.DateTime> PasswordTokenDate { get; set; }
        public Nullable<int> CompanyID { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
