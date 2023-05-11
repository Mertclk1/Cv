using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Skill
{
	public class SkillList : ViewComponent
	{
		SkillManager skillManager = new SkillManager(new EfSkillDal());
		public IViewComponentResult Invoke()
		{
			var values = skillManager.TGetList();
			return View(values);
		}
	}
}
