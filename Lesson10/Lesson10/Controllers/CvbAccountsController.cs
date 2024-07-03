using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lesson10.Models;

namespace Lesson10.Controllers
{
    public class CvbAccountsController : Controller
    {
        private CvbLesson10Entities db = new CvbLesson10Entities();

        // GET: CvbAccounts
        public ActionResult Index()
        {
            return View(db.CvbAccount.ToList());
        }

        // GET: CvbAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbAccount cvbAccount = db.CvbAccount.Find(id);
            if (cvbAccount == null)
            {
                return HttpNotFound();
            }
            return View(cvbAccount);
        }

        // GET: CvbAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CvbAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CvbID,CvbUseName,CvbPassword,CvbFullName,CvbEmail,CvbPhone,CvbAcive")] CvbAccount cvbAccount)
        {
            if (ModelState.IsValid)
            {
                db.CvbAccount.Add(cvbAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cvbAccount);
        }

        // GET: CvbAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbAccount cvbAccount = db.CvbAccount.Find(id);
            if (cvbAccount == null)
            {
                return HttpNotFound();
            }
            return View(cvbAccount);
        }

        // POST: CvbAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CvbID,CvbUseName,CvbPassword,CvbFullName,CvbEmail,CvbPhone,CvbAcive")] CvbAccount cvbAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cvbAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cvbAccount);
        }

        // GET: CvbAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CvbAccount cvbAccount = db.CvbAccount.Find(id);
            if (cvbAccount == null)
            {
                return HttpNotFound();
            }
            return View(cvbAccount);
        }

        // POST: CvbAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CvbAccount cvbAccount = db.CvbAccount.Find(id);
            db.CvbAccount.Remove(cvbAccount);
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

        // Login
        public ActionResult CvbLogin() 
        {
            var cvbModel = new CvbAccount();
            return View(cvbModel);
        }
        [HttpPost]
        public ActionResult CvbLogin(CvbAccount cvbAccount)
        {
            var cvbCheck = db.CvbAccount.Where(x => x.CvbUseName.Equals(cvbAccount.CvbUseName) && x.CvbPassword.Equals(cvbAccount.CvbPassword)).FirstOrDefault();
            if(cvbCheck !=null)
            {
                // Lưu session
                Session["CvbAccount"] = cvbCheck;
                return Redirect("/");
            }
            return View(cvbAccount);
        }
    }
}
