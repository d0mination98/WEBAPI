using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Threading;

namespace SalesApi.Models
{
    public interface ISalesOrderContext: IDisposable
    {
         DbSet<SoHead> SoHeads { get; set; }
         DbSet<SoItem> SoItem { get; set; }
         DbSet<Customer> Customers { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}