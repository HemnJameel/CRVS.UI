using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class DohHistoryController : Controller
    {
        public IBaseRepository<DohHistory> repository;

        public DohHistoryController(IBaseRepository<DohHistory> _repository)
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
        public IActionResult Create(DohHistory dohHistory)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(dohHistory);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}
