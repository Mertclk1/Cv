using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.SocialMedia
{
	public class SocialMediaList : ViewComponent
	{
		SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
		public IViewComponentResult Invoke()
		{
			var values = socialMediaManager.TGetList();
			return View(values);
		}
	}
}
