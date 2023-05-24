using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cv.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
	{
		MessageManager messageManager = new MessageManager(new EfMessageDal());
		public IActionResult Index()
		{
			var values = messageManager.TGetList().Take(5).ToList();
			return View(values);
		}
		
	}
}
