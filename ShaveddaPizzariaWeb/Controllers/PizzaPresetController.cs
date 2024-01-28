using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShaveddaPizzaria.DataAccess.Data;
using ShaveddaPizzaria.DataAccess.Repository;
using ShaveddaPizzaria.DataAccess.Repository.IRepository;
using ShaveddaPizzaria.Models;

namespace ShaveddaPizzariaWeb.Controllers
{
    public class PizzaPresetController : Controller
    {
        private readonly IPizzaPresetRepository _presetRepo;

		public PizzaPresetController(IPizzaPresetRepository presetRepo)
        {
			_presetRepo = presetRepo;
        }

        public IActionResult Index()
        {
            return View(_presetRepo.GetAll());
        }

        public IActionResult CreatePreset()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePreset(PizzaPreset preset)
        {
            if (preset.ImageTitle == null)
            {
                preset.ImageTitle = "";
            }
            if (ModelState.IsValid)
            {
				_presetRepo.Add(preset);
				_presetRepo.Save();
				TempData.Add("success", "Preset created successfully");
				return RedirectToAction("Index");
            }   
            return View(preset);
        }

        public IActionResult EditPreset(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var preset = _presetRepo.Get(u => u.PizzaId == id);

            if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPreset(PizzaPreset preset)
        {
            if (ModelState.IsValid)
            {
				_presetRepo.Update(preset);
				_presetRepo.Save();
				TempData["success"] = "Preset edited successfully";
				return RedirectToAction("Index");
            }
			return View(preset);
        }

        public IActionResult PresetDetail(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var preset = _presetRepo.Get(u => u.PizzaId == id);

			if (preset == null)
            {
                return NotFound();
            }

            return View(preset);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePreset(int? id)
        {
            var preset = _presetRepo.Get(u => u.PizzaId == id);

			if (preset == null)
            {
                return NotFound();
            }

			_presetRepo.Remove(preset);
			_presetRepo.Save();
			TempData["success"] = "Preset deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
