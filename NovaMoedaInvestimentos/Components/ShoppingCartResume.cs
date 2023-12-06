using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.ViewModels;

namespace NovaMoedaInvestimentos.Components
{
    public class ShoppingCartResume : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartResume(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();

            //var items = new List<ShoppingCartItem>()
            //{
            //    new ShoppingCartItem(),
            //    new ShoppingCartItem()
            //};

            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartAmount = _shoppingCart.GetShoppingCartAmount()
            };

            return View(shoppingCartVM);
        }
    }
}
