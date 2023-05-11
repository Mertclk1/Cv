using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
