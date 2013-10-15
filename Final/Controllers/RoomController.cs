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
    public class RoomController : Controller
    {
        private ScheduleContext db = new ScheduleContext();

        //
        // GET: /Room/

        public ActionResult Index()
        {
            return View(db.Room.ToList());
        }

        //
        // GET: /Room/Details/5

        public ActionResult Details(int id = 0)
        {
            RoomModel roommodel = db.Room.Find(id);
            if (roommodel == null)
            {
                return HttpNotFound();
            }
            return View(roommodel);
        }

        //
        // GET: /Room/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Room/Create

        [HttpPost]
        public ActionResult Create(RoomModel roommodel)
        {
            if (ModelState.IsValid)
            {
                db.Room.Add(roommodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roommodel);
        }

        //
        // GET: /Room/Edit/5

        public ActionResult Edit(int id = 0)
        {
            RoomModel roommodel = db.Room.Find(id);
            if (roommodel == null)
            {
                return HttpNotFound();
            }
            return View(roommodel);
        }

        //
        // POST: /Room/Edit/5

        [HttpPost]
        public ActionResult Edit(RoomModel roommodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roommodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roommodel);
        }

        //
        // GET: /Room/Delete/5

        public ActionResult Delete(int id = 0)
        {
            RoomModel roommodel = db.Room.Find(id);
            if (roommodel == null)
            {
                return HttpNotFound();
            }
            return View(roommodel);
        }

        //
        // POST: /Room/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            RoomModel roommodel = db.Room.Find(id);
            db.Room.Remove(roommodel);
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