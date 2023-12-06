using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;
using NovaMoedaInvestimentos.ViewModels;
using System.Diagnostics;

namespace NovaMoedaInvestimentos.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStockRepository _stockRepository;

        public HomeController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                FavoriteStocks = _stockRepository.FavoriteStocks
            };

            return View(homeViewModel);
        }

        public IActionResult Demo()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}