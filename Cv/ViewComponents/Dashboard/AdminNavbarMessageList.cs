using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.ViewComponents.Dashboard
{
	public class AdminNavbarMessageList : ViewComponent
	{
		WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
		public IViewComponentResult Invoke()
		{
			string p = "admin@gmail.com";
			var values = _writerMessageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.WtiterMessageId).Take(3).ToList();
			return View(values);
		}
	}
}
