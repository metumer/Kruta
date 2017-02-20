﻿using System.Web.Mvc;

namespace HPE.Kruta.Web.Controllers
{
    public class HomeController : BaseController
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}