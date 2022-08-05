using GrassyWomen.Models;
using GrassyWomen.Services;

namespace GrassyWomen.ViewModel
{
    public class ShoppingCartViewModel
    {
        public IShoppingCartServices ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }
        public int ShoppingCartItemsTotal { get; set; }
    }
}
