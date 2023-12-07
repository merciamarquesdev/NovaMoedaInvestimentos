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
        public IActionResult List(string category)
        {
            ViewData["Titulo"] = "Ações";
            ViewData["Data"] = DateTime.Now;

            IEnumerable<Stock> stocks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                stocks = _stockRepository.Stocks.OrderBy(s => s.StockId);
                currentCategory = "Todas as Ações";
            }
            else
            {
                if (string.Equals("Financeiro", category, StringComparison.OrdinalIgnoreCase))
                {
                    stocks = _stockRepository.Stocks
                        .Where(l => l.Category.Name.Equals("Financeiro"))
                        .OrderBy(l => l.Name);
                }
                else if (string.Equals("Petróleo e Gás", category, StringComparison.OrdinalIgnoreCase))
                {
                    stocks = _stockRepository.Stocks
                       .Where(l => l.Category.Name.Equals("Petróleo e Gás"))
                       .OrderBy(l => l.Name);
                }
                else if (string.Equals("Saúde", category, StringComparison.OrdinalIgnoreCase))
                {
                    stocks = _stockRepository.Stocks
                       .Where(l => l.Category.Name.Equals("Saúde"))
                       .OrderBy(l => l.Name);
                }
                else if (string.Equals("Serviços", category, StringComparison.OrdinalIgnoreCase))
                {
                    stocks = _stockRepository.Stocks
                       .Where(l => l.Category.Name.Equals("Serviços"))
                       .OrderBy(l => l.Name);
                }
                else
                {
                    stocks = _stockRepository.Stocks
                       .Where(l => l.Category.Name.Equals("Tecnologia da Informação"))
                       .OrderBy(l => l.Name);
                }
                currentCategory = category;
            }

            var stocksListViewModel = new StockListViewModel
            {
                Stocks = stocks,
                CurrentCategory = currentCategory
            };

            return View(stocksListViewModel);
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
                          .Where(p => ((p.Name.ToLower().Contains(searchString.ToLower())) | (p.Symbol.ToLower().Contains(searchString.ToLower()))));

                if (stocks.Any())
                    category = "Ações";
                else
                    category = "Nenhuma ação com esse nome foi encontrada.";
            }

            return View("~/Views/Stock/List.cshtml", new StockListViewModel
            {
                Stocks = stocks,
                CurrentCategory = category
            });
        }
    }
}
