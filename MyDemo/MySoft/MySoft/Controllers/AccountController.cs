using MySoft.Models;
using MySoft.ViewModels;
using Qx.Tools.CommonExtendMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using users.Interfaces;

namespace MySoft.Controllers
{
    public class AccountController : BaseController
    {
        private IuserPrivider _userProvider;
        public AccountController(IuserPrivider userProvider)
        {
            _userProvider = userProvider;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View(new Login_M());
        }
        [HttpPost]
        public ActionResult Login(Login_M viewModel)
        {

            if (ModelState.IsValid)
            {          
                if (_userProvider.Login(viewModel.uid,viewModel.psw))
                {
                    return LoginOK(viewModel.uid,"");
                }
                else
                {
                    return Alert("用户名或密码错误！", -1);
                }
            }
            else
            {
                return View(viewModel);
            }

        }
        public ActionResult LoginOK(string uid,string return_url, string uname="未设置")
        {
            var accountContext = new AccountContext();
            DataContext.UserID =
                accountContext.UserID = uid;
            DataContext.UserName =
             accountContext.UserName = uname;
            Session["AccountContext"] = accountContext;
            if (return_url.HasValue())
            {
                return Redirect(return_url);
            }
            else if (ReturnUrl.HasValue())
            {
                return Redirect(ReturnUrl);
            }
            else
            {
                return RedirectToAction("Index", new { msg = "用户[" + uid + "]登录成功!" });
            }
        }
    }
}