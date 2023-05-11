using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Contact
{
	public class ContactDetails : ViewComponent
	{
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
