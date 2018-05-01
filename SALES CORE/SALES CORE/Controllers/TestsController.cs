using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.DataBase.Context;
using WebSite.DataBase.Model;
using WebSite.DataBase.Repository;

namespace SALES_CORE.Controllers
{
    public class TestsController : Controller
    {
        private readonly IRepository<Tests> Testsrepository;
       
        TestsContext db = new TestsContext();

        public TestsController(IRepository<Tests> Testsrepository)
        {
            this.Testsrepository = Testsrepository;
        }
        
        // GET: Tests
        public ActionResult Index()
        {
            var result = this.Testsrepository.Transform(s => new Tests
            {
                Id = s.Id,
                Name = s.Name
            }).ToList();

            return View(result);
        }

        // GET: Tests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tests/Create
        [HttpPost]
        public ActionResult Create(Tests model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    this.db.Tests.Add(model);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tests/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Tests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tests/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
