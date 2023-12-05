using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NovaMoedaInvestimentos.Models
{
    [Table("ShoppingCartItems")]
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Stock Stock { get; set; }
        public int Quantity { get; set; }
        [StringLength(200)]
        public string ShoppingCartId { get; set; }
    }
}
