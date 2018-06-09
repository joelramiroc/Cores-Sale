// <copyright file="ProvidersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ProjectSalesCore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using CSales.Database.Contexts;
    using CSales.Database.Models;
    using CSales.Database.Repositories;
    using ProjectSalesCore.DataBase.Models;
    using ProjectSalesCore.ViewModel.Provider;

    public class ProvidersController : Controller
    {
//        private readonly IRepository<CSales.Database.Models.Provider> providerRepository;
        private MyContext db = new MyContext();

        public ProvidersController()//IRepository<CSales.Database.Models.Provider> providerRepository)
        {
  //          this.providerRepository = providerRepository;
        }

        // GET: Providers
        public ActionResult Index()
        {
            var test = new TestDate
            {
                DateTest = DateTime.Now
            };


            this.db.TestDate.Add(test);
            this.db.SaveChanges();

            var provider = db.Provider.Include(p => p.BusinessName);
            return View(provider.ToList());
        }

        // GET: Providers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CSales.Database.Models.Provider provider = this.db.Provider.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }

            var prov = new DetailsProviderViewModel
            {
                Addresses = this.db.AddressProvider.Where(a => a.IdPRV == provider.Id).ToList(),
                BusinessName = provider.BusinessName,
                //CitiesDistricts = this.db.CityDistrict.ToList(),
                Contact = provider.Contact,
                Id = provider.Id,
                IdBusinessName = provider.BusinessName.Id,
                IsActive = provider.IsActive,
                IsForeignProvider = provider.IsForeignProvider,
                Name = provider.Name,
                Telephones = this.db.TelephoneProvider.Where(t => t.IdPRV == provider.Id),
            };
            return View(prov);
        }

        // GET: Providers/Create
        public ActionResult Create()
        {
            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name");
            return View(new CreateProviderViewModel());
        }

        // POST: Providers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateProviderViewModel provider)
        {
            if (ModelState.IsValid)
            {
                var P = new CSales.Database.Models.Provider
                {
                    Contact = provider.Contact,
                    IsActive = provider.IsActive,
                    Name = provider.Name,
                    IsForeignProvider = provider.IsForeignProvider,
                };


                var intss = this.db.Database.ExecuteSqlCommand(@"INSERT INTO 'PROVIDER'('NAME', 'ISACTIVE', 'CONTACT', 'ISFOREIGNPROVIDER', 'BUSINESSNAME', 'CREATEDDATE') values ({0},{1},{2},{3},{4},{5})", provider.Name, provider.IsActive, provider.Contact, provider.IsForeignProvider, provider.IdBusinessName, "2008/03/03");

                for (int i = 0; i < provider.Addresses.Count(); i++)
                {
                    var a = new AddressProvider
                    {
                        AddressName = provider.Addresses.ElementAt(i),
                        Description = "DEFAULT",
                    };
                    this.db.AddressProvider.Add(a);
                    db.SaveChanges();
                }

                for (int i = 0; i < provider.Telephones.Count(); i++)
                {
                    var a = new TelephoneProvider
                    {
                        Description = "Number default",
                        Number = provider.Telephones.ElementAt(i),
                    };
                    this.db.TelephoneProvider.Add(a);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(provider);
        }

        // GET: Providers/Edit/5
        public ActionResult Edit(int? id)
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

            var p = new EditProviderViewModel
            {
                Telephones = this.db.TelephoneProvider.Where(t => t.IdPRV == provider.Id).ToList(),
                Addresses = this.db.AddressProvider.Where(a => a.IdPRV == provider.Id).ToList(),
                BusinessName = this.db.BusinessName.Find(provider.IdBusinessName),
                IdBusinessName = this.db.BusinessName.Find(provider.IdBusinessName).Id,
                Id = provider.Id,
                Contact = provider.Contact,
                IsActive = provider.IsActive,
                IsForeignProvider = provider.IsForeignProvider,
                Name = provider.Name
            };
            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(p);
        }

        // POST: Providers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,IsActive,Contact,IsForeignProvider,IdBusinessName,CreatedDate")] EditProviderViewModel provider)
        {
            if (ModelState.IsValid)
            {
                var p = new Provider
                {
                    Telephones = this.db.TelephoneProvider.Where(t => t.IdPRV == provider.Id).ToList(),
                    Addresses = this.db.AddressProvider.Where(a => a.IdPRV == provider.Id).ToList(),
                    BusinessName = this.db.BusinessName.Find(provider.IdBusinessName),
                    IdBusinessName = this.db.BusinessName.Find(provider.IdBusinessName).Id,
                    Id = provider.Id,
                    Contact = provider.Contact,
                    CreatedDate = provider.CreatedDate,
                    IsActive = provider.IsActive,
                    IsForeignProvider = provider.IsForeignProvider,
                    Name = provider.Name
                };

                db.Entry(p).State = EntityState.Modified;
                db.SaveChanges();

                for (int i = 0; i < provider.Addresses.Count(); i++)
                {
                    var a = provider.Addresses.ElementAt(i);
                    db.Entry(a).State = EntityState.Modified;
                    db.SaveChanges();
                }

                for (int i = 0; i < provider.Telephones.Count(); i++)
                {
                    var a = provider.Telephones.ElementAt(i);
                    db.Entry(a).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            ViewBag.IdBusinessName = new SelectList(db.BusinessName, "Id", "Name", provider.IdBusinessName);
            return View(provider);
        }

        // GET: Providers/Delete/5
        public ActionResult Delete(int? id)
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
        public ActionResult DeleteConfirmed(int id)
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
