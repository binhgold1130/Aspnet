using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvbK22CNT4Lesson11_2210900091.Controllers
{
    public class CvbHomeController : Controller
    {
        public ActionResult CvbIndex()
        {
            return View();
        }

        public ActionResult CvbAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CvbContact()
        {
            ViewBag.msv = "2210900091";
            ViewBag.fullname = "Cao Văn Bình";

            return View();
        }
    }
}