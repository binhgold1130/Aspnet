
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cvb_Lesson04.Models;

namespace cvb_Lesson04.Controllers
{
    public class CvbCustomerScafController : Controller
    {
        //mockdata 
        private static List<cvbCustomer> listCustomer = new List<cvbCustomer>()
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
                CustomerId = 3,
                FirstName = "Đàm Vĩnh",
                LastName = "Trinh 1 ",
                Address = "K22CNT4",
                YearOfBirth = 2022
            },
            new cvbCustomer()
            {
                CustomerId = 4,
                FirstName = "Đàm Vĩnh",
                LastName = "Trinh 2 ",
                Address = "K22CNT4",
                YearOfBirth = 2022
            }
         };

    // GET: cvbCustomerScaf
    //list customer

    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult cvbCreate()
        {
            var model = new cvbCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult CvbCreate(cvbCustomer model )
        {
            // thêm mới đối tượng khách hàng
            listCustomer.Add(model);

            //return View(model);
            // chuyển về trang danh sách 
            return RedirectToAction("Index");
        }
        public ActionResult CvbEdit(int id )
        {
            var customer =listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}