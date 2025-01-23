using Microsoft.AspNetCore.Mvc;

namespace MVCLearningProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World!";
        }
        public string Error()
        {
            return "I have an error here.";
        }
    }
}
