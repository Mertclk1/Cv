using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Service
{
	public class ServiceList : ViewComponent
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		public IViewComponentResult Invoke()
		{
			var values = serviceManager.TGetList();
			return View(values);
		}
	}
}
