using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace los_api.Models
{
    public class StockContext : DbContext
    {
        public StockContext(DbContextOptions<StockContext> options)
           : base(options)
        {
        }

        public DbSet<Stock> Stock { get; set; }
    }
}
