using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class GovernoriteHistoryController : Controller
    {
        public IBaseRepository<GovernoriteHistory> repository;

        public GovernoriteHistoryController(IBaseRepository<GovernoriteHistory> _repository)
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
        public IActionResult Create(GovernoriteHistory governoriteHistory)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(governoriteHistory);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}
