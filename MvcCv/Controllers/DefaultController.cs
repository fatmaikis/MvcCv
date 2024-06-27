using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        DbCvEntities entities = new DbCvEntities();
        public ActionResult Index()
        {
            var value = entities.TblAbouts.ToList();
            return View(value);
        }
        public PartialViewResult SocialMedia()
        {
            var socialMedia = entities.TblSocialMedias.Where(x=>x.Status==true).ToList();
            return PartialView(socialMedia);
        }
        public PartialViewResult Experience()
        {
            var experience = entities.TblExperiences.ToList();
            return PartialView(experience);
        }
        public PartialViewResult Education()
        {
            var education = entities.TblEducations.ToList();
            return PartialView(education);
        }
        public PartialViewResult Skill()
        {
            var skill = entities.TblSkills.ToList();
            return PartialView(skill);
        }
        public PartialViewResult Hobby()
        {
            var hobby = entities.TblHobbies.ToList();
            return PartialView(hobby);
        }
        public PartialViewResult Certificate()
        {
            var certificate = entities.TblCertificates.ToList();
            return PartialView(certificate);
        }
        public PartialViewResult Communication()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Communication(TblCommunication communication)
        {
            communication.Date=DateTime.Parse( DateTime.Now.ToShortDateString());   
            entities.TblCommunication.Add(communication);
            entities.SaveChanges();
            return PartialView();
        }
    }
}