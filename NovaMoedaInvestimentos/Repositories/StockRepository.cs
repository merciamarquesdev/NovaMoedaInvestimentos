using NovaMoedaInvestimentos.Context;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;

namespace NovaMoedaInvestimentos.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly AppDbContext _context;
        public StockRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Stock> Stocks => _context.Stocks;

        public IEnumerable<Stock> FavoriteStocks => _context.Stocks.
                                   Where(l => l.IsFavoriteStock);


        public Stock GetStockById(int stockId)
        {
            return _context.Stocks.FirstOrDefault(s => s.StockId == stockId);
        }

        public void UpdateStock(Stock stock)
        {
            var exisitingStock = _context.Stocks.Find(stock.StockId);
            if(exisitingStock != null)
            {
                exisitingStock.CurrentPrice = stock.CurrentPrice;
                _context.SaveChanges();
            }
        }
    }
}
