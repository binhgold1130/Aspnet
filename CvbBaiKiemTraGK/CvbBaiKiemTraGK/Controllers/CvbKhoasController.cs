using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CvbBaiKiemTraGK.Models;

namespace CvbBaiKiemTraGK.Controllers
{
    public class CvbKhoasController : Controller
    {
        private CvbK22CNT4Lesson07dbEntities db = new CvbK22CNT4Lesson07dbEntities();

        // GET: CvbKhoas
        public ActionResult CvbIndex()
        {
            return View(db.cvbKhoa.ToList());
        }

        // GET: CvbKhoas/Details/5
        public ActionResult CvbDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cvbKhoa cvbKhoa = db.cvbKhoa.Find(id);
            if (cvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(cvbKhoa);
        }

        // GET: CvbKhoas/Create
        public ActionResult CvbCreate()
        {
            return View();
        }

        // POST: CvbKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CvbCreate([Bind(Include = "CvbMaKH,CvbTenKH,CvbTrangThai")] cvbKhoa cvbKhoa)
        {
            if (ModelState.IsValid)
            {
                db.cvbKhoa.Add(cvbKhoa);
                db.SaveChanges();
                return RedirectToAction("CvbIndex");
            }

            return View(cvbKhoa);
        }

        // GET: CvbKhoas/Edit/5
        public ActionResult CvbEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cvbKhoa cvbKhoa = db.cvbKhoa.Find(id);
            if (cvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(cvbKhoa);
        }

        // POST: CvbKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CvbEdit([Bind(Include = "CvbMaKH,CvbTenKH,CvbTrangThai")] cvbKhoa cvbKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cvbKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("CvbIndex");
            }
            return View(cvbKhoa);
        }

        // GET: CvbKhoas/Delete/5
        public ActionResult CvbDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cvbKhoa cvbKhoa = db.cvbKhoa.Find(id);
            if (cvbKhoa == null)
            {
                return HttpNotFound();
            }
            return View(cvbKhoa);
        }

        // POST: CvbKhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            cvbKhoa cvbKhoa = db.cvbKhoa.Find(id);
            db.cvbKhoa.Remove(cvbKhoa);
            db.SaveChanges();
            return RedirectToAction("CvbIndex");
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
