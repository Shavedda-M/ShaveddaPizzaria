using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShaveddaPizzaria.DataAccess.Data;
using ShaveddaPizzaria.DataAccess.Repository;
using ShaveddaPizzaria.DataAccess.Repository.IRepository;
using ShaveddaPizzaria.Models;

namespace ShaveddaPizzariaWeb.Controllers
{
    public class PizzaOrderController : Controller
    {
        private readonly IPizzaPresetRepository _presetRepo;
		private readonly IPizzaOrderRepository _orderRepo;
		private readonly IPizzaOrderDetailRepository _orderDetailRepo;

		public PizzaOrderController(IPizzaPresetRepository presetRepo, IPizzaOrderRepository orderRepo, IPizzaOrderDetailRepository orderDetailRepo)
        {
			_presetRepo = presetRepo;
			_orderRepo = orderRepo;
            _orderDetailRepo = orderDetailRepo;
        }

        public IActionResult Index()
        {
			return View(_orderRepo.GetAll());
		}

		public IActionResult OrderPreset(int? id)
		{
            PizzaPreset preset = _presetRepo.Get(u => u.PizzaId == id);
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

			ViewData["PresetImage"] = preset.ImagePath;
			return View(pizzaOrder);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult OrderPreset(PizzaOrder order)
		{
			order.Email = "mockemail@gmail.com";
			order.OrderDetails.TotalPrice = order.OrderDetails.CalculateTotalPrice();
            if(ModelState.IsValid)
            {
				_orderRepo.Add(order);
				_orderRepo.Save();
				TempData["success"] = "Order created successfully. Thank you for placing you order at Shavedda Pizzaria!";
				return RedirectToAction("Index");
			}
			return View(order);
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
            if (ModelState.IsValid)
            {
				_orderRepo.Add(order);
				_orderRepo.Save();
				TempData["success"] = "Order created successfully. Thank you for placing you order at Shavedda Pizzaria!";
				return RedirectToAction("Index");
			}
            return View(order);
        }

        public IActionResult OrderDetail(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            try
            {
                var order = _orderRepo.Get(u => u.OrderId == id);
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
            var order = _orderRepo.Get(u => u.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

			_orderRepo.Remove(order);
            _orderRepo.Save();
			TempData["success"] = "Order deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
