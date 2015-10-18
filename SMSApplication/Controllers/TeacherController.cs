using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SMSApplication.Models;

namespace SMSApplication.Controllers
{
    public class TeacherController : Controller
    {
        private DBHandle db = new DBHandle();

        // GET: /Teacher/
        public ActionResult Index()
        {
            var teachers = db.Teachers.Include(t => t.Department).Include(t => t.Designation);
            return View(teachers.ToList());
        }

        // GET: /Teacher/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // GET: /Teacher/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmentCode");
            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "DesignationName");
            return View();
        }

        // POST: /Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="TeacherId,TeacherName,TeacherAddress,TeacherEmail,ContactNumber,DesignationId,DepartmentId,Credit")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(teacher);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmentCode", teacher.DepartmentId);
            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "DesignationName", teacher.DesignationId);
            return View(teacher);
        }

        // GET: /Teacher/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmentCode", teacher.DepartmentId);
            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "DesignationName", teacher.DesignationId);
            return View(teacher);
        }

        // POST: /Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="TeacherId,TeacherName,TeacherAddress,TeacherEmail,ContactNumber,DesignationId,DepartmentId,Credit")] Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teacher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DepartmentCode", teacher.DepartmentId);
            ViewBag.DesignationId = new SelectList(db.Designations, "DesignationId", "DesignationName", teacher.DesignationId);
            return View(teacher);
        }

        // GET: /Teacher/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teacher teacher = db.Teachers.Find(id);
            if (teacher == null)
            {
                return HttpNotFound();
            }
            return View(teacher);
        }

        // POST: /Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Teacher teacher = db.Teachers.Find(id);
            db.Teachers.Remove(teacher);
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

        public JsonResult CheckExistTeacherEmail(string teacheremail)
        {
            var aTeacher = db.Teachers.FirstOrDefault(x => x.TeacherEmail == teacheremail);
            if (aTeacher != null)
            {
                return Json("Teacher Email Allready Exits!", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
