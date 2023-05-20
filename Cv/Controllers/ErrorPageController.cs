using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class ErrorPageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
