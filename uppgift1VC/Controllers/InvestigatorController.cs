using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models;

namespace uppgift1VC.Controllers
{
    public class InvestigatorController : Controller
    {
        private IErrandRepository repository;

        public InvestigatorController(IErrandRepository repo)
        {
            repository = repo;
        }

        public ViewResult CrimeInvestigator(int id)
        {
            ViewBag.ID = id;
            return View(repository);
        }
        public ViewResult StartInvestigator()
        {
            return View(repository);
        }
    }
}
