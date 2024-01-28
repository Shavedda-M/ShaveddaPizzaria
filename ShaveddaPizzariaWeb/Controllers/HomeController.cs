using Microsoft.AspNetCore.Mvc;
using ShaveddaPizzaria.DataAccess.Repository.IRepository;
using ShaveddaPizzaria.Models;
using System.Diagnostics;

namespace ShaveddaPizzariaWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPizzaPresetRepository _presetRepo;

        public HomeController(ILogger<HomeController> logger, IPizzaPresetRepository presetRepo)
        {
            _logger = logger;
            _presetRepo = presetRepo;
        }

		public IActionResult Index()
		{
			return View(_presetRepo.GetAll());
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
