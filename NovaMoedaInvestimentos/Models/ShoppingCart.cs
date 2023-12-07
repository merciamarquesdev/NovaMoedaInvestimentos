using Microsoft.EntityFrameworkCore;
using NovaMoedaInvestimentos.Context;
using System.Xml.Schema;

namespace NovaMoedaInvestimentos.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;
        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set;  }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            //define uma sessao
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //obtem um servico do tipo do meu contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do shopping cart
            string shoppingCartId = session.GetString("shoppingCartId") ?? Guid.NewGuid().ToString();

            //atribui o id do shopping cart na Sessao
            session.SetString("shoppingCartId", shoppingCartId);

            //retorna o shopping cart com o contexto e o Id atribuido ou obtido
            return new ShoppingCart(context)
            {
                ShoppingCartId = shoppingCartId,
            };
        }

        public void AddToShoppingCart(Stock stock)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Stock.StockId == stock.StockId &&
                s.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Stock = stock,
                    Quantity = 1
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public int RemoveFromShoppingCart(Stock stock)
        {
            var shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(
                s => s.Stock.StockId == stock.StockId &&
                s.ShoppingCartId == ShoppingCartId);

            var localQuantity = 0;

            if (shoppingCartItem != null)
            {
                if(shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localQuantity = shoppingCartItem.Quantity;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
                _context.SaveChanges();
            }
            return localQuantity;

        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems = _context.ShoppingCartItems
                                    .Where(s => s.ShoppingCartId == ShoppingCartId)
                                    .Include(s => s.Stock)
                                    .ToList());
        }

        public void EmptyShoppingCart()
        {
            var shoppingCartItems = _context.ShoppingCartItems
                                    .Where(shoppingCart => shoppingCart.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(shoppingCartItems);
            _context.SaveChanges();
        }

        public double GetShoppingCartAmount()
        {
            var amount = _context.ShoppingCartItems
                        .Where(c => c.ShoppingCartId == ShoppingCartId)
                        .Select(c => c.Stock.CurrentPrice * c.Quantity).Sum();
            return amount;
        }
    }
}
