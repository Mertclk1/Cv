using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class AdminNatificationNavbarList : ViewComponent
	{
		public IViewComponentResult Invoke ()
		{
			return View();
		}
	}
}
