using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
