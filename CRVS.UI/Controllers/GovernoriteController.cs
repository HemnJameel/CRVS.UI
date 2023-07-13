using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class GovernoriteController : Controller
    {
        public IBaseRepository<Governorite> repository;

        public GovernoriteController(IBaseRepository<Governorite> _repository)
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
        public IActionResult Create(Governorite governorite)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(governorite);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var governorite = repository.GetById(id);
            if (governorite == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(governorite.GovernoriteId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Governorite governorite)
        {
            repository.Delete(governorite.GovernoriteId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var governorite = repository.GetById(id);
            if (governorite == null) { return RedirectToAction(nameof(Index)); }


            return View(governorite);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Governorite governorite)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(governorite.GovernoriteId);
                data.GovernoriteName = governorite.GovernoriteName;
                repository.UpdateData(governorite.GovernoriteId, governorite);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}
