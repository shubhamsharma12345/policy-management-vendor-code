using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PolicyManagement.Models
{
    public class PolicyContext:DbContext
    {
        public DbSet<PolicyAdmin> PolicyAdmins { get; set; }
        public DbSet<PolicyVendor> PolicyVendors { get; set; }
        public DbSet<PolicyUser> PolicyUsers { get; set; }
    }
}