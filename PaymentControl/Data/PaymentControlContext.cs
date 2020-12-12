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

        public DbSet<PaymentControl.Models.Department> Department { get; set; }
    }
}
