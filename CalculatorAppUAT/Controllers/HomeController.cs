using CalculatorAppUAT.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CalculatorAppUAT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Calculator calc = new Calculator();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(calc);
        }
        
        [HttpPost]
        public IActionResult Index(Calculator calc)
        {
            if (calc.Operation == "/" && calc.SecondNumber == 0)
                ModelState.AddModelError("zeroDivision", "Error - division with 0");

            if (ModelState.IsValid)
                calc.Count();

            return View(calc);
        }
    }
}