using NovaMoedaInvestimentos.Models.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaMoedaInvestimentos.Models
{
    [Table("Transactions")]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [EnumDataType(typeof(ETransactionType))]
        [Required(ErrorMessage = "Transaction Type is Required")]
        [Column(TypeName = "enum")]
        [DisplayName("Transaction Type")]
        private Enum ETransactionType { get; set; }

        [Required(ErrorMessage = "Amount is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Amount")]
        public double Amount { get; set; }

        [DisplayName("Timestamp")]
        public DateTime? Timestamp { get; set; }

        public int StockId { get; set; }
        public virtual Stock Stock { get; set; }
        public int UserAccountId { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
