using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Default
{
	public class FooterList : ViewComponent
	{
		SocialMediaManager mediaManager = new SocialMediaManager (new EfSocialMediaDal());
		public IViewComponentResult Invoke() 
		{
			var values = mediaManager.TGetList();
			return View(values);	
		}
	}
}
