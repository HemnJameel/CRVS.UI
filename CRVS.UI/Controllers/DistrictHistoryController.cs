using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class DistrictHistoryController : Controller
    {
        public IBaseRepository<DistrictHistory> repository;

        public DistrictHistoryController(IBaseRepository<DistrictHistory> _repository)
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
        public IActionResult Create(DistrictHistory districtHistory)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(districtHistory);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(DistrictHistory districtHistory)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(districtHistory.DistrictHistoryId);
                data.DistrictHistoryName = districtHistory.DistrictHistoryName;
                repository.UpdateData(districtHistory.DistrictHistoryId, districtHistory);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
    }
}

