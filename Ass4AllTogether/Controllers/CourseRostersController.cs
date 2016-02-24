﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ass4AllTogether.Models;

namespace Ass4AllTogether.Controllers
{
    public class CourseRostersController : Controller
    {
        private Ass4AllTogetherContext db = new Ass4AllTogetherContext();

        // GET: CourseRosters
        public ActionResult Index()
        {
            return View(db.CourseRosters.ToList());
        }

        // GET: CourseRosters/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRoster courseRoster = db.CourseRosters.Find(id);
            if (courseRoster == null)
            {
                return HttpNotFound();
            }
            return View(courseRoster);
        }

        // GET: CourseRosters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseRosters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseRosterID,CourseName,NoOfHours")] CourseRoster courseRoster)
        {
            if (ModelState.IsValid)
            {
                db.CourseRosters.Add(courseRoster);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseRoster);
        }

        // GET: CourseRosters/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRoster courseRoster = db.CourseRosters.Find(id);
            if (courseRoster == null)
            {
                return HttpNotFound();
            }
            return View(courseRoster);
        }

        // POST: CourseRosters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseRosterID,CourseName,NoOfHours")] CourseRoster courseRoster)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseRoster).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseRoster);
        }

        // GET: CourseRosters/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRoster courseRoster = db.CourseRosters.Find(id);
            if (courseRoster == null)
            {
                return HttpNotFound();
            }
            return View(courseRoster);
        }

        // POST: CourseRosters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseRoster courseRoster = db.CourseRosters.Find(id);
            db.CourseRosters.Remove(courseRoster);
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
