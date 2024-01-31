using Microsoft.EntityFrameworkCore;
using ShaveddaPizzaria.Models;

namespace ShaveddaPizzaria.DataAccess.Data
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaPreset>().HasData(
                new PizzaPreset() { PizzaId = 1, ImagePath = @"\images\presets\Margerita.png", PizzaName = "Margerita", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true },
                new PizzaPreset() { PizzaId = 2, ImagePath = @"\images\presets\Bolognese.png", PizzaName = "Bolognese", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasBeef = true },
                new PizzaPreset() { PizzaId = 3, ImagePath = @"\images\presets\Hawaiian.png", PizzaName = "Hawaiian", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasPineapple = true, HasPrawn = true },
                new PizzaPreset() { PizzaId = 4, ImagePath = @"\images\presets\Carbonara.png", PizzaName = "Carbonara", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasMushroom = true },
                new PizzaPreset() { PizzaId = 5, ImagePath = @"\images\presets\MeatFeast.png", PizzaName = "MeatFeast", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasBeef = true },
                new PizzaPreset() { PizzaId = 6, ImagePath = @"\images\presets\Mushroom.png", PizzaName = "Mushroom", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasMushroom = true },
                new PizzaPreset() { PizzaId = 7, ImagePath = @"\images\presets\Pepperoni.png", PizzaName = "Pepperoni", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasPepperoni = true },
                new PizzaPreset() { PizzaId = 8, ImagePath = @"\images\presets\Seafood.png", PizzaName = "Seafood", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasTuna = true, HasPrawn = true },
                new PizzaPreset() { PizzaId = 9, ImagePath = @"\images\presets\Vegetarian.png", PizzaName = "Vegetarian", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasMushroom = true, HasPineapple = true }
                );
        }
    }
}
