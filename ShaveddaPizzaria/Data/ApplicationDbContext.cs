using Microsoft.EntityFrameworkCore;
using ShaveddaPizzaria.Models;

namespace ShaveddaPizzaria.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<PizzaOrder> PizzaOrders { get; set; }
		public DbSet<PizzaOrderDetails> PizzaOrderDetails { get; set; }
		public DbSet<PizzaPreset> PizzaPresets { get; set; }
	}
}
