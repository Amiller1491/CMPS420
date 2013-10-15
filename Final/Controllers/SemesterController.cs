using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final.Models;

namespace Final.Controllers
{
    public class SemesterController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        //
        // GET: /Semester/

        public ActionResult Index()
        {
            return View(db.Semester.ToList());
        }

        //
        // GET: /Semester/Details/5

        public ActionResult Details(int id = 0)
        {
            SemesterModel semestermodel = db.Semester.Find(id);
            if (semestermodel == null)
            {
                return HttpNotFound();
            }
            return View(semestermodel);
        }

        //
        // GET: /Semester/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Semester/Create

        [HttpPost]
        public ActionResult Create(SemesterModel semestermodel)
        {
            if (ModelState.IsValid)
            {
                db.Semester.Add(semestermodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(semestermodel);
        }

        //
        // GET: /Semester/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SemesterModel semestermodel = db.Semester.Find(id);
            if (semestermodel == null)
            {
                return HttpNotFound();
            }
            return View(semestermodel);
        }

        //
        // POST: /Semester/Edit/5

        [HttpPost]
        public ActionResult Edit(SemesterModel semestermodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(semestermodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(semestermodel);
        }

        //
        // GET: /Semester/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SemesterModel semestermodel = db.Semester.Find(id);
            if (semestermodel == null)
            {
                return HttpNotFound();
            }
            return View(semestermodel);
        }

        //
        // POST: /Semester/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SemesterModel semestermodel = db.Semester.Find(id);
            db.Semester.Remove(semestermodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}