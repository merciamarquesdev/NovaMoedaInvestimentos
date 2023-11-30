using NovaMoedaInvestimentos.Models.Enums;
namespace NovaMoedaInvestimentos.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        private Enum ETransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime? Timestamp { get; set; }

        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public int UserAccountId { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
