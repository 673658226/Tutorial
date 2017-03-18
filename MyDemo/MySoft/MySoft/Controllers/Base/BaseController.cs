using Qx.Tools;
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
        public ActionResult Alert(string content)
        {
            return Content("<script>alert(" + content + ");window.location.href=document.referrer</script>");
        }
        public ActionResult Alert(string content,int index)
        {
            return Content("<script>alert(" + content + ");history.go("+index+")</script>");
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
        private DataContext _dataContext;
        public DataContext DataContext
        {
            get
            {
                

                var hsaValue = Session["DataContext"] as DataContext;
                if (hsaValue == null && _dataContext == null)
                {
                    _dataContext = new DataContext();
                    Session["DataContext"] = _dataContext;
                }
                else
                {
                    _dataContext = hsaValue;
                }
                return _dataContext;
            }
            set
            {
                

                    _dataContext = value;
                    Session["DataContext"] = _dataContext;
     

            }
        }
    }
}