using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Portfolio
{
	public class SlideList : ViewComponent
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());

		public IViewComponentResult Invoke()
		{
			var values = portfolioManager.TGetList();
			return View(values);
		}
	}
}
