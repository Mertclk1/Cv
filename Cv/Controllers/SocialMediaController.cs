using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class SocialMediaController : Controller
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
		public IActionResult Index()
		{
			var values = socialMediaManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia social)
		{
			social.Status = true;
			socialMediaManager.TAdd(social);
			return RedirectToAction("Index");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = socialMediaManager.TGetByID(id);
			socialMediaManager.TDelete(values);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult EditSocialMedia(int id) 
		{

			var values = socialMediaManager.TGetByID(id);
			return View(values);
		}

		[HttpPost]
		public IActionResult EditSocialMedia(SocialMedia socialMedia)
		{
			socialMediaManager.TUpdate(socialMedia);
			return RedirectToAction("Index");
		}
	}
}
