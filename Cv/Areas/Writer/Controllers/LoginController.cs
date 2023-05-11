using Cv.Entity.Classes;
using Cv.UI.Areas.Writer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.Controllers
{
	[Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class LoginController : Controller
	{
		private readonly SignInManager<WriterUser> _signInManager;

		public LoginController(SignInManager<WriterUser> signInManager)
		{
			_signInManager = signInManager;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserLoginViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, true, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Dashboard");
				}
				else
				{
					ModelState.AddModelError("loginError", "Hatalı Kullanıcı adı veya şifre");
				}
			}
			else
			{
				ModelState.AddModelError("loginError", "Geçersiz giriş bilgileri");
			}
			return View();
		}

	}
}
