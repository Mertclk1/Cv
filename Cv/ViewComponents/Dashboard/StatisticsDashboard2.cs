using Cv.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class StatisticsDashboard2 : ViewComponent
	{
		Context context = new Context();
		public IViewComponentResult Invoke()
		{
			ViewBag.v1 = context.Portfolios.Count();
			ViewBag.v2 = context.Services.Count();
			ViewBag.v3 = context.Messages.Count();
			return View();
		}
	}
}
