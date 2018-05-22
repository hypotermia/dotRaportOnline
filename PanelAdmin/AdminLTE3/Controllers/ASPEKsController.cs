using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminLTE3.Models;

namespace AdminLTE3
{
    public class ASPEKsController : Controller
    {
        private OnlineRaporEntities db = new OnlineRaporEntities();

        // GET: ASPEKs
        public ActionResult Index()
        {
            return View(db.ASPEK.ToList());
        }

        // GET: ASPEKs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASPEK aSPEK = db.ASPEK.Find(id);
            if (aSPEK == null)
            {
                return HttpNotFound();
            }
            return View(aSPEK);
        }

        // GET: ASPEKs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ASPEKs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_ASPEK,NAMA_ASPEK,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] ASPEK aSPEK)
        {
            if (ModelState.IsValid)
            {
                db.ASPEK.Add(aSPEK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aSPEK);
        }

        // GET: ASPEKs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASPEK aSPEK = db.ASPEK.Find(id);
            if (aSPEK == null)
            {
                return HttpNotFound();
            }
            return View(aSPEK);
        }

        // POST: ASPEKs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_ASPEK,NAMA_ASPEK,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] ASPEK aSPEK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aSPEK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aSPEK);
        }

        // GET: ASPEKs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ASPEK aSPEK = db.ASPEK.Find(id);
            if (aSPEK == null)
            {
                return HttpNotFound();
            }
            return View(aSPEK);
        }

        // POST: ASPEKs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ASPEK aSPEK = db.ASPEK.Find(id);
            db.ASPEK.Remove(aSPEK);
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
