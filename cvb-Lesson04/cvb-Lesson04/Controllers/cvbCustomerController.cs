using cvb_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cvb_Lesson04.Controllers
{
    public class CvbCustomerController : Controller
    {
        // GET: cvbCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: cvbCustomerDetail
        public ActionResult cvbCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new cvbCustomer()
            {
                CustomerId = 1,
                FirstName = "Cao Văn",
                LastName = "Bình",
                Address = "K22CNT4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        // customerlist
        public ActionResult cvbListCustomer()
        {
            var list = new List<cvbCustomer>()
            {
                new cvbCustomer()
                {
                CustomerId = 1,
                FirstName = "Cao Văn",
                LastName = "Bình",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new cvbCustomer()
                {
                CustomerId = 2,
                FirstName = "Cao Văn",
                LastName = "Bình 2",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                new cvbCustomer()
                {
                CustomerId=3,
                FirstName="Đàm Vĩnh",
                LastName="Trinh 1 ",
                Address = "K22CNT4",
                YearOfBirth=2022
                },
                new cvbCustomer()
                {
                CustomerId=4,
                FirstName="Đàm Vĩnh",
                LastName="Trinh 2 ",
                Address = "K22CNT4",
                YearOfBirth=2022
                }
                };

            ViewBag.list = list; // đưa dữ liệu ra view bằng viewbag
            return View(list);
        }
    }
}