﻿// <copyright file="POrdersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.Controllers
{
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
    using ProjectSalesCore.DataBase.Models;
    using ProjectSalesCore.ViewModel.PurchaseOrder;

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
            var list = this.db.OrderDetailsCompras.Where(od => od.PurchaseNumber == pOrder.PurchaseNumber).ToList();

            var nList = new List<DetailsOrderDetailViewModel>();
            decimal total = 0;
            foreach (var item in list)
            {
                var nE = new DetailsOrderDetailViewModel();
                nE.Discount = item.Discount.Value;
                var pN = this.db.Product.Find(item.IdProduct);
                nE.ProductName = pN.ProductName;
                nE.Quantity = item.Quantity;
                nE.TotalAmount = item.TotalAmount;
                nE.UnitPrice = item.UnitPrice;
                total += item.TotalAmount;
                nList.Add(nE);
            }

            var Show = new POrderDetail
            {
                DetailsOrderDetailViewModels = nList,
                PurchaseNumber = pOrder.PurchaseNumber,
                PaymentCondition = this.db.PaymentCondition.Find(pOrder.IdPaymentCondition).ConditionName,
                ProviderName = this.db.Provider.Find(pOrder.IdProvider).Name,
                CreatedDate = pOrder.CreatedDate,
                PlaceOfEntry = pOrder.PlaceOfEntry,
                TotalAmount = total,
                StatusOrder = this.db.StatusOrder.Find(pOrder.IdStatusOrder).StatusName
            };

            if (pOrder == null)
            {
                return HttpNotFound();
            }
            return View(Show);
        }

        // GET: POrders/Create
        public ActionResult Create()
        {
            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name");
            ViewBag.IdStatusOrder = new SelectList(db.StatusOrder, "IdStatusOrder", "StatusName");
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName");

            var t = new CreatePurchaseOrderViewModel();
            t.Products = this.db.Product;
            t.OrderDetailsCompras = new List<OrderDetailsComprasViewModel>();
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
                    PlaceOfEntry = pOrder.PlaceOfEntry,
                    IdPaymentCondition = pOrder.IdPaymentCondition,
                    IdStatusOrder = pOrder.IdStatusOrder
                };
                var ordenG = db.PurchaseOrder.Add(pnew);
                db.SaveChanges();

                foreach (var item in pOrder.OrderDetailsCompras)
                {
                    var n = new OrderDetailsCompras
                    {
                        Discount = item.Discount,
                        IdProduct = item.IdProduct,
                        UnitPrice = item.UnitPrice,
                        PurchaseNumber = ordenG.PurchaseNumber,
                        Quantity = item.Quantity,
                        TotalAmount = (item.UnitPrice * item.Quantity) * (item.Discount / 100)
                    };
                    this.db.OrderDetailsCompras.Add(n);
                    this.db.SaveChanges();
                }

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
            if(pOrder.StatusOrder.IdStatusOrder ==2)
            {
                return View("Index");
            }

            ViewBag.IdProvider = new SelectList(db.Provider, "Id", "Name", pOrder.IdProvider);
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName");
            ViewBag.IdStatusOrder = new SelectList(db.StatusOrder, "IdStatusOrder", "StatusName");
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
            ViewBag.IdPaymentCondition = new SelectList(db.PaymentCondition, "IdPaymentCondition", "ConditionName");
            ViewBag.IdStatusOrder = new SelectList(db.StatusOrder, "IdStatusOrder", "StatusName");
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
