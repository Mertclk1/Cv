using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class SkillController : Controller
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IActionResult Index()
		{

			ViewBag.v1 = "Yetenek Listesi";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenekler Listesi";
			var values = skillManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSkill()
		{
			ViewBag.v1 = "Yetenek Ekleme";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenekler Ekleme";
			return View();
		}
		[HttpPost]
		public IActionResult AddSkill(Skill skill)
		{
			skillManager.TAdd(skill);

			return RedirectToAction("Index");
		}

		public IActionResult DeleteSkill(int id)
		{
			var values = skillManager.TGetByID(id);
			skillManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			ViewBag.v1 = "Yetenek Düzenle";
			ViewBag.v2 = "Yetenekler";
			ViewBag.v3 = "Yetenekler Düzenle";
			var values = skillManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSkill(Skill skill)
		{
			skillManager.TUpdate(skill);
			return RedirectToAction("Index");
		}
	}
}
