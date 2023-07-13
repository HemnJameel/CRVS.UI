using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class NationalityController : Controller
    {
        public IBaseRepository<Nationality> repository;

        public NationalityController(IBaseRepository<Nationality> _repository)
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
        public IActionResult Create(Nationality nationality)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(nationality);
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
            repository.Delete(nationality.NationalityId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Nationality nationality)
        {
            repository.Delete(nationality.NationalityId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var nationality = repository.GetById(id);
            if (nationality == null) { return RedirectToAction(nameof(Index)); }


            return View(nationality);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Nationality nationality)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(nationality.NationalityId);
                data.NationalityName = nationality.NationalityName;
                repository.UpdateData(nationality.NationalityId, nationality);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}
