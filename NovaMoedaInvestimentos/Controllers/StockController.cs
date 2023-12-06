using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories;
using NovaMoedaInvestimentos.Repositories.Interfaces;
using NovaMoedaInvestimentos.ViewModels;

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

        public IActionResult Search(string searchString)
        {
            IEnumerable<Stock> stocks;
            string category = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                stocks = _stockRepository.Stocks.OrderBy(p => p.StockId);
                category = "Todas as Ações";
            }
            else
            {
                stocks = _stockRepository.Stocks
                          .Where(p => p.Name.ToLower().Contains(searchString.ToLower()));

                if (stocks.Any())
                    category = "Ações";
                else
                    category = "Nenhuma ação foi encontrada";
            }

            return View("~/Views/Stock/List.cshtml", new StockListViewModel
            {
                Stocks = stocks,
                Category = category
            });
        }
    }
}
