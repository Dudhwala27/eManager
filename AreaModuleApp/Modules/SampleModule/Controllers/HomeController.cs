using Microsoft.AspNetCore.Mvc;

namespace AreaModuleApp.Modules.SampleModule.Controllers
{
    [Area("Sample")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
