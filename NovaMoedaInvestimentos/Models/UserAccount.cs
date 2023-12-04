using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaMoedaInvestimentos.Models
{
    [Table("UserAccounts")]
    public class UserAccount
    {
        [Key]
        public int UserAccountId { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        [Display(Name = "UserName")]
        [MinLength(3, ErrorMessage = "UserName must have at least 3 characters")]
        [MaxLength(100, ErrorMessage = "UserName must have a maximum of 100 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "The Balance is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Balance")]
        public double Balance { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
