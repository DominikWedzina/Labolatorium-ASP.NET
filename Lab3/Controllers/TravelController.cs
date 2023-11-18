using Labolatorium3_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium3_App.Controllers
{
    public class TravelController : Controller
    {
        private readonly ITravelService _travelService;

        public TravelController(ITravelService travelService)
        {
            _travelService = travelService;
        }
        public IActionResult Index()
        {
            return View(_travelService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Travel travel)
        {
            if (ModelState.IsValid)
            {
                _travelService.Add(travel);
                return RedirectToAction("index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_travelService.FindById(id));
        }

        [HttpPost]
        public IActionResult Update(Travel model)
        {
            if (ModelState.IsValid)
            {
                _travelService.Update(model);
                return RedirectToAction("index");
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            return View(_travelService.FindById(id));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_travelService.FindById(id));
        }

        [HttpPost]
        public IActionResult Delete(Travel model)
        {
            _travelService.DeleteById(model.Id);
            return RedirectToAction("index");
        }
    }
}
