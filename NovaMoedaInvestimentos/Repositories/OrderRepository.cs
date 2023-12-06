using NovaMoedaInvestimentos.Context;
using NovaMoedaInvestimentos.Models;
using NovaMoedaInvestimentos.Repositories.Interfaces;

namespace NovaMoedaInvestimentos.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.Timestamp = DateTime.Now;
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach(var item in shoppingCartItems)
            {
                var detailOrder = new DetailOrder()
                {
                    Quantity = item.Quantity,
                    StockId = item.Stock.StockId,
                    OrderId = order.OrderId,
                    CurrentPrice = item.Stock.CurrentPrice
                };
                _appDbContext.DetailOrders.Add(detailOrder);
            }
            _appDbContext.SaveChanges();
        }
    }
}
