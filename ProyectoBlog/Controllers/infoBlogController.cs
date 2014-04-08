using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoBlog.Models;

namespace ProyectoBlog.Controllers
{
    public class infoBlogController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /infoBlog/

        public ActionResult Index()
        {
            return View(db.infoBlog.ToList());
        }

        //
        // GET: /infoBlog/Details/5

        public ActionResult Details(int id = 0)
        {
            infoBlog infoblog = db.infoBlog.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // GET: /infoBlog/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /infoBlog/Create

        [HttpPost]
        public ActionResult Create(infoBlog infoblog)
        {
            if (ModelState.IsValid)
            {
                db.infoBlog.Add(infoblog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infoblog);
        }

        //
        // GET: /infoBlog/Edit/5

        public ActionResult Edit(int id = 0)
        {
            infoBlog infoblog = db.infoBlog.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // POST: /infoBlog/Edit/5

        [HttpPost]
        public ActionResult Edit(infoBlog infoblog)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoblog).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infoblog);
        }

        //
        // GET: /infoBlog/Delete/5

        public ActionResult Delete(int id = 0)
        {
            infoBlog infoblog = db.infoBlog.Find(id);
            if (infoblog == null)
            {
                return HttpNotFound();
            }
            return View(infoblog);
        }

        //
        // POST: /infoBlog/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            infoBlog infoblog = db.infoBlog.Find(id);
            db.infoBlog.Remove(infoblog);
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