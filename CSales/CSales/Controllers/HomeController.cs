// <copyright file="HomeController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSales.Controllers
{
    using Database.Models;
    using Database.Repositories;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private readonly IRepository<Provider> providerRepository;

        public HomeController(IRepository<Provider> providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        public ActionResult Index()
        {
            var c = this.providerRepository.All();
            return this.View();
        }

        public bool Add()
        {

            return true;
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