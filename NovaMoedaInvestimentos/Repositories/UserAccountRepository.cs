using Microsoft.EntityFrameworkCore;
using NovaMoedaInvestimentos.Context;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;

namespace NovaMoedaInvestimentos.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly AppDbContext _context;
        public UserAccountRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<UserAccount> UserAccounts => _context.UserAccounts.Include(t => t.Transactions);

        public UserAccount GetUserAccountById(int userAccountId)
        {
            return _context.UserAccounts.FirstOrDefault(u => u.UserAccountId == userAccountId);
        }
    }
}
