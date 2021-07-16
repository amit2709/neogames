using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Neogames.Models
{
    public class PurchaseContext : DbContext
    {
      public PurchaseContext(DbContextOptions<PurchaseContext> options)
    : base(options)
        {
        }

        public DbSet<Purchase> Purchases { get; set; }
    }
}
