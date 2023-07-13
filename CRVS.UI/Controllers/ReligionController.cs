using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class ReligionController : Controller
    {
        public IBaseRepository<Religion> repository;

        public ReligionController(IBaseRepository<Religion> _repository)
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
        public IActionResult Create(Religion religion)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(religion);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var nationality = repository.GetById(id);
            if (nationality == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(nationality.ReligionId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Religion religion)
        {
            repository.Delete(religion.ReligionId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var religion = repository.GetById(id);
            if (religion == null) { return RedirectToAction(nameof(Index)); }


            return View(religion);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Religion religion)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(religion.ReligionId);
                data.ReligionName = religion.ReligionName;
                repository.UpdateData(religion.ReligionId, religion);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}