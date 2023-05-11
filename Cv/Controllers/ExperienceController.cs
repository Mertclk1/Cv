using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class ExperienceController : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExparienceDal());
		public IActionResult Index()
		{
			ViewBag.v1 = "Diploma ve Sertifika Listesi";
			ViewBag.v2 = "Diploma ve Sertifika";
			ViewBag.v3 = "Diploma ve Sertifika Listesi";
			var values = experienceManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddExperience()
		{
			ViewBag.v1 = "Diploma ve Sertifika Ekleme";
			ViewBag.v2 = "Diploma ve Sertifika";
			ViewBag.v3 = "Diploma ve Sertifika Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddExperience(Experience experience)
		{
			experienceManager.TAdd(experience);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteExperience(int id)
		{
			var values = experienceManager.TGetByID(id);
			experienceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditExperience(int id)
		{
			ViewBag.v1 = "Diploma ve Sertifika Düzenle";
			ViewBag.v2 = "Diploma ve Sertifika";
			ViewBag.v3 = "Diploma ve Sertifika Düzenle";
			var values = experienceManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditExperience(Experience experience)
		{
			experienceManager.TUpdate(experience);
			return RedirectToAction("Index");
		}
	}
}
