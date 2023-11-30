namespace NovaMoedaInvestimentos.Models
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }
        public string UserName { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
