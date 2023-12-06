using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Stock> FavoriteStocks { get; set; }
    }
}
