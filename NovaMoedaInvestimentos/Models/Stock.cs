using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaMoedaInvestimentos.Models
{
    [Table("Stocks")]
    public class Stock
    {
        [Key]
        public int StockId { get; set; }

        [Required(ErrorMessage ="Stock Name is Required")]
        [Display(Name="Stock Name")]
        [MinLength(3, ErrorMessage ="Stock Name must have at least 3 characters")]
        [MaxLength(100, ErrorMessage = "Stock Name must have a maximum of 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Stock Symbol is Required")]
        [Display(Name = "Stock Symbol")]
        [MinLength(3, ErrorMessage = "Stock Symbol must have at least 3 characters")]
        [MaxLength(4, ErrorMessage = "Stock Symbol must have a maximum of 4 characters")]
        public string Symbol { get; set; }

        [Required(ErrorMessage = "Current Price is Required")] 
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Current Price")]
        public double CurrentPrice { get; set; }

        [Required(ErrorMessage = "URL Image is Required")]
        [Display(Name = "URL Image")]
        [MinLength(10, ErrorMessage = "URL Image must have at least 10 characters")]
        [MaxLength(200, ErrorMessage = "URL Image must have a maximum of 200 characters")]
        public string Image { get; set; }

        [Display(Name = "Favorita?")]
        public bool IsFavoriteStock { get; set; }
    }
}
