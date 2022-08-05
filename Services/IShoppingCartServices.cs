using GrassyWomen.Models;

namespace GrassyWomen.Services
{
    public interface IShoppingCartServices
    {
        string Id { get; set; }
        IEnumerable<ShoppingCartItem> ShoppingCartItems { get; set; }

        Task<int> AddToCartAsync(Product product, int qty = 1);
        Task ClearCartAsync();
        Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItemsAsync();
        Task<int> RemoveFromCartAsync(Product product);
        Task<(int ItemCount, decimal TotalAmmount)> GetCartCountAndTotalAmmountAsync();
    }
}
