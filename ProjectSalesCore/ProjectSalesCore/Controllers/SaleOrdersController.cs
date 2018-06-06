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
    public class SaleOrdersController : Controller
    {
        private MyContext db = new MyContext();

        // GET: SaleOrders
        public ActionResult Index()
        {
            var saleOrder = db.SaleOrder.Include(s => s.Client).Include(s => s.Employee).Include(s => s.PaymentCondition);
            return View(saleOrder.ToList());
        }

        // GET: SaleOrders/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleOrder saleOrder = db.SaleOrder.Find(id);
            if (saleOrder == null)
            {
                return HttpNotFound();
            }
            return View(saleOrder);
        }

        // GET: SaleOrders/Create
        public ActionResult Create()
        {
            ViewBag.IdClient = new SelectList(db.Client, "Id", "Name");
            ViewBag.IdEmployee = new SelectList(db.Employee, "Id", "Name");
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName");
            return View();
        }

        // POST: SaleOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdSaleOrder,CreatedDate,IdClient,IdEmployee,IdPaymentCondition")] SaleOrder saleOrder)
        {
            if (ModelState.IsValid)
            {
                db.SaleOrder.Add(saleOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdClient = new SelectList(db.Client, "Id", "Name", saleOrder.IdClient);
            ViewBag.IdEmployee = new SelectList(db.Employee, "Id", "Name", saleOrder.IdEmployee);
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName", saleOrder.IdPaymentCondition);
            return View(saleOrder);
        }

        // GET: SaleOrders/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleOrder saleOrder = db.SaleOrder.Find(id);
            if (saleOrder == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdClient = new SelectList(db.Client, "Id", "Name", saleOrder.IdClient);
            ViewBag.IdEmployee = new SelectList(db.Employee, "Id", "Name", saleOrder.IdEmployee);
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName", saleOrder.IdPaymentCondition);
            return View(saleOrder);
        }

        // POST: SaleOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdSaleOrder,CreatedDate,IdClient,IdEmployee,IdPaymentCondition")] SaleOrder saleOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(saleOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdClient = new SelectList(db.Client, "Id", "Name", saleOrder.IdClient);
            ViewBag.IdEmployee = new SelectList(db.Employee, "Id", "Name", saleOrder.IdEmployee);
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName", saleOrder.IdPaymentCondition);
            return View(saleOrder);
        }

        // GET: SaleOrders/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SaleOrder saleOrder = db.SaleOrder.Find(id);
            if (saleOrder == null)
            {
                return HttpNotFound();
            }
            return View(saleOrder);
        }

        // POST: SaleOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            SaleOrder saleOrder = db.SaleOrder.Find(id);
            db.SaleOrder.Remove(saleOrder);
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
