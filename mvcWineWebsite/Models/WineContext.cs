using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvcWineWebsite.Models
{
    public class WineContext : DbContext
    {
        public WineContext() : base("DefaultConnection")
        {
        }

        public DbSet<Wine> Wines { get; set; }
    }
}