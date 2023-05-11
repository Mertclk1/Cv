using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Contact
{
    public class SendMessage : ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
		
	}
}
