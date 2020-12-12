using PaymentControl.Data;
using PaymentControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentControl.Services
{
    public class SellerService
    {
        private readonly PaymentControlContext _context;

        public SellerService(PaymentControlContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
    }
}
