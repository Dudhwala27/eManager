using Microsoft.AspNetCore.Mvc;

namespace AreaModuleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
