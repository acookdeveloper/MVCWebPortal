using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWebPortal.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet<UA_PortalLogin> User { get; set; }
    }
}