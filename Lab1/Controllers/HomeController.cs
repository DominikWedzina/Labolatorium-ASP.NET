using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{

    public enum Operators
    {
        ADD, SUB, MUL, DIV, POW
    }
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator(Operators op, double? a, double? b)
        {
            //string op = Request.Query["op"];
            //string a = Request.Query["a"];
            //double l1 = Double.Parse(a);
            //ViewData["op"] = op;
            if (a == null || b == null || op == null)
            {
                return View("Error");
            }

            switch(op)
            {
                case Operators.ADD:
                    ViewBag.op = a + b;
                    break;
                case Operators.SUB:
                    ViewBag.op = a - b;
                    break;
                case Operators.MUL:
                    ViewBag.op = a * b;
                    break;
                case Operators.DIV:
                    ViewBag.op = a / b;
                    break;
                case Operators.POW:
                    ViewBag.op = Math.Pow((double)a,(double)b);
                    break;
                default: return View("Error");
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}