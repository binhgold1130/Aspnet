using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson10.Controllers
{
    public class CvbHomeController : Controller
    {
        public ActionResult CvbIndex()
        {
            // Kiếm dữ liệu trong sessoin
            if (Sessoin["CvbAccount"] != null)
            {
                var cvbAccount = Sessoin["CvbAccount"] as CvbAccount;
                ViewBag.FullName = cvbAccount.CvbFullName;
            }
            return View();
        }

        public ActionResult CvbAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CvbContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}