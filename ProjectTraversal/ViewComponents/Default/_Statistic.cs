﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTraversal.ViewComponents.Default
{
    public class _Statistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c =  new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = 3000; 
            return View();
        }
    }
}
