﻿using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents
{
	public class SocialMediaStats:ViewComponent
	{
		public IViewComponentResult Invoke(string a)
		{
			return View(a);
		}
	}
}
