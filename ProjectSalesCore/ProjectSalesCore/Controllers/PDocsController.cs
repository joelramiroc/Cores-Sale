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
    public class PDocsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: PDocs
        public ActionResult Index()
        {
            var purchaseDocument = db.PurchaseDocument.Include(p => p.CurrentAccountDocumentType).Include(p => p.Provider).Include(p => p.PurchaseOrder);
            return View(purchaseDocument.ToList());
        }

        // GET: PDocs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PDoc pDoc = db.PurchaseDocument.Find(id);
            if (pDoc == null)
            {
                return HttpNotFound();
            }
            return View(pDoc);
        }

        // GET: PDocs/Create
        public ActionResult Create()
        {
            ViewBag.IdCurrentAccountDocumentType = new SelectList(db.CurrentAccountDocumentType, "IdCurrentAccountDocumentType", "TypeName");
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name");
            ViewBag.NumberPurchaseOrder = new SelectList(db.PurchaseOrder, "PurchaseNumber", "PlaceOfEntry");
            return View();
        }

        // POST: PDocs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdProvider,IdCurrentAccountDocumentType,NumberPurchaseOrder,CreatedDate,TotalAmount")] PDoc pDoc)
        {
            if (ModelState.IsValid)
            {
                db.PurchaseDocument.Add(pDoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCurrentAccountDocumentType = new SelectList(db.CurrentAccountDocumentType, "IdCurrentAccountDocumentType", "TypeName", pDoc.IdCurrentAccountDocumentType);
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pDoc.IdProvider);
            ViewBag.NumberPurchaseOrder = new SelectList(db.PurchaseOrder, "PurchaseNumber", "PlaceOfEntry", pDoc.NumberPurchaseOrder);
            return View(pDoc);
        }

        // GET: PDocs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PDoc pDoc = db.PurchaseDocument.Find(id);
            if (pDoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCurrentAccountDocumentType = new SelectList(db.CurrentAccountDocumentType, "IdCurrentAccountDocumentType", "TypeName", pDoc.IdCurrentAccountDocumentType);
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pDoc.IdProvider);
            ViewBag.NumberPurchaseOrder = new SelectList(db.PurchaseOrder, "PurchaseNumber", "PlaceOfEntry", pDoc.NumberPurchaseOrder);
            return View(pDoc);
        }

        // POST: PDocs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdProvider,IdCurrentAccountDocumentType,NumberPurchaseOrder,CreatedDate,TotalAmount")] PDoc pDoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pDoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCurrentAccountDocumentType = new SelectList(db.CurrentAccountDocumentType, "IdCurrentAccountDocumentType", "TypeName", pDoc.IdCurrentAccountDocumentType);
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pDoc.IdProvider);
            ViewBag.NumberPurchaseOrder = new SelectList(db.PurchaseOrder, "PurchaseNumber", "PlaceOfEntry", pDoc.NumberPurchaseOrder);
            return View(pDoc);
        }

        // GET: PDocs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PDoc pDoc = db.PurchaseDocument.Find(id);
            if (pDoc == null)
            {
                return HttpNotFound();
            }
            return View(pDoc);
        }

        // POST: PDocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PDoc pDoc = db.PurchaseDocument.Find(id);
            db.PurchaseDocument.Remove(pDoc);
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
