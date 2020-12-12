using Microsoft.EntityFrameworkCore;
using PaymentControl.Data;
using PaymentControl.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentControl.Services
{
    public class DepartmentService
    {
        private readonly PaymentControlContext _context;

        public DepartmentService(PaymentControlContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department
                .OrderBy(x => x.Name)
                .ToListAsync();
        }
    }
}
