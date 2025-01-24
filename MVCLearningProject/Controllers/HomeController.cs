using Microsoft.AspNetCore.Mvc;

namespace MVCLearningProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public string Error()
        //{
        //    return "I have an error here.";
        //}
    }
}
