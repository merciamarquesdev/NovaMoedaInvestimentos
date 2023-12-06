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
            ViewData["Titulo"] = "Ações";
            ViewData["Data"] = DateTime.Now;

            var stocks = _stockRepository.Stocks;
            var totalStocks = stocks.Count();

            ViewBag.Total = "Total de Ações: ";
            ViewBag.TotalStocks = totalStocks;

            return View(stocks);
        }

        public IActionResult Details(int stockId)
        {
            var stock = _stockRepository.Stocks.FirstOrDefault(s => s.StockId == stockId);
            return View(stock);
        }
    }
}
