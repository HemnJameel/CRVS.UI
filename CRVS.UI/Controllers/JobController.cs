using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol;

namespace CRVS.UI.Controllers
{
    public class JobController : Controller
    {
        public IBaseRepository<Job> repository;

        public JobController(IBaseRepository<Job> _repository)
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
        public IActionResult Create(Job job)
        {
            // Default Values
            if (ModelState.IsValid)
            {
              
               repository.Add(job);
                repository.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var job = repository.GetById(id);
            if (job == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(job.JobId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Job job)
        {
            repository.Delete(job.JobId);
          
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var job = repository.GetById(id);
            if (job == null) { return RedirectToAction(nameof(Index)); }


            return View(job);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {
          
            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Job job)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(job.JobId);
                data.JobName = job.JobName;
                repository.UpdateData(job.JobId, job);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
    }


}

