using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Repositories.Interfaces;

namespace NovaMoedaInvestimentos.Controllers
{
    public class StockController : Controller
    {
        private readonly IStockRepository _stockRepository;

        public StockController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }
        public IActionResult List()
        {
            var stocks = _stockRepository.Stocks;
            return View(stocks);
        }
    }
}
