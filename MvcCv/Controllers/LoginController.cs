using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TblAdmin admin)
        {
            DbCvEntities db = new DbCvEntities();
            var user = db.TblAdmin.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            if (user !=null)
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                Session["KullaniciAdi"] = user.UserName.ToString();
                return RedirectToAction("Index","Experience");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
            
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}