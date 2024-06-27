using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class HobbyController : Controller
    {
        HobbyRepository repo = new HobbyRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        [HttpPost]
        public ActionResult Index(TblHobbies hobbies)
        {
            var value = repo.Find(x=>x.ID ==1);
            value.Description = hobbies.Description;
            value.Description2 = hobbies.Description2;
            repo.TUpdate(value);
           return RedirectToAction("Index");
        }

    }
}