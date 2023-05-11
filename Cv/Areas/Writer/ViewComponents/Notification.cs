using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.ViewComponents
{
	public class Notification : ViewComponent
	{
		AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
		public IViewComponentResult Invoke()
		{ 
			var values = _announcementManager.TGetList().Take(5).ToList();

			return View(values);
		}
	}
}
