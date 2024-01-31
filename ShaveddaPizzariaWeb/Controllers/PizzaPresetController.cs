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
        private readonly IWebHostEnvironment _webHostEnvironment;

        private const string DEFAULT_PRESET_IMAGE = @"\images\presets\Create.png";

		public PizzaPresetController(IPizzaPresetRepository presetRepo, IWebHostEnvironment webHostEnvironment)
		{
			_presetRepo = presetRepo;
			_webHostEnvironment = webHostEnvironment;
		}

		public IActionResult Index()
        {
            return View(_presetRepo.GetAll());
        }

        public IActionResult UpsertPreset(int? id)
        {
            if(id == null || id == 0)
            {
                return View(new PizzaPreset());
            }
            else
            {
                PizzaPreset preset = _presetRepo.Get(u => u.PizzaId == id);
                return View(preset);
            }
        }

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult UpsertPreset(PizzaPreset preset, IFormFile? file)
		{
			if (ModelState.IsValid)
			{
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if(file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string presetPath = Path.Combine(wwwRootPath, @"images\presets");

                    DeleteOldImage(preset, wwwRootPath);

                    using (var fileStream = new FileStream(Path.Combine(presetPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    preset.ImagePath = @"\images\presets\" + fileName;
                }

                if(preset.PizzaId == 0)
                {
                    if(string.IsNullOrEmpty(preset.ImagePath))
                    {
                        preset.ImagePath = @"\images\presets\Create.png";
                    }
					_presetRepo.Add(preset);
					TempData.Add("success", "Preset created successfully");
				}
                else
                {
					_presetRepo.Update(preset);
					TempData.Add("success", "Preset edited successfully");
				}

				_presetRepo.Save();
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

			DeleteOldImage(preset, _webHostEnvironment.WebRootPath);
			_presetRepo.Remove(preset);
			_presetRepo.Save();
			TempData["success"] = "Preset deleted successfully";
            return RedirectToAction("Index");
        }

        private void DeleteOldImage(PizzaPreset preset, string wwwRootPath)
        {
			if (!string.IsNullOrEmpty(preset.ImagePath))
			{
				// Delete old image
				var oldImagePath = Path.Combine(wwwRootPath, preset.ImagePath.TrimStart('\\'));
				var defaultImagePath = Path.Combine(wwwRootPath, DEFAULT_PRESET_IMAGE.TrimStart('\\'));

				if (System.IO.File.Exists(oldImagePath) && !oldImagePath.Equals(defaultImagePath))
				{
					System.IO.File.Delete(oldImagePath);
				}

			}
		}
	}
}
