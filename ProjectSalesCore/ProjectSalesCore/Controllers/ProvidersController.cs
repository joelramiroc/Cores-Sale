using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CSales.Database.Contexts;
using CSales.Database.Models;

namespace ProjectSalesCore.Controllers
{
    public class ProvidersController : Controller
    {
        private MyContext db = new MyContext();

        // GET: Providers
        public ActionResult Index()
        {
            var provider = db.Provider.Include(p => p.BusinessName);
            return View(provider.ToList());
        }

        // GET: Providers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Provider.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // GET: Providers/Create
        public ActionResult Create()
        {
            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name");
            return View();
        }

        // POST: Providers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,IsActive,Contact,IsForeignProvider,IdBusinessName,CreatedDate")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                db.Provider.Add(provider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(provider);
        }

        // GET: Providers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Provider.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(provider);
        }

        // POST: Providers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,IsActive,Contact,IsForeignProvider,IdBusinessName,CreatedDate")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(provider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(provider);
        }

        // GET: Providers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Provider.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // POST: Providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Provider provider = db.Provider.Find(id);
            db.Provider.Remove(provider);
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
