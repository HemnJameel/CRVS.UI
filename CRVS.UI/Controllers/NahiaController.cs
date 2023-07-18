using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace CRVS.UI.Controllers
{
    public class NahiaController : Controller
    {
        public IBaseRepository<Nahia> repository;
        public IBaseRepository<NahiaHistory> Nrepository;
        private ApplicationDbContext db;

        public NahiaController( ApplicationDbContext _db ,IBaseRepository<Nahia> _repository, IBaseRepository<NahiaHistory> nrepository)
        {

            repository = _repository;
            Nrepository = nrepository;
            db = _db;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());
        }
        [HttpGet]
        public IActionResult Activate(int id)
        {

            var nahia = repository.GetById(id);
            nahia.IsActive = true;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult DeActivate(int id)

        {

            var nahia = repository.GetById(id);
            nahia.IsActive = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult AllActivate()
        {

            return View(db.Nahias.Where(x => x.IsActive == true));
        }
        public IActionResult AllNotActivate()
        {

            return View(db.Nahias.Where(x => x.IsActive == false));
        }


        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Nahia nahia)
        {
            // Default Values
            if (ModelState.IsValid)
            {

                repository.Add(nahia);
                repository.SaveChanges();

                NahiaHistory nn = new NahiaHistory
                {
                    NahiaHistorydate = DateTime.Now,
                    NahiaHistoryName = nahia.NahiaName,
                    NahiaType="Create",
                    NahiaCode=nahia.NahiaId
                    
                };
                Nrepository.Add(nn);
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var nahia = repository.GetById(id);
            if (nahia == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(nahia.NahiaId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(Nahia nahia)
        {
            repository.Delete(nahia.NahiaId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var nahia = repository.GetById(id);
            if (nahia == null) { return RedirectToAction(nameof(Index)); }


            return View(nahia);
        }
        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(Nahia nahia)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(nahia.NahiaId);
                data.NahiaName = nahia.NahiaName;
                NahiaHistory nn = new NahiaHistory
                {
                    NahiaHistorydate = DateTime.Now,
                    NahiaHistoryName = nahia.NahiaName,
                    NahiaType = "Update",
                    NahiaCode=nahia.NahiaId
                };
               Nrepository.Add(nn);
                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
        [HttpGet]
        public IActionResult History(int? id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var nahia = db.nahiaHistories.Where(x => x.NahiaCode == id);
            if (nahia == null) { return RedirectToAction(nameof(Index)); }


            return View(nahia);
        }
    }
}
