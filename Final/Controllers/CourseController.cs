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
    public class CourseController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        //
        // GET: /Course/

        public ActionResult Index()
        {
            return View(db.Course.ToList());
        }

        //
        // GET: /Course/Details/5

        public ActionResult Details(int id = 0)
        {
            CourseModel coursemodel = db.Course.Find(id);
            if (coursemodel == null)
            {
                return HttpNotFound();
            }
            return View(coursemodel);
        }

        //
        // GET: /Course/Create

        public ActionResult Create()
        {
            ViewBag.MeetingPatternID = new SelectList(db.Course, "MeetingPatternID", "Name");
            return View();
        }

        //
        // POST: /Course/Create

        [HttpPost]
        public ActionResult Create(CourseModel coursemodel)
        {
            if (ModelState.IsValid)
            {
                db.Course.Add(coursemodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MeetingPatternID = new SelectList(db.Course, "MeetingPatternID", "Name", coursemodel.MeetingPatternID);
            //ViewBag.MeetingPatternID = new SelectList(db.Course, "MeetingPatternID", "Name", coursemodel.MeetingPatternModel.MeetingPatternID);
            return View(coursemodel);
        }

        //
        // GET: /Course/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CourseModel coursemodel = db.Course.Find(id);
            if (coursemodel == null)
            {
                return HttpNotFound();
            }
            return View(coursemodel);
        }

        //
        // POST: /Course/Edit/5

        [HttpPost]
        public ActionResult Edit(CourseModel coursemodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coursemodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coursemodel);
        }

        //
        // GET: /Course/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CourseModel coursemodel = db.Course.Find(id);
            if (coursemodel == null)
            {
                return HttpNotFound();
            }
            return View(coursemodel);
        }

        //
        // POST: /Course/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseModel coursemodel = db.Course.Find(id);
            db.Course.Remove(coursemodel);
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