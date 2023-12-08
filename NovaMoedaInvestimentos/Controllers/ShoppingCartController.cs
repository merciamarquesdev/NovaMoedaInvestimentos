using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;
using NovaMoedaInvestimentos.ViewModels;

namespace NovaMoedaInvestimentos.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IStockRepository _stockRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IStockRepository stockRepository, ShoppingCart shoppingCart)
        {
            _stockRepository = stockRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartAmount = _shoppingCart.GetShoppingCartAmount()
            };

            return View(shoppingCartVM);
        }

        [Authorize]
        public IActionResult AddItemToShoppingCart(int stockId)
        {
            var selectedStock = _stockRepository.Stocks.FirstOrDefault(p => p.StockId == stockId);
            if (selectedStock != null)
            {
                _shoppingCart.AddToShoppingCart(selectedStock);                 
            }
            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoveItemFromShoppingCart(int stockId)
        {
            var selectedStock = _stockRepository.Stocks.FirstOrDefault(p => p.StockId == stockId);
            if (selectedStock != null)
            {
                _shoppingCart.RemoveFromShoppingCart(selectedStock);
            }
            return RedirectToAction("Index");
        }
    }
}
