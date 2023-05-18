using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class CantactSubController : Controller
	{
		ContactManager contactManager = new ContactManager(new EfContactDal());
		[HttpGet]
		public IActionResult Index()
		{

			var values = contactManager.TGetByID(1);
			return View(values);
		}

		[HttpPost]
		public IActionResult Index(Contact contact)
		{
			contactManager.TUpdate(contact);
			return RedirectToAction("Index", "Default");
		}
	}
}
