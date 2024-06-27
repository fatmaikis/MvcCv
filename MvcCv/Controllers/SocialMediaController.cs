using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaRepository repo = new SocialMediaRepository();
        
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        public ActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedias socialMedias)
        {
            
            repo.TAdd(socialMedias);
            return RedirectToAction("Index");
        }
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedias socialMedias)
        {
            var value = repo.Find(x => x.ID == socialMedias.ID);
            value.Name = socialMedias.Name;
            value.Status = true;
            value.Link  = socialMedias.Link;
            value.Icon = socialMedias.Icon; 
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            value.Status = false;
            repo.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}