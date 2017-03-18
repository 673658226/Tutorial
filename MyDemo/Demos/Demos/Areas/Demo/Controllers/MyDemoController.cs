using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demos.Areas.Demo.Controllers
{
    public class MyDemoController : Controller
    {
        // GET: Demo/MyDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}