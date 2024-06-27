using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        AdminRepository repo = new AdminRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }

        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(TblAdmin admin)
        {
            repo.TAdd(admin);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            var value = repo.Find(x => x.ID == id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateAdmin(int id)
        {
            var value = repo.Find(x => x.ID == id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(TblAdmin admin)
        {
            var value = repo.Find(x => x.ID == admin.ID);
            value.UserName = admin.UserName;
            value.Password =admin.Password;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}