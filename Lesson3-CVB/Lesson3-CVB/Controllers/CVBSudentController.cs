using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson3_CVB.Controllers
{
    public class CVBStudentController : Controller
    {
        // GET: CVBStudent
        public ActionResult Index()
        {
          
            // dữ liệu từ ViewData
            ViewData["msg"] = "View Data - Cao Văn Bình";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            // Sử dụng ViewBag
            // Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên Cao Văn Bình";
            // Giá trị là một tập hợp
            string[] names = { "Trần Tiến", "Tạ Hồng", "Diễm Hương", "Vương Định" };
            ViewBag.list = names;
            // Giá trị là một đối tượng
            var obj = new
            {
                ID = 100,
                Name= "Bình ",
                Age= 21
            };
            ViewBag.student = obj;

            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}