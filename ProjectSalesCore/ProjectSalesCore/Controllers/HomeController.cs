namespace ProjectSalesCore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CSales.Database.Contexts;
    using CSales.Database.Models;
    using CSales.Database.Repositories;

    public class HomeController : Controller
    {
        private readonly IRepository<Bank> bak;

        public HomeController(IRepository<Bank> bak)
        {
            this.bak = bak;
        }

        public ActionResult Index()
        {
            Bank bank;

            bank = new Bank
            {
                IdBank = this.bak.All().Count(),
                BankName = "Banco prueba",
                Description = "Este es el banco de pruebas",
            };

            this.bak.Create(bank);
            this.bak.SaveChangesAsync();

            var list = this.bak.All();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}