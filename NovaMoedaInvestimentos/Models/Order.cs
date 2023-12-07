
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaMoedaInvestimentos.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo 'Sobrenome' é obrigatório.")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Amount is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Total Order Items is Required")]
        [DisplayName("Total Order Items")]
        public double TotalOrderItems { get; set; }

        [DisplayName("Order Date and Time")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString ="{0: dd/MM/yyyy hh:mm}",ApplyFormatInEditMode = true)]
        public DateTime? Timestamp { get; set; }

        public List<DetailOrder> OrderItems { get; set; } 


    }
}
