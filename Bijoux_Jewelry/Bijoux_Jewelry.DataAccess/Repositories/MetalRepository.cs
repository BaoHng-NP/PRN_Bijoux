using Bijoux_Jewelry.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijoux_Jewelry.DataAccess.Repositories
{
    public class MetalRepository
    {
        DiamondShopDbContext _context;

        public List<Metal> GetAll()
        {
            _context = new();
            return _context.Metals.ToList();
        }
        public void Add(Metal metal)
        {
            _context = new();
            _context.Metals.Add(metal);
            _context.SaveChanges();
        }
    }
}
