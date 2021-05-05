using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Website.Models
{
    public class AdminContext:DbContext
    {
        public System.Data.Entity.DbSet<Website.Models.Admin> Admins { get; set; }
        public System.Data.Entity.DbSet<Website.Models.Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<Website.Models.Faculty> Faculties { get; set; }
    }
}