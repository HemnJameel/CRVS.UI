using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace CRVS.UI.Controllers
{
    public class DistrictController : Controller
    {
        public IBaseRepository<District> repository;
        public IBaseRepository<DistrictHistory> Mrepository;
        private ApplicationDbContext db;

        public DistrictController(ApplicationDbContext _db, IBaseRepository<District> _repository, IBaseRepository<DistrictHistory> mrepository)
        {

            repository = _repository;
            Mrepository = mrepository;
            db = _db;
        }
        public IActionResult Index()
        {

            return View(repository.GetAll().Where(x => x.IsDeleted == false));
        }
        public IActionResult AllActivate()
        {

            return View(db.Districts.Where(x => x.IsActive == true));
        }
        public IActionResult AllNotActivate()
        {

            return View(db.Districts.Where(x => x.IsActive == false));
        }

        public IActionResult SoftDelete(int id)
        {
            var mm = db.Districts.Find(id);
            mm.IsDeleted = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult RecovaryDeleted(int id)
        {
            var mm = db.Districts.Find(id);
            mm.IsDeleted = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Recovary()
        {

            return View(db.Districts.Where(x => x.IsDeleted == true));
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(District district)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                repository.Add(district);
                repository.SaveChanges();

                DistrictHistory mm = new DistrictHistory
                {
                    DistrictHistorydate = DateTime.Now,
                    DistrictHistoryName = district.DistrictName,
                    DistrictType = "Create",
                    DistrictCode = district.DistrictId


                };
                Mrepository.Add(mm);
                return RedirectToAction(nameof(Index));
            }
            return View(repository);
        }

        [HttpGet]
        public IActionResult Delete(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var district = repository.GetById(id);
            if (district == null) { return RedirectToAction(nameof(Index)); }
            repository.Delete(district.DistrictId);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult ConfirmDelete(District district)
        {
            repository.Delete(district.DistrictId);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Details(int id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var district = repository.GetById(id);
            if (district == null) { return RedirectToAction(nameof(Index)); }


            return View(district);
        }
        [HttpGet]

        [HttpGet]
        public IActionResult Activate(int id)
        {

            var district = repository.GetById(id);
            district.IsActive = true;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult DeActivate(int id)

        {

            var district = repository.GetById(id);
            district.IsActive = false;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Edit(int id)

        {

            return View(repository.GetById(id));

        }
        [HttpPost]
        public IActionResult Edit(District district)
        {
            // Default Values
            if (ModelState.IsValid)
            {
                var data = repository.GetById(district.DistrictId);
                data.DistrictName = district.DistrictName;
                DistrictHistory mm = new DistrictHistory
                {
                    DistrictHistorydate = DateTime.Now,
                    DistrictHistoryName = district.DistrictName,
                    DistrictType = "Update",
                    DistrictCode = district.DistrictId
                };
                Mrepository.Add(mm);
                return RedirectToAction(nameof(Index));
            }
            return View(repository);

        }
        [HttpGet]
        public IActionResult History(int? id)

        {
            if (id == null) { return RedirectToAction(nameof(Index)); }

            var district = db.DistrictHistories.Where(x => x.DistrictCode == id);
            if (district == null) { return RedirectToAction(nameof(Index)); }

          
            return View(district);
        }
    }

}

