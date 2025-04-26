using Microsoft.AspNetCore.Mvc;

namespace MVCLearningProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
