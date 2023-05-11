using Cv.Business.Concrete;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Cv.UI.ViewComponents.About
{
	public class AboutList : ViewComponent
	{
		AboutManager AboutManager = new AboutManager (new EfAboutDal());
		public IViewComponentResult Invoke()
		{
			var values = AboutManager.TGetList();
			return View(values);
		}
	}
}
