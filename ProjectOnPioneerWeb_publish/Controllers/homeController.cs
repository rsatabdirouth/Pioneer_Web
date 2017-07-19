using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectOnPioneerWeb_publish.Models;

namespace ProjectOnPioneerWeb_publish.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Careers()
        {
            return View();
        }
      
        public ActionResult AboutUs()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            PioneerData model = new PioneerData();
            return View(model);
           
        }
        [HttpPost]
        public ActionResult ContactUs(PioneerData model)
        {
            if (!ModelState.IsValid)
            { return View(); }
            using (PioneerContext objContext = new PioneerContext())
            {
                objContext.PioneerDatas.Add(model);
                objContext.SaveChanges();
            }
            model.isSubmitted = true;
            return View(model);


        }
       
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult CookiePolicy()
        {
            return View();
        }
    }
}