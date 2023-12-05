using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> Transactions { get; }
    }
}
