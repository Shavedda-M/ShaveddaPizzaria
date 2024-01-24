using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShaveddaPizzaria.Data;
using ShaveddaPizzaria.Models;

namespace ShaveddaPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PizzaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.PizzaPresets.ToList());
        }

        public IActionResult Presets()
        {
            return View(_context.PizzaPresets.ToList());
        }

        public IActionResult CreatePreset()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePreset(PizzaPreset preset)
        {
            Console.WriteLine("Method called");
            if (preset.ImageTitle == null)
            {
                preset.ImageTitle = "";
            }
            if (ModelState.IsValid)
            {
                _context.PizzaPresets.Add(preset);
                _context.SaveChanges();
				TempData.Add("success", "Preset created successfully");
				return RedirectToAction("Presets");
            }   
            return View(preset);
        }

        public IActionResult EditPreset(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var preset = _context.PizzaPresets.Find(id);

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
                _context.PizzaPresets.Update(preset);
                _context.SaveChanges();
				TempData["success"] = "Preset edited successfully";
				return RedirectToAction("Presets");
            }
			return View(preset);
        }

        public IActionResult PresetDetail(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var preset = _context.PizzaPresets.Find(id);

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
            var preset = _context.PizzaPresets.Find(id);

            if (preset == null)
            {
                return NotFound();
            }

            _context.PizzaPresets.Remove(preset);
            _context.SaveChanges();
            TempData["success"] = "Preset deleted successfully";
            return RedirectToAction("Presets");
        }

		public IActionResult CustomizePreset(int? id)
		{
            PizzaPreset preset = _context.PizzaPresets.Find(id);
            if (preset == null)
            {
                return NotFound();
            }
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.OrderDetails = new PizzaOrderDetails();
            pizzaOrder.OrderDetails.PizzaSauce = preset.PizzaSauce;
            pizzaOrder.OrderDetails.PizzaName = preset.PizzaName;
			pizzaOrder.OrderDetails.HasCheese = preset.HasCheese;
			pizzaOrder.OrderDetails.HasPepperoni = preset.HasPepperoni;
			pizzaOrder.OrderDetails.HasMushroom = preset.HasMushroom;
			pizzaOrder.OrderDetails.HasPineapple = preset.HasPineapple;
			pizzaOrder.OrderDetails.HasTuna = preset.HasTuna;
			pizzaOrder.OrderDetails.HasPrawn = preset.HasPrawn;
			pizzaOrder.OrderDetails.HasHam = preset.HasHam;
			pizzaOrder.OrderDetails.HasBeef = preset.HasBeef;

			ViewData["PresetImage"] = preset.ImageTitle;
			return View(pizzaOrder);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CustomizePreset(PizzaOrder order)
		{
			order.Email = "mockemail@gmail.com";
			order.OrderDetails.TotalPrice = order.OrderDetails.CalculateTotalPrice();
			_context.PizzaOrders.Add(order);
			_context.SaveChanges();
			TempData["success"] = "Order created successfully. Thank you for placing you order at Shavedda Pizzaria!";
			return RedirectToAction("Index");
		}

		public IActionResult CustomPizza()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CustomPizza(PizzaOrder order)
        {
            order.Email = "mockemail@gmail.com";
            order.OrderDetails.TotalPrice = order.OrderDetails.CalculateTotalPrice();
            _context.PizzaOrders.Add(order);
            _context.SaveChanges();
            TempData["success"] = "Order created successfully. Thank you for placing you order at Shavedda Pizzaria!";
            return RedirectToAction("Index");
        }

        public IActionResult Orders()
        {
            var orders = _context.PizzaOrders.Include(x => x.OrderDetails).ToList();

            return View(_context.PizzaOrders.ToList());
        }

        public IActionResult OrderDetail(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            try
            {
                var order = _context.PizzaOrders.Include(x => x.OrderDetails).First(u => u.OrderId == id);
                return View(order);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteOrder(int? id)
        {
            var order = _context.PizzaOrders.Find(id);
            var orderDetail = _context.PizzaOrderDetails.Find(id);

            if (order == null || orderDetail == null)
            {
                return NotFound();
            }

            _context.PizzaOrders.Remove(order);
            _context.PizzaOrderDetails.Remove(orderDetail);
            _context.SaveChanges();
            TempData["success"] = "Order deleted successfully";
            return RedirectToAction("Orders");
        }

        // Mock pizza presets for demo
        /* 
        public IActionResult AddCustomPresets()
        {

            List<PizzaPreset> pizzaPresets = new List<PizzaPreset>()
            {
                new PizzaPreset() { ImageTitle = "Margerita.png", PizzaName = "Margerita", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, TotalPrice = 339 },
                new PizzaPreset() { ImageTitle = "Bolognese.png", PizzaName = "Bolognese", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasBeef = true, TotalPrice = 359 },
                new PizzaPreset() { ImageTitle = "Hawaiian.png", PizzaName = "Hawaiian", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasHam = true, HasPineapple = true, HasPrawn = true, TotalPrice = 399 },
                new PizzaPreset() { ImageTitle = "Carbonara.png", PizzaName = "Carbonara", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasHam = true, HasMushroom = true, TotalPrice = 379 },
                new PizzaPreset() { ImageTitle = "MeatFeast.png", PizzaName = "MeatFeast", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasHam = true, HasBeef= true, TotalPrice = 379 },
                new PizzaPreset() { ImageTitle = "Mushroom.png", PizzaName = "Mushroom", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasMushroom= true, TotalPrice = 359 },
                new PizzaPreset() { ImageTitle = "Pepperoni.png", PizzaName = "Pepperoni", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasPepperoni = true, TotalPrice = 359 },
                new PizzaPreset() { ImageTitle = "Seafood.png", PizzaName = "Seafood", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasTuna = true, HasPrawn = true, TotalPrice = 379 },
                new PizzaPreset() { ImageTitle = "Vegetarian.png", PizzaName = "Vegetarian", PizzaSize = PizzaSize.Medium, PizzaSauce = PizzaSauce.TomatoSauce, BasePrice = 299, HasCheese = true, HasMushroom = true, HasPineapple = true, TotalPrice = 379 }
            };
            foreach(var preset in pizzaPresets)
            {
                _context.Add(preset);
            }
            _context.SaveChanges();
            return RedirectToAction("Presets");
        }
        */


    }
}
