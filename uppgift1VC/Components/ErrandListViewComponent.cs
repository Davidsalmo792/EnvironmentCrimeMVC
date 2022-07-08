using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uppgift1VC.Models;

namespace uppgift1VC.Components
{
    public class ErrandListViewComponent : ViewComponent
    {
        private IErrandRepository errandRepository;
        public ErrandListViewComponent(IErrandRepository repo)
        {
            errandRepository = repo;

        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var errandInfo = await errandRepository.GetErrandInfo(id);
            return View(errandInfo);
        }

    }
}
