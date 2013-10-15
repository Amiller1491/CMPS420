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
    public class TeacherController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        //
        // GET: /Teacher/

        public ActionResult Index()
        {
            return View(db.Teacher.ToList());
        }

        //
        // GET: /Teacher/Details/5

        public ActionResult Details(int id = 0)
        {
            TeacherModel teachermodel = db.Teacher.Find(id);
            if (teachermodel == null)
            {
                return HttpNotFound();
            }
            return View(teachermodel);
        }

        //
        // GET: /Teacher/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Teacher/Create
        [Authorize(Roles = "Head")]
        [HttpPost]
        public ActionResult Create(TeacherModel teachermodel)
        {
            if (ModelState.IsValid)
            {
                db.Teacher.Add(teachermodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teachermodel);
        }

        //
        // GET: /Teacher/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TeacherModel teachermodel = db.Teacher.Find(id);
            if (teachermodel == null)
            {
                return HttpNotFound();
            }
            return View(teachermodel);
        }

        //
        // POST: /Teacher/Edit/5
        [Authorize(Roles = "Head")]
        [HttpPost]
        public ActionResult Edit(TeacherModel teachermodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teachermodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teachermodel);
        }

        //
        // GET: /Teacher/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TeacherModel teachermodel = db.Teacher.Find(id);
            if (teachermodel == null)
            {
                return HttpNotFound();
            }
            return View(teachermodel);
        }

        //
        // POST: /Teacher/Delete/5
        [Authorize(Roles = "Head")]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TeacherModel teachermodel = db.Teacher.Find(id);
            db.Teacher.Remove(teachermodel);
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