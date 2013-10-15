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
    public class DepartmentController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        //
        // GET: /Department/

        public ActionResult Index()
        {
            return View(db.Department.ToList());
        }

        //
        // GET: /Department/Details/5

        public ActionResult Details(int id = 0)
        {
            DepartmentModel departmentmodel = db.Department.Find(id);
            if (departmentmodel == null)
            {
                return HttpNotFound();
            }
            return View(departmentmodel);
        }

        //
        // GET: /Department/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Department/Create

        [HttpPost]
        public ActionResult Create(DepartmentModel departmentmodel)
        {
            if (ModelState.IsValid)
            {
                db.Department.Add(departmentmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departmentmodel);
        }

        //
        // GET: /Department/Edit/5

        //public PartialViewResult Edit(int id = 0)
        public ActionResult Edit(int id = 0)
        {
            DepartmentModel departmentmodel = db.Department.Find(id);
            //if (departmentmodel == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(departmentmodel);
            //return PartialView(departmentmodel);
            return View(departmentmodel);
        }


        //
        // POST: /Department/Edit/5

        [HttpPost]
        public ActionResult Edit(DepartmentModel departmentmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departmentmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departmentmodel);
        }

        //
        // GET: /Department/Delete/5

        //public PartialViewResult Delete(int id)
        public ActionResult Delete(int id = 0)
        {
            DepartmentModel departmentmodel = db.Department.Find(id);
            //if (departmentmodel == null)
            //{
            //    return HttpNotFound();
            //}
            //return PartialView(departmentmodel);
            return View(departmentmodel);
        }

        //
        // POST: /Department/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DepartmentModel departmentmodel = db.Department.Find(id);
            db.Department.Remove(departmentmodel);
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