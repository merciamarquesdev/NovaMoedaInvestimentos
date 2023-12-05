using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.Repositories.Interfaces
{
    public interface IStockRepository
    {
        IEnumerable<Stock> Stocks { get; }
        Stock GetStockById(int stockId);
        void UpdateStock(Stock stock);
    }
}
