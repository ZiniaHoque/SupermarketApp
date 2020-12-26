using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Services;
using Supermarket.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Supermarket.API.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IEnumerable<Category>>GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}