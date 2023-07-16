using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRVS.UI.Controllers
{
    public class NahiaHistoryController : Controller
    {
        public IBaseRepository<NahiaHistory> repository;

        public NahiaHistoryController(IBaseRepository<NahiaHistory> _repository)
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
        public IActionResult Create(NahiaHistory nahiaHistory)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(nahiaHistory);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
    }
}
