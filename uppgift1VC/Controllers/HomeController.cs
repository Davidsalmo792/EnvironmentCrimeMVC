using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Infrastructure;
using uppgift1VC.Models;

namespace uppgift1VC.Controllers
{
    public class HomeController : Controller
    {

        private IErrandRepository repository;

        public HomeController(IErrandRepository repo)
        {
            repository = repo;
        }


        public ViewResult FAQ()
        {

            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Services()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Thanks()
        {
            Errand errand = HttpContext.Session.GetJson<Errand>("NewErrand");
            if (errand == null)
            {
                return View();
            }
            else
            {
                var newErrand = HttpContext.Session.GetJson<Errand>("NewErrand");
                
                repository.SaveErrand(errand);
                ViewBag.RefNum = errand.RefNumber;
                HttpContext.Session.Remove("NewErrand");
                return View(errand);
            }
        }

        public ViewResult Index()
        {
            var errand = HttpContext.Session.GetJson<Errand>("NewErrand");

            if (errand == null)
            {
                return View();
            }
            else
            {
                return View(errand);
            }
        }

        [HttpPost]
        public ViewResult Validate(Errand err)
        {
            HttpContext.Session.SetJson("NewErrand", err);
            return View(err);
        }

        public ViewResult SavedErrand()
        {
            HttpContext.Session.Remove("NewErrand");
            return View();
        }


    }
}
