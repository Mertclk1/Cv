using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}

		public PartialViewResult NavBarPartial()
		{
			return PartialView();
		}


		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult SendMessage(Message p)
		{
			MessageManager messageManager = new MessageManager(new EfMessageDal());
			p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());// mesajın kaydedildiği tarihi alır.
			p.Status = true;
			messageManager.TAdd(p);
			return PartialView();
		}
	}
}
