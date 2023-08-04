using Ecommerce7.Server.Services.CategoryService;
using Ecommerce7.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce7.Server.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCategories()
        {
            var result = await _categoryService.GetCategoriesAsync();
            return Ok(result);
        }
    }
}
