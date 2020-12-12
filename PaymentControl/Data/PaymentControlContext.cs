using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaymentControl.Models;

namespace PaymentControl.Data
{
    public class PaymentControlContext : DbContext
    {
        public PaymentControlContext (DbContextOptions<PaymentControlContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
