// <copyright file="BanksController.cs" company="PlaceholderCompany">
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
    using ProjectSalesCore.ViewModel;

    public class BanksController : Controller
    {

        private MyContext db = new MyContext();

        // GET: Banks
        public ActionResult Index()
        {
            return View(this.db.Bank.ToList());
        }

        // GET: Banks/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)

            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bank bank = db.Bank.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }

              var listTelephone = bank.Telephones.Select(t => new CSales.Models.Telephone { Number = t.Number, Description = t.Description, Id = t.Id });
              var listAddresses = bank.Addresses.Select(la => new CSales.Models.Address { Id = la.Id,AddressName =la.AddressName, Description = la.Description});

            BankDetailViewModel bankDetailViewModel = new BankDetailViewModel
            {
                IdBank = bank.IdBank,
                Addresses = listAddresses,
                BankName = bank.BankName,
                Description = bank.Description,
                Telephones = listTelephone
            };
            return View(bankDetailViewModel);
        }

        // GET: Banks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Banks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdBank,BankName,Description")] Bank bank)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Bank.Add(bank);
                this.db.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return View(bank);
        }

        // GET: Banks/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bank bank = db.Bank.Find(id);
            if (bank == null)
            {
                return HttpNotFound();
            }

            return View(bank);
        }

        // POST: Banks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdBank,BankName,Description")] Bank bank)
        {
            if (this.ModelState.IsValid)
            {
                this.db.Entry(bank).State = EntityState.Modified;
                this.db.SaveChanges();
                return this.RedirectToAction("Index");
            }

            return this.View(bank);
        }

        // GET: Banks/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Bank bank = this.db.Bank.Find(id);
            if (bank == null)
            {
                return this.HttpNotFound();
            }

            return this.View(bank);
        }

        // POST: Banks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Bank bank = this.db.Bank.Find(id);
            var telephones = bank.Telephones.ToList();
            for (int i = 0; i < telephones.Count; i++)
            {
                this.db.Telephone.Remove(telephones[i]);
                this.db.SaveChanges();
            }

            var addresses = bank.Addresses.ToList();
            for (int i = 0; i < addresses.Count; i++)
            {
                this.db.Address.Remove(addresses[i]);
                this.db.SaveChanges();
            }

            this.db.Bank.Remove(bank);
            this.db.SaveChanges();
            return this.RedirectToAction("Index");
            }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
