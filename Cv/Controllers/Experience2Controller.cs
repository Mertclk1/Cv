using Cv.Business.Concrete;
using Cv.DataAccess.Abstract;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cv.UI.Controllers
{
	public class Experience2Controller : Controller
	{
		ExperienceManager experienceManager = new ExperienceManager(new EfExperienceDal());

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult ExperianceList()
		{
			var experiences = experienceManager.TGetList();
			var json = JsonConvert.SerializeObject(experiences);

			return Json(json);
		}

		[HttpPost]
		public IActionResult AddExperience(Experience p)
		{
			experienceManager.TAdd(p);
			var values = JsonConvert.SerializeObject(p);
			return Json(values);
		}
	}

}
