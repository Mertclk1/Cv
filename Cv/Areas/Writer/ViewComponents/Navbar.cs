using Cv.Business.Concrete;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Areas.Writer.ViewComponents
{
    public class Navbar : ViewComponent
    {
        private readonly UserManager<WriterUser> _userManager;

        public Navbar(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync ()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v=values.İmageURL;

            return View();
        }
    }
}
