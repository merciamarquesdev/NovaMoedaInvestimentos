using NovaMoedaInvestimentos.Repositories.Interfaces;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Context;

namespace NovaMoedaInvestimentos.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;
        public TransactionRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Transaction> Transactions => _context.Transactions;
    }
}
