using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
