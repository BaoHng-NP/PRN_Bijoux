using Bijoux_Jewelry.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijoux_Jewelry.DataAccess.Repositories
{
    public class DiamondRepository
    {
        DiamondShopDbContext _context;
        public List<Diamond> GetAll()
        {
            _context = new();
            List<Diamond> list= _context.Diamonds
                .Include(d => d.DiamondClarity)
                .Include(d => d.DiamondColor)
                .Include(d => d.DiamondOrigin)
                .ToList();
            return list;
        }
        public void delete(Diamond diamond)
        {
            _context = new();
            _context.Diamonds.Remove(diamond);
            _context.SaveChanges();
        }

    }
}
