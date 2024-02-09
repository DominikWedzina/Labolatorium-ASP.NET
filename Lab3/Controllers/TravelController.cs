using Labolatorium3_App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Labolatorium3_App.Controllers
{
    [Authorize(Roles = "admin")]
    public class TravelController : Controller
    {
        private readonly ITravelService _travelService;
        public TravelController(ITravelService travelService)
        {
            _travelService = travelService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateApi(Travel t)
        {
            if (ModelState.IsValid)
            {
                _travelService.Add(t);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_travelService.FindAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            Travel model = new Travel();
            model.Organizations = _travelService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList();
            model.Guides = _travelService
            .FindAllGuides()
            .Select(g => new SelectListItem() { Value = g.Id.ToString(), Text = g.Name })
            .ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Travel travel)
        {
            Travel model = new Travel();
            model.Organizations = _travelService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
                .ToList();
            model.Guides = _travelService
                .FindAllGuides()
                .Select(g => new SelectListItem() { Value = g.Id.ToString(), Text = g.Name })
                .ToList();

            if (ModelState.IsValid)
            {
                _travelService.Add(travel);
                return RedirectToAction("index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Travel model = _travelService.FindById(id);
            model.Organizations = _travelService
            .FindAllOrganizations()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();
            model.Guides = _travelService
            .FindAllGuides()
            .Select(g => new SelectListItem() { Value = g.Id.ToString(), Text = g.Name })
            .ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Travel model)
        {
            if (ModelState.IsValid)
            {
                _travelService.Update(model);
                return RedirectToAction("index");
            }
            model.Organizations = _travelService
            .FindAllOrganizations()
            .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Title })
            .ToList();
            model.Guides = _travelService
            .FindAllGuides()
            .Select(g => new SelectListItem() { Value = g.Id.ToString(), Text = g.Name })
            .ToList();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            var travel = _travelService.FindById(id);
            if (travel == null)
            {
                return NotFound();
            }

            var guide = _travelService.FindGuideById(travel.GuideId);
            var organization = _travelService.FindOrganizationById(travel.OrganizationId);

            ViewBag.GuideName = guide?.Name ?? "N/A";
            ViewBag.OrganizationTitle = organization?.Title ?? "N/A";

            return View(travel);
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
