using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SelectListASPCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult selectTag()
        {
            var vm = new ViewModelCollege();
            var group1 = new SelectListGroup { Name = "Developer" };
            var group2 = new SelectListGroup { Name = "Seller" };
            vm.strudents = new List<SelectListItem>
            {
                new SelectListItem{Value="1", Text="Jacob", Group = group1},
                 new SelectListItem{Value="2", Text="Bill", Group = group2},
            };


            return View(vm);
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
