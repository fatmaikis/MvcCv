using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SkillController : Controller
    {
        SkillRepository repo = new SkillRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        public ActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSkill(TblSkills skills)
        {
            repo.TAdd(skills);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSkill(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkills skills)
        {
            var value = repo.Find(x=>x.ID==skills.ID);
            value.Skill = skills.Skill;
            value.Rate = skills.Rate;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}