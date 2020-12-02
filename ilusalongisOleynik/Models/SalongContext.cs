using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ilusalongisOleynik.Models
{
    public class SalongContext : DbContext
    {
        public SalongContext()
        : base("SalongEntities")
        {

        }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Service> Services { get; set; }
    }

}