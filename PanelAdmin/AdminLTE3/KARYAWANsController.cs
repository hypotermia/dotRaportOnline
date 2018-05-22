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
    public class KARYAWANsController : Controller
    {
        private OnlineRaporEntities db = new OnlineRaporEntities();

        // GET: KARYAWANs
        public ActionResult Index()
        {
            var kARYAWAN = db.KARYAWAN.Include(k => k.DEPARTEMEN1).Include(k => k.JABATAN);
            return View(kARYAWAN.ToList());
        }

        // GET: KARYAWANs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KARYAWAN kARYAWAN = db.KARYAWAN.Find(id);
            if (kARYAWAN == null)
            {
                return HttpNotFound();
            }
            return View(kARYAWAN);
        }

        // GET: KARYAWANs/Create
        public ActionResult Create()
        {
            ViewBag.ID_DEPARTEMEN = new SelectList(db.DEPARTEMEN, "ID_DEPARTEMEN", "NAMA_DEPARTEMEN");
            ViewBag.ID_JABATAN = new SelectList(db.JABATAN, "ID_JABATAN", "NAMA_JABATAN");
            return View();
        }

        // POST: KARYAWANs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_KARYAWAN,ID_DEPARTEMEN,ID_JABATAN,NO_KTP,NAMA_LENGKAP,JENIS_KELAMIN,TEMPAT_LAHIR,TANGGAL_LAHIR,AGAMA,STATUS_PERKAWINAN,KEWARGANEGARAAN,PENDIDIKAN,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] KARYAWAN kARYAWAN)
        {
            if (ModelState.IsValid)
            {
                db.KARYAWAN.Add(kARYAWAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_DEPARTEMEN = new SelectList(db.DEPARTEMEN, "ID_DEPARTEMEN", "NAMA_DEPARTEMEN", kARYAWAN.ID_DEPARTEMEN);
            ViewBag.ID_JABATAN = new SelectList(db.JABATAN, "ID_JABATAN", "NAMA_JABATAN", kARYAWAN.ID_JABATAN);
            return View(kARYAWAN);
        }

        // GET: KARYAWANs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KARYAWAN kARYAWAN = db.KARYAWAN.Find(id);
            if (kARYAWAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_DEPARTEMEN = new SelectList(db.DEPARTEMEN, "ID_DEPARTEMEN", "NAMA_DEPARTEMEN", kARYAWAN.ID_DEPARTEMEN);
            ViewBag.ID_JABATAN = new SelectList(db.JABATAN, "ID_JABATAN", "NAMA_JABATAN", kARYAWAN.ID_JABATAN);
            return View(kARYAWAN);
        }

        // POST: KARYAWANs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_KARYAWAN,ID_DEPARTEMEN,ID_JABATAN,NO_KTP,NAMA_LENGKAP,JENIS_KELAMIN,TEMPAT_LAHIR,TANGGAL_LAHIR,AGAMA,STATUS_PERKAWINAN,KEWARGANEGARAAN,PENDIDIKAN,DIBUAT_OLEH,DIBUAT_PADA,DIUBAH_OLEH,DIUBAH_PADA,STATUS_AKTIF")] KARYAWAN kARYAWAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kARYAWAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_DEPARTEMEN = new SelectList(db.DEPARTEMEN, "ID_DEPARTEMEN", "NAMA_DEPARTEMEN", kARYAWAN.ID_DEPARTEMEN);
            ViewBag.ID_JABATAN = new SelectList(db.JABATAN, "ID_JABATAN", "NAMA_JABATAN", kARYAWAN.ID_JABATAN);
            return View(kARYAWAN);
        }

        // GET: KARYAWANs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KARYAWAN kARYAWAN = db.KARYAWAN.Find(id);
            if (kARYAWAN == null)
            {
                return HttpNotFound();
            }
            return View(kARYAWAN);
        }

        // POST: KARYAWANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            KARYAWAN kARYAWAN = db.KARYAWAN.Find(id);
            db.KARYAWAN.Remove(kARYAWAN);
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
