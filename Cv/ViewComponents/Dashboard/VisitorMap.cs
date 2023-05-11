using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class VisitorMap : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
