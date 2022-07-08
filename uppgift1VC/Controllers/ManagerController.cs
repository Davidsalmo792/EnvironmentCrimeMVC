using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models;

namespace uppgift1VC.Controllers
{
    public class ManagerController : Controller
    {
        private IErrandRepository repository;

        public ManagerController(IErrandRepository repo)
        {
            repository = repo;
        }

        public ViewResult CrimeManager(int id)
        {
            ViewBag.ID = id;
            return View(repository);
        }

        public ViewResult StartManager()
        {
            return View(repository);
        }
    }
}
