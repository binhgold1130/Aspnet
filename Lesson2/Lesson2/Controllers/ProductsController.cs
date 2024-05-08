﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ https://localhost:44305/Products
        public ActionResult Index()
        {
            ViewBag.name = "Cao Văn Bình - 2210900091";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string GetName()
        {
            return "Cao Văn Bình - 2210900091";
        }
        public JsonResult ListName()
        {
            string[] names = { "Hùng", "Dũng", "Sang", "Trọng" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}