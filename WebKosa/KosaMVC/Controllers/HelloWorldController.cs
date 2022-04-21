using Microsoft.AspNetCore.Mvc;

namespace KosaMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string welcome() {
            return "this is welcome action method...";
        }
    }
}
