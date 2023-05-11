using Cv.Business.Concrete;
using Cv.Entity.Classes;
using Cv.UI.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IActionResult> Index()
        {
            var Values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = Values.Name;
            model.Surname = Values.Surname;
            model.PictureURL = Values.İmageURL;


            return View(model);
        }

        [HttpPost]
        public async Task <IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var Imagename = Guid.NewGuid() + extension;
                var SaveLocation = resource + "/wwwroot/Userimage/" + Imagename;
                var Stream = new FileStream(SaveLocation, FileMode.Create);
                await p.Picture.CopyToAsync(Stream);
                user.İmageURL = Imagename;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded) 
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
