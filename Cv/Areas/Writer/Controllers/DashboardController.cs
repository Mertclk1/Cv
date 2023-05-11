using Cv.Business.Concrete;
using Cv.DataAccess.Concrete;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Cv.UI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

		public DashboardController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;
            //Havadurumu Apisi
            string api = "f8db5e52cb843c912f0cf385811e4977";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Antalya&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
			//istatislikler
			Context c = new Context();
            ViewBag.v1 = c.writerMessages.Where(x=>x.Recever==values.Email).Count(); 
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();
            return View();
        }
    }
}
