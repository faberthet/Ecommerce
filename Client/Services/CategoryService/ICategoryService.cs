using Ecommerce7.Shared;

namespace Ecommerce7.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task GetCategories();
    }
}
