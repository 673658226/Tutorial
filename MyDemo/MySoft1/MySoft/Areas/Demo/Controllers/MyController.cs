using Qx.Tools.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using users.Entity;

namespace MySoft.Areas.Demo.Controllers
{
    public class MyController : Controller
    {
        private IRepository<users.Entity.users> _user;
        public MyController(IRepository<users.Entity.users> user)
        {
            _user = user;
        }
        // GET: Demo/My
        public ActionResult Index()
        {
            var user = _user.Find("1425121012");
            ViewData["UserName"] = user.UserName;
            return View();
        }
    }
}