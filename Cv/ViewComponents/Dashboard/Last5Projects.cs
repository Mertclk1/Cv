using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class Last5Projects : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
