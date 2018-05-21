using CSales.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CSales.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(this.Add())
            {
                using (var context = new MyContext())
                {
                }
            }

            return View();
        }

        public bool Add()
        {
            Database.SetInitializer<MyContext>(null);
            using (var ctx = new MyContext())
            {
                ctx.Test.Add(new Contexts.Test {Key = 1, Name = "Hoa" });
                ctx.SaveChanges();
            }

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