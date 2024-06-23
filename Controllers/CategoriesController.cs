using AthleteManagementApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace AthleteManagementApp.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        { 
            this.categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> List()
        {
            var categories = await categoryRepository.GetAllAsync();

            return View(categories);
        }
    }
}
