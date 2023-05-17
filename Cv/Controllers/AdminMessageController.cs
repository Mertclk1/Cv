using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class AdminMessageController : Controller
	{
		WriterMessageManager writerMessageManager = new WriterMessageManager (new EfWriterMessageDal());
		public IActionResult ReceiverMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListReceiverMessage(p);
			return View(values);
		}
		public IActionResult SenderMessageList()
		{
			string p;
			p = "admin@gmail.com";
			var values = writerMessageManager.GetListSenderMessage(p);
			return View(values);
		}
		//Gönderilen mesaj Bölümü
		public IActionResult DeleteSenderAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			writerMessageManager.TDelete(values);
			return RedirectToAction("SenderMessageList");
		}

		public IActionResult DetailsSenderAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}

		// Alınan Mesaj Bölümü
		public IActionResult DeleteReceiverAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			writerMessageManager.TDelete(values);
			return RedirectToAction("ReceiverMessageList");
		}

		public IActionResult DetailsReceiverAdminMessage(int id)
		{
			var values = writerMessageManager.TGetByID(id);
			return View(values);
		}
	}
}
