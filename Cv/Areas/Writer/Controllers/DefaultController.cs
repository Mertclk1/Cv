
using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.Controllers
{
	[Area("Writer")]
	[Authorize]
    [Route("Writer/[controller]/[action]")]
    public class DefaultController : Controller
	{
		AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
		public IActionResult Index()
		{
			var values = announcementManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AnnouncementDetails(int id)
		{
			var values = announcementManager.TGetByID(id);
			return View(values);
		}

	}
}
