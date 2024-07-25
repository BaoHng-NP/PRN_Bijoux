using Bijoux_Jewelry.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijoux_Jewelry.DataAccess.Repositories
{
    public class AccountRepository
    {
        DiamondShopDbContext _context;
        public Account? getOne(String userName, String password ) {
            _context = new();
            return _context.Accounts.FirstOrDefault(x => x.Username.ToLower() == userName.ToLower() && x.Password == password);

        }

        public List<Account> GetAll()
        {
            _context = new();
            return _context.Accounts.ToList();
        }
    }
}
