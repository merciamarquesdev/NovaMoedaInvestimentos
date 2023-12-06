using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.ViewModels
{
    public class StockListViewModel
    {
        public IEnumerable<Stock> Stocks { get; set; }
        public string Category { get; set; }
    }
}
