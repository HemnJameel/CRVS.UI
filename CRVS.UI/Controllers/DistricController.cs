using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class DistricController : Controller
    {
        public IBaseRepository<District> repository;

        public DistricController(IBaseRepository<District> _repository)
        {

            repository = _repository;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());
        }

     


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(District district)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(district);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var district = repository.GetById(id);
            if (district == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(district.DistrictId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(District district)
        {
            repository.Delete(district.DistrictId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var district = repository.GetById(id);
            if (district == null) { return RedirectToAction(nameof(Index)); }


            return View(district);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(District district)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(district.DistrictId);
                data.DistrictName = district.DistrictName;
                repository.UpdateData(district.DistrictId, district);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
    }

}
