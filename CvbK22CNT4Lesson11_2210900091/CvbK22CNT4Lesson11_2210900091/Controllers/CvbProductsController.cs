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
    public class CvbProductsController : Controller
    {
        private CvbLesson11Entities db = new CvbLesson11Entities();

        // GET: CvbProducts
        public ActionResult CvbIndex()
        {
            return View(db.CvbProducts.ToList());
        }

        // GET: CvbProducts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbProduct cvbProduct = db.CvbProducts.Find(id);
            if (cvbProduct == null)
            {
                return HttpNotFound();
            }
            return View(cvbProduct);
        }

        // GET: CvbProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CvbProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CvbId2210900091,CvbProName,CvbQty,CvbPrice,CvbCateld,CvbActive")] CvbProduct cvbProduct)
        {
            if (ModelState.IsValid)
            {
                db.CvbProducts.Add(cvbProduct);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cvbProduct);
        }

        // GET: CvbProducts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbProduct cvbProduct = db.CvbProducts.Find(id);
            if (cvbProduct == null)
            {
                return HttpNotFound();
            }
            return View(cvbProduct);
        }

        // POST: CvbProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CvbId2210900091,CvbProName,CvbQty,CvbPrice,CvbCateld,CvbActive")] CvbProduct cvbProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cvbProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cvbProduct);
        }

        // GET: CvbProducts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbProduct cvbProduct = db.CvbProducts.Find(id);
            if (cvbProduct == null)
            {
                return HttpNotFound();
            }
            return View(cvbProduct);
        }

        // POST: CvbProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CvbProduct cvbProduct = db.CvbProducts.Find(id);
            db.CvbProducts.Remove(cvbProduct);
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
