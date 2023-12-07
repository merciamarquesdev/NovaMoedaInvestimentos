using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NovaMoedaInvestimentos.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is Required")]
        [Display(Name = "Category Name")]
        [MinLength(3, ErrorMessage = "Category Name must have at least 3 characters")]
        [MaxLength(100, ErrorMessage = "Category Name must have a maximum of 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category Description is Required")]
        [Display(Name = "Category Description")]
        [MinLength(3, ErrorMessage = "Category Description must have at least 3 characters")]
        [MaxLength(200, ErrorMessage = "Category Description must have a maximum of 100 characters")]
        public string Description { get; set; }

        public List<Stock> Stocks { get; set; }
    }
}
