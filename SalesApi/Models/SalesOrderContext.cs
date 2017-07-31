using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SalesApi.Models
{
    public class SalesOrderContext:DbContext,ISalesOrderContext
    {
        public SalesOrderContext():base("DefaultConnection")
        {

        }
        public DbSet<SoHead> SoHeads { get; set; }
        public DbSet<SoItem> SoItem { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}