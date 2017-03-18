using MySoft.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySoft.Controllers
{
    public class BaseAccountController :BaseController
    {
        // GET: BaseAccount
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (AccountContext == null)//未登录
            {
                ReturnUrl = Request.RawUrl;
                filterContext.Result = new RedirectResult("/Account/Login");
            }
            else
            {
                base.OnActionExecuting(filterContext);
            }
        }
        protected AccountContext AccountContext
        {
            get
            {
                return Session["AccountContext"] as AccountContext;
            }
            set
            {
                Session["AccountContext"] = value;
            }
        }
    }
}