using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CvbK22CNT4Lesson11_2210900091.Models;

namespace CvbK22CNT4Lesson11_2210900091.Controllers
{
    public class CvbCategoriesController : Controller
    {
        private CvbLesson11Entities db = new CvbLesson11Entities();

        // GET: CvbCategories
        public ActionResult CvbIndex()
        {
            return View(db.CvbCategories.ToList());
        }

        // GET: CvbCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbCategory cvbCategory = db.CvbCategories.Find(id);
            if (cvbCategory == null)
            {
                return HttpNotFound();
            }
            return View(cvbCategory);
        }

        // GET: CvbCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CvbCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CvbID,CvbCategory1,CvbStatus")] CvbCategory cvbCategory)
        {
            if (ModelState.IsValid)
            {
                db.CvbCategories.Add(cvbCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cvbCategory);
        }

        // GET: CvbCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbCategory cvbCategory = db.CvbCategories.Find(id);
            if (cvbCategory == null)
            {
                return HttpNotFound();
            }
            return View(cvbCategory);
        }

        // POST: CvbCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CvbID,CvbCategory1,CvbStatus")] CvbCategory cvbCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cvbCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cvbCategory);
        }

        // GET: CvbCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbCategory cvbCategory = db.CvbCategories.Find(id);
            if (cvbCategory == null)
            {
                return HttpNotFound();
            }
            return View(cvbCategory);
        }

        // POST: CvbCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CvbCategory cvbCategory = db.CvbCategories.Find(id);
            db.CvbCategories.Remove(cvbCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
