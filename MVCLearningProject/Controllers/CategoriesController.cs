using Microsoft.AspNetCore.Mvc;

namespace MVCLearningProject.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
