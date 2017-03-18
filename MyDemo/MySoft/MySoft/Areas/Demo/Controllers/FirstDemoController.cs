using MySoft.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySoft.Areas.Demo.Controllers
{
    public class FirstDemoController : BaseAccountController
    {
        // GET: Demo/FirstDemo
        public ActionResult Index()
        {
            ViewData["Layout"] = "_Layout";
            return View();
        }
    }
}