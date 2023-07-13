using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class DohController : Controller
    {
        public IBaseRepository<Doh> repository;

        public DohController(IBaseRepository<Doh> _repository)
        {

            repository = _repository;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());
        }

        public IActionResult Index1()
        {

            return View(repository.GetAll());
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Doh doh)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(doh);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var doh = repository.GetById(id);
            if (doh == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(doh.DohId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Doh doh)
        {
            repository.Delete(doh.DohId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var doh = repository.GetById(id);
            if (doh == null) { return RedirectToAction(nameof(Index)); }


            return View(doh);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Doh doh)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(doh.DohId);
                data.DohName = doh.DohName;
                repository.UpdateData(doh.DohId, doh);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
    }


}

