using Cv.Business.Concrete;
using Cv.Entity.Classes;
using Cv.UI.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Cv.UI.Areas.Writer.Controllers
{
	[Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class RegisterController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public RegisterController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(UserRegisterViewModel p)
		{
			if (ModelState.IsValid)
			{
				WriterUser w = new WriterUser()
				{
					Name = p.Name,
					Surname = p.Surname,
					Email = p.Mail,
					UserName = p.UserName,
					İmageURL = p.ImgURL,
				};
				var result = await _userManager.CreateAsync(w, p.Password);
				if (result.Succeeded && p.ConfirmPassword == p.Password)
				{
					return RedirectToAction("Index","Login");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);

					}
				}
			}
			return View();
		}
	}
}
