using Microsoft.AspNetCore.Mvc;
using MVCLearningProject.Models;

namespace MVCLearningProject.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }
        public IActionResult Edit(int? id)
        {
            var category = CategoriesRepository.GetCategory(id.HasValue ? id.Value : 0);
            //var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
           return View(category);
        }
    }
}
