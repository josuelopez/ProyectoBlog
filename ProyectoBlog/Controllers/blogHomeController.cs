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
    public class blogHomeController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /blogHome/

        public ActionResult Index()
        {
            return View(db.blogHome.ToList());
        }

        //
        // GET: /blogHome/Details/5

        public ActionResult Details(int id = 0)
        {
            blogHome bloghome = db.blogHome.Find(id);
            if (bloghome == null)
            {
                return HttpNotFound();
            }
            return View(bloghome);
        }

        //
        // GET: /blogHome/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /blogHome/Create

        [HttpPost]
        public ActionResult Create(blogHome bloghome)
        {
            if (ModelState.IsValid)
            {
                db.blogHome.Add(bloghome);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloghome);
        }

        //
        // GET: /blogHome/Edit/5

        public ActionResult Edit(int id = 0)
        {
            blogHome bloghome = db.blogHome.Find(id);
            if (bloghome == null)
            {
                return HttpNotFound();
            }
            return View(bloghome);
        }

        //
        // POST: /blogHome/Edit/5

        [HttpPost]
        public ActionResult Edit(blogHome bloghome)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloghome).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloghome);
        }

        //
        // GET: /blogHome/Delete/5

        public ActionResult Delete(int id = 0)
        {
            blogHome bloghome = db.blogHome.Find(id);
            if (bloghome == null)
            {
                return HttpNotFound();
            }
            return View(bloghome);
        }

        //
        // POST: /blogHome/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            blogHome bloghome = db.blogHome.Find(id);
            db.blogHome.Remove(bloghome);
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