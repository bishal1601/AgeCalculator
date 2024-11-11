using AgeCalculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgeCalculator.Controllers
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
        [HttpPost]
        public string Index(AgeVm Vm)
        {
            string FullName=Vm.FullName;
            DateOnly Birthdate = Vm.BirthDate;
            int age = DateTime.Now.Year - Birthdate.Year;
            
            return "Hello "+FullName + " your age is "+age;
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
