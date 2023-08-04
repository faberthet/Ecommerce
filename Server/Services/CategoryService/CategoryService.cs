using Ecommerce7.Server.Data;
using Ecommerce7.Shared;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce7.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();

            return new ServiceResponse<List<Category>>
            {
                Data = categories,
        };
        }
    }
}
