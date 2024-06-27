using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class AboutController : Controller
    {
        AboutRepository repo = new AboutRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }

        [HttpPost]
        public ActionResult Index(TblAbouts abouts)
        {
            var value = repo.Find(x=>x.ID==1);
            value.Name = abouts.Name;   
            value.Surname = abouts.Surname; 
            value.Address = abouts.Address; 
            value.Phone = abouts.Phone;
            value.Mail = abouts.Mail;   
            value.Description = abouts.Description;
            value.Image = abouts.Image; 
            repo.TUpdate(value);
            return RedirectToAction("Index");

        }
    }
}