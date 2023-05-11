using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class ServiceController : Controller
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.v1 = "Düzenleme";
			ViewBag.v2 = "Hizmetlerim";
			ViewBag.v3 = "Hizmetlerim Sayfası";
			var values = serviceManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddService()
		{
			ViewBag.v1 = "Hizmet Ekleme";
			ViewBag.v2 = "Hizmetlerim";
			ViewBag.v3 = "Hizmet Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);

			return RedirectToAction("Index");
		}

		public IActionResult DeleteService(int id)
		{
			var values = serviceManager.TGetByID(id);
			serviceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditService(int id)
		{
			ViewBag.v1 = "Hizmet Düzenle";
			ViewBag.v2 = "Hizmetler";
			ViewBag.v3 = "Hizmet Düzenle";
			var values = serviceManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditService(Service service)
		{
			serviceManager.TUpdate(service);
			return RedirectToAction("Index");
		}
	}
}
