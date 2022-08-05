using GrassyWomen.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using GrassyWomen.Models;


namespace GrassyWomen.Models
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetProducts(string category = null);

        Task<Product> GetProductById(int productId);

        Task<IEnumerable<ProductNameIdDto>> GetAllProductsNameId();

        void UpdateProduct(Product product);
        Task AddProductAsync(Product product);
        void Delete(int id);
    }
}
