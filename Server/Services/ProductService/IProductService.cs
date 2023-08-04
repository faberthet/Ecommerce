
using Ecommerce7.Shared;

namespace Ecommerce7.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductByIdAsync(int id);

        Task<ServiceResponse<List<Product>>> GetProductByCategory(string categoryUrl);

    }
}
