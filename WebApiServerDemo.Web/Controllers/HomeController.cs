﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace WebApiServerDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WebApiServerDemoControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}