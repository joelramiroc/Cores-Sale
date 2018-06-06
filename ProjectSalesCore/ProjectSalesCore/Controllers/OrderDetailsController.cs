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
    public class OrderDetailsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: OrderDetails
        public ActionResult Index()
        {
            var orderDetail = db.OrderDetail.Include(o => o.ExternalProduct).Include(o => o.SaleOrder);
            return View(orderDetail.ToList());
        }

        // GET: OrderDetails/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // GET: OrderDetails/Create
        public ActionResult Create()
        {
            ViewBag.IdExternalProduct = new SelectList(db.ExternalProduct, "IdExternalProduct", "ProductDescription");
            ViewBag.IdSaleOrder = new SelectList(db.SaleOrder, "IdSaleOrder", "IdSaleOrder");
            return View();
        }

        // POST: OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdExternalProduct,IdSaleOrder,Quantity,UnitPrice,DiscountRate,Total")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                db.OrderDetail.Add(orderDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdExternalProduct = new SelectList(db.ExternalProduct, "IdExternalProduct", "ProductDescription", orderDetail.IdExternalProduct);
            ViewBag.IdSaleOrder = new SelectList(db.SaleOrder, "IdSaleOrder", "IdSaleOrder", orderDetail.IdSaleOrder);
            return View(orderDetail);
        }

        // GET: OrderDetails/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdExternalProduct = new SelectList(db.ExternalProduct, "IdExternalProduct", "ProductDescription", orderDetail.IdExternalProduct);
            ViewBag.IdSaleOrder = new SelectList(db.SaleOrder, "IdSaleOrder", "IdSaleOrder", orderDetail.IdSaleOrder);
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdExternalProduct,IdSaleOrder,Quantity,UnitPrice,DiscountRate,Total")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdExternalProduct = new SelectList(db.ExternalProduct, "IdExternalProduct", "ProductDescription", orderDetail.IdExternalProduct);
            ViewBag.IdSaleOrder = new SelectList(db.SaleOrder, "IdSaleOrder", "IdSaleOrder", orderDetail.IdSaleOrder);
            return View(orderDetail);
        }

        // GET: OrderDetails/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetail orderDetail = db.OrderDetail.Find(id);
            if (orderDetail == null)
            {
                return HttpNotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            OrderDetail orderDetail = db.OrderDetail.Find(id);
            db.OrderDetail.Remove(orderDetail);
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
