using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models;

namespace uppgift1VC.Controllers
{
    public class CoordinatorController : Controller
    {
        private IErrandRepository repository;
        public CoordinatorController(IErrandRepository repo)
        {
            repository = repo;
        }

        public ViewResult CrimeCoordinator(int id)
        {
            ViewBag.ID = id;
            return View(repository);
        }

        public ViewResult ReportCrime()
        {
            return View();
        }

        public ViewResult StartCoordinator()
        {
            return View(repository);
        }



    }
}
