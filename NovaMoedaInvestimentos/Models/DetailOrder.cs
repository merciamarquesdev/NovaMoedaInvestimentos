using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NovaMoedaInvestimentos.Models
{
    [Table("DetailOrders")]
    public class DetailOrder
    {
        [Key]
        public int DetailOrderId { get; set; }
        public int OrderId { get; set; }
        public int StockId { get; set; }
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Value is Required")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Value")]
        public double CurrentPrice { get; set; }

        public virtual Stock Stock { get; set; }
        public virtual Order Order { get; set; }
    }
}
