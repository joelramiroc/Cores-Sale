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
using ProjectSalesCore.ViewModel.PurchaseOrder;

namespace ProjectSalesCore.Controllers
{
    public class POrdersController : Controller
    {
        private MyContext db = new MyContext();

        // GET: POrders
        public ActionResult Index()
        {
            var purchaseOrder = db.PurchaseOrder.Include(p => p.Provider);
            return View(purchaseOrder.ToList());
        }

        // GET: POrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POrder pOrder = db.PurchaseOrder.Find(id);
            if (pOrder == null)
            {
                return HttpNotFound();
            }
            return View(pOrder);
        }

        // GET: POrders/Create
        public ActionResult Create()
        {
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name");
            var t = new CreatePurchaseOrderViewModel();

            t.Products = this.db.Product;

            var ts = new OrderDetailsComprasViewModel {
                Discount = 5,
                IdProduct = 1,
                Quantity = 4,
                UnitPrice = 100,
                Product = this.db.Product.Find(1),
            };

            var tss = new OrderDetailsComprasViewModel
            {
                Discount = 2,
                IdProduct = 0,
                Quantity = 4,
                UnitPrice = 1650,
                Product = this.db.Product.Find(0)
            };

            t.OrderDetailsCompras = new List<OrderDetailsComprasViewModel> { ts, tss };

            return this.View(t);
        }

        // POST: POrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreatePurchaseOrderViewModel pOrder)
        {
            if (ModelState.IsValid)
            {
                var pnew = new POrder
                {
                    CreatedDate = DateTime.Now,
                    IdProvider = pOrder.IdProvider,
                    PlaceOfEntry = pOrder.PlaceOfEntry
                };
                db.PurchaseOrder.Add(pnew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pOrder.IdProvider);
            return View(pOrder);
        }

        // GET: POrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POrder pOrder = db.PurchaseOrder.Find(id);
            if (pOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pOrder.IdProvider);
            return View(pOrder);
        }

        // POST: POrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PurchaseNumber,PlaceOfEntry,IdProvider,CreatedDate")] POrder pOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pOrder.IdProvider);
            return View(pOrder);
        }

        // GET: POrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            POrder pOrder = db.PurchaseOrder.Find(id);
            if (pOrder == null)
            {
                return HttpNotFound();
            }
            return View(pOrder);
        }

        // POST: POrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            POrder pOrder = db.PurchaseOrder.Find(id);
            db.PurchaseOrder.Remove(pOrder);
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

        public PartialViewResult BlankEditorRow()
        {
            return PartialView("GiftEditorRow", new OrderDetailsComprasViewModel());
        }
    }
}
