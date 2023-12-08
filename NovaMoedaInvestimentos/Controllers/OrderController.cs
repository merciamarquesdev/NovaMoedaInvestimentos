using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;

namespace NovaMoedaInvestimentos.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository,
            ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            int totalItemsOrder = 0;
            double amountOrder = 0.0;

            //obtem os itens do carrinho de compra do cliente
            List<ShoppingCartItem> items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            //verifica se existem itens de pedido
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio, que tal incluir uma ação?");
            }

            //calcula o total de itens e o total do pedido
            foreach (var item in items)
            {
                totalItemsOrder += item.Quantity;
                amountOrder += (item.Stock.CurrentPrice * item.Quantity);
            }

            //atribui os valores obtidos ao pedido
            order.TotalOrderItems = totalItemsOrder;
            order.Amount = amountOrder;

            //valida os dados do pedido
            if (ModelState.IsValid)
            {
                //cria o pedido e os detalhes
                _orderRepository.CreateOrder(order);

                //define mensagens ao cliente
                ViewBag.CheckoutCompleteMessage = "Agradecemos pela preferência :)";
                ViewBag.AmountOrder = _shoppingCart.GetShoppingCartAmount();

                //limpa o carrinho do cliente
                _shoppingCart.EmptyShoppingCart();

                //exibe a view com dados do cliente e do pedido
                return View("~/Views/Order/CheckoutComplete.cshtml", order);
            }
            return View(order);
        }
    }
}
