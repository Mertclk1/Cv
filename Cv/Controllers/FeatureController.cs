﻿using Cv.Business.Concrete;
using Cv.DataAccess.EntityFramework;
using Cv.Entity.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Cv.UI.Controllers
{
	public class FeatureController : Controller
	{
		FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
		[HttpGet]
		public IActionResult Index()
		{
			
			var values = featureManager.TGetByID(1);
			return View(values);
		}
		
		[HttpPost]
		public IActionResult Index(Feature feature)
		{
			featureManager.TUpdate(feature);
			return RedirectToAction("Index", "Default");
		}
	}
	
}