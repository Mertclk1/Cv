using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cv.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AboutController : Controller
	{
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult Index()
		{
			
			var values = aboutManager.TGetByID(1);
			return View(values);
		}

		[HttpPost]
		public IActionResult Index(About about)
		{
			aboutManager.TUpdate(about);
			return RedirectToAction("Index", "Default");
		}
	}
}
