using MvcCv.Models.Entity;
using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class CertificateController : Controller
    {
        CertificateRepository repo = new CertificateRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
        public ActionResult AddCertificate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCertificate(TblCertificates certificates)
        {
            repo.TAdd(certificates);
            return RedirectToAction("Index");   
        }
        public ActionResult DeleteCertificate(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            repo.TDelete(value);
            return RedirectToAction("Index");
        }
        public ActionResult UpdateCertificate(int id)
        {
            var value = repo.Find(x=>x.ID==id);
            ViewBag.deger = id;
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCertificate(TblCertificates certificates)
        {
            var value = repo.Find(x => x.ID == certificates.ID);
            value.Date = certificates.Date; 
            value.Descrption = certificates.Descrption; 
            repo.TUpdate(value);    
            return RedirectToAction("Index");   
        }
    }
}