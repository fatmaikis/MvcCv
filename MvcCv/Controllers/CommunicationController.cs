using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class CommunicationController : Controller
    {
        CommunicationRepository repo = new CommunicationRepository();
        public ActionResult Index()
        {
            var value = repo.List();
            return View(value);
        }
    }
}