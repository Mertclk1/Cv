﻿using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class ContactController : Controller
	{
		MessageManager messageManager = new MessageManager(new EfMessageDal());

		

		public IActionResult Index()
		{
			var values =messageManager.TGetList();
			return View(values);
		}

		public IActionResult DeleteContact(int id)
		{
			var values = messageManager.TGetByID(id);
			messageManager.TDelete(values);
			return RedirectToAction("Index");
		}

		public ActionResult DetailsContact(int id)
		{
			var values = messageManager.TGetByID(id);
			return View(values);
		}
	}
}