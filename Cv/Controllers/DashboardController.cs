using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cv.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
