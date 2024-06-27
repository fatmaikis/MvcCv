using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{

    public class EducationController : Controller
    {
        EducationRepository repo = new EducationRepository();
      
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        public ActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEducation(TblEducations educations)
        {
            if (!ModelState.IsValid)
            {
                return View("AddEducation");
            }
            repo.TAdd(educations);
            return RedirectToAction("Index");   
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateEducation(int id)
        {
            var value = repo.Find(x => x.ID == id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducations educations)
        {
            if (!ModelState.IsValid)
            {
                return View("UpdateEducation");
            }
            var value = repo.Find(x => x.ID == educations.ID);
            value.Title = educations.Title;
            value.SubTitle = educations.SubTitle;   
            value.SubTitle2 = educations.SubTitle2; 
            value.GNO= educations.GNO;  
            value.Date = educations.Date;   
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }





    }
}