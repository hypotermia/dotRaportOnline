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
    public class SUB_ASPEKController : Controller
    {
        private OnlineRaporEntities db = new OnlineRaporEntities();

        // GET: SUB_ASPEK
        public ActionResult Index()
        {
            var sUB_ASPEK = db.SUB_ASPEK.Include(s => s.ASPEK);
            return View(sUB_ASPEK.ToList());
        }

        // GET: SUB_ASPEK/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUB_ASPEK sUB_ASPEK = db.SUB_ASPEK.Find(id);
            if (sUB_ASPEK == null)
            {
                return HttpNotFound();
            }
            return View(sUB_ASPEK);
        }

        // GET: SUB_ASPEK/Create
        public ActionResult Create()
        {
            ViewBag.ID_ASPEK = new SelectList(db.ASPEK, "ID_ASPEK", "NAMA_ASPEK");
            return View();
        }

        // POST: SUB_ASPEK/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_SUB,ID_ASPEK,NAMA_SUBASPEK,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] SUB_ASPEK sUB_ASPEK)
        {
            if (ModelState.IsValid)
            {
                db.SUB_ASPEK.Add(sUB_ASPEK);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ASPEK = new SelectList(db.ASPEK, "ID_ASPEK", "NAMA_ASPEK", sUB_ASPEK.ID_ASPEK);
            return View(sUB_ASPEK);
        }

        // GET: SUB_ASPEK/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUB_ASPEK sUB_ASPEK = db.SUB_ASPEK.Find(id);
            if (sUB_ASPEK == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ASPEK = new SelectList(db.ASPEK, "ID_ASPEK", "NAMA_ASPEK", sUB_ASPEK.ID_ASPEK);
            return View(sUB_ASPEK);
        }

        // POST: SUB_ASPEK/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_SUB,ID_ASPEK,NAMA_SUBASPEK,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] SUB_ASPEK sUB_ASPEK)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sUB_ASPEK).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ASPEK = new SelectList(db.ASPEK, "ID_ASPEK", "NAMA_ASPEK", sUB_ASPEK.ID_ASPEK);
            return View(sUB_ASPEK);
        }

        // GET: SUB_ASPEK/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SUB_ASPEK sUB_ASPEK = db.SUB_ASPEK.Find(id);
            if (sUB_ASPEK == null)
            {
                return HttpNotFound();
            }
            return View(sUB_ASPEK);
        }

        // POST: SUB_ASPEK/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SUB_ASPEK sUB_ASPEK = db.SUB_ASPEK.Find(id);
            db.SUB_ASPEK.Remove(sUB_ASPEK);
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
