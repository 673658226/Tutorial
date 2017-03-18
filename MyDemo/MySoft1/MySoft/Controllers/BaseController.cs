using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySoft.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alert(string content)
        {
            return Content("<script>alert("+content+ ");window.location.href=document.referrer</script>");
        }
        protected string ReturnUrl
        {
            get
            {
                return Session["ReturnUrl"] != null ? Session["ReturnUrl"].ToString() : "/";
            }
            set
            {
                Session["ReturnUrl"] = value;
            }
        }
    }
}