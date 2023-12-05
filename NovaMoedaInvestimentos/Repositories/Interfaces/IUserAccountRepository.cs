using NovaMoedaInvestimentos.Models;

namespace NovaMoedaInvestimentos.Repositories.Interfaces
{
    public interface IUserAccountRepository
    {
        IEnumerable<UserAccount> UserAccounts { get; }
        UserAccount GetUserAccountById(int userAccountId);
    }
}
