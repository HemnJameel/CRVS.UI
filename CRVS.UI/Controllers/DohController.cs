using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRVS.UI.Controllers
{
    public class DohController : Controller
    {
        public IBaseRepository<Doh> repository;
        public IBaseRepository<DohHistory> Drepository;
        private ApplicationDbContext db;
        public DohController(ApplicationDbContext _db, IBaseRepository<Doh> _repository, IBaseRepository<DohHistory> drepository)
        {

            repository = _repository;
            Drepository = drepository;
            db = _db;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());
        }

        public IActionResult AllActivate()
        {

            return View(db.Dohs.Where(x=>x.IsActive==true));
        }
        public IActionResult AllNotActivate()
        {

            return View(db.Dohs.Where(x => x.IsActive == false));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Doh doh)
        {
            // Default Values[Bind("ClinetId,ClinetName,Comment,Position,IsDeleted,IsActive,CreationDate")]
            if (ModelState.IsValid)
            {

                repository.Add(doh);
                repository.SaveChanges();

                DohHistory dd = new DohHistory
                {
                    DohHistorydate = DateTime.Now,
                    DohHistoryName = doh.DohName,
                    DohCode = doh.DohId,
                    DohType = "Create"
                };
                Drepository.Add(dd);
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
        public IActionResult Activate(int id)
        {
       
            var doh = repository.GetById(id);
            doh.IsActive=true;
            db.SaveChanges();
         return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult DeActivate(int id)

        {

            var doh = repository.GetById(id);
            doh.IsActive = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]

        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
     
        public IActionResult Edit( Doh doh)
        {
           
            // Default Values
            if (ModelState.IsValid)
            {


                var data = repository.GetById(doh.DohId);
                data.DohName = doh.DohName;
                DohHistory dd = new DohHistory
                {
                    DohHistorydate = DateTime.Now,
                    DohHistoryName = doh.DohName,
                    DohCode = doh.DohId,
                    DohType = "Update"

                };
                Drepository.Add(dd);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
        [HttpGet]
        public IActionResult History(int? id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var doh = db.DohHistories.Where(x => x.DohCode == id);
            if (doh == null) { return RedirectToAction(nameof(Index)); }


            return View(doh);
        }
    }


}

