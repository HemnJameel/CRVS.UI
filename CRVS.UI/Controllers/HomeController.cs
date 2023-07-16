using CRVS.Core.IRepositories;
using CRVS.Core.Models;
using CRVS.EF;
using CRVS.EF.Repositories;
using CRVS.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;

namespace CRVS.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IBaseRepository<Governorite> repository;

       

        public HomeController(ILogger<HomeController> logger , IBaseRepository<Governorite> _repository)
        {
            _logger = logger;
            repository = _repository;
        }
        public IActionResult FiltterData()
        {
        
        
            ViewBag.ListofCategory = new SelectList( repository.GetAll(), "GovernoriteId", "GovernoriteName");
            return View();
        }
        public IActionResult Index()
        {
           
            return View();
        }
     

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}