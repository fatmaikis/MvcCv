using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        public ActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddExperience(TblExperiences experiences)
        {
            repo.TAdd(experiences);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteExperience(int id)
        {
            var value = repo.Find(x => x.ID == id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateExperience(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(TblExperiences experiences)
        {
            var value = repo.Find(x => x.ID == experiences.ID);
            value.Title = experiences.Title;
            value.SubTitle = experiences.SubTitle;
            value.Description = experiences.Description;
            value.Date  = experiences.Date;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}