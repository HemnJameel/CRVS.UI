using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

            return View(repository.GetAll().Where(x => x.IsDeleted == false &&
             x.IsDeleted2 == false && x.IsDeleted3 == false));
        }
        public IActionResult SoftDelete(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RecovaryDeleted(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Recovary()
        {

            return View(db.Nahias.Where(x => x.IsDeleted == true && x.IsDeleted2 == false && x.IsDeleted3 == false));
        }
        public IActionResult SoftDelete2(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted2 = true;
            hh.IsDeleted3 = false;
            db.SaveChanges();
            return RedirectToAction("Recovary2");
        }

        public IActionResult RecovaryDeleted2(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted2 = false;
            hh.IsDeleted3 = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Recovary2()
        {

            return View(db.Nahias.Where(x => x.IsDeleted == true && x.IsDeleted2 == true && x.IsDeleted3 == false));



        }
        public IActionResult SoftDelete3(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted3 = true;
            db.SaveChanges();
            return RedirectToAction("Recovary3");
        }

        public IActionResult RecovaryDeleted3(int id)
        {
            var hh = db.Nahias.Find(id);
            hh.IsDeleted3 = true;
            db.SaveChanges();
            return RedirectToAction();
        }
        public IActionResult Recovary3()
        {

            return View(db.Nahias.Where(x => x.IsDeleted == true && x.IsDeleted2 == true && x.IsDeleted3 == true));



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
                    IsDeleted = false,
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
