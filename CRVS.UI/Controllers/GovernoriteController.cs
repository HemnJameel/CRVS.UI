using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace CRVS.UI.Controllers
{
    public class GovernoriteController : Controller
    {
        public IBaseRepository<Governorite> repository;
        public IBaseRepository<GovernoriteHistory> Grepository;
        private ApplicationDbContext db;


        public GovernoriteController(ApplicationDbContext _db, IBaseRepository<Governorite> _repository, IBaseRepository<GovernoriteHistory> grepository)
        {

            repository = _repository;
            Grepository = grepository;
            db = _db;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll());
        }
        public IActionResult AllActivate()
        {

            return View(db.Governorites.Where(x => x.IsActive == true));
        }
        public IActionResult AllNotActivate()
        {

            return View(db.Governorites.Where(x => x.IsActive == false));
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

                GovernoriteHistory gg = new GovernoriteHistory
                {
                    GovernoriteHistorydate = DateTime.Now,
                    GovernoriteHistoryName = governorite.GovernoriteName,
                    GovernoriteType="Create",
                    GovernoriteCode = governorite.GovernoriteId
                };
                Grepository.Add(gg);
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
        public IActionResult Activate(int id)
        {

            var governorite = repository.GetById(id);
            governorite.IsActive = true;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult DeActivate(int id)

        {
            var governorite = repository.GetById(id);
            governorite.IsActive = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

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
                GovernoriteHistory gg = new GovernoriteHistory
                {
                    GovernoriteHistorydate = DateTime.Now,
                    GovernoriteHistoryName = governorite.GovernoriteName,
                    GovernoriteType = "Update",
                    GovernoriteCode=governorite.GovernoriteId

                };
                Grepository.Add(gg);

                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }
        [HttpGet]
        public IActionResult History(int? id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var governorites  = db.GovernoriteHistories.Where(x => x.GovernoriteCode == id);
            if (governorites == null) { return RedirectToAction(nameof(Index)); }


            return View(governorites);
        }
    }
}
