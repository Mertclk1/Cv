﻿using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Cv.UI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		[HttpGet]
		public IActionResult Index()
		{
			
			var values = serviceManager.TGetList();
			return View(values);
		}

		[HttpGet]
		public IActionResult AddService()
		{
			
			return View();
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);

			return RedirectToAction("Index");
		}

		public IActionResult DeleteService(int id)
		{
			var values = serviceManager.TGetByID(id);
			serviceManager.TDelete(values);
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult EditService(int id)
		{
			var values = serviceManager.TGetByID(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult EditService(Service service)
		{
			serviceManager.TUpdate(service);
			return RedirectToAction("Index");
		}
	}
}
