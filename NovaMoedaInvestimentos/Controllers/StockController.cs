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
    }
}
