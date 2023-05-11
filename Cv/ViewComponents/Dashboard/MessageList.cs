using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class MessageList : ViewComponent
	{
		
		public IViewComponentResult Invoke() 
		{
			
			return View();
		}
	}
}
