using System.ComponentModel.DataAnnotations;

namespace GrassyWomen.Models
{
    public class ShoppingCartItem
    {

        public int Qty { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        [StringLength(255)]
        public string ShoppingCartId { get; set; }
    }
}
