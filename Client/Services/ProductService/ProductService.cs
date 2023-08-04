
using Ecommerce7.Shared;
using System.Net.Http.Json;

namespace Ecommerce7.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public event Action ProductsChanged;
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ? await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
            {
                Products = result.Data;
            }

            ProductsChanged.Invoke();
        }
        public async Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var result= await _http.GetFromJsonAsync<ServiceResponse<Product>>("api/product/{id}");
            if (result == null)
            {
                return new ServiceResponse<Product>()
                {
                    Message = "error"
                };
            }
            return result;
        }

       
    }
}
