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
                new PizzaPreset() { PizzaId = 1, ImageTitle = "Margerita.png", PizzaName = "Margerita", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true },
                new PizzaPreset() { PizzaId = 2, ImageTitle = "Bolognese.png", PizzaName = "Bolognese", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasBeef = true },
                new PizzaPreset() { PizzaId = 3, ImageTitle = "Hawaiian.png", PizzaName = "Hawaiian", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasPineapple = true, HasPrawn = true },
                new PizzaPreset() { PizzaId = 4, ImageTitle = "Carbonara.png", PizzaName = "Carbonara", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasMushroom = true },
                new PizzaPreset() { PizzaId = 5, ImageTitle = "MeatFeast.png", PizzaName = "MeatFeast", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasHam = true, HasBeef = true },
                new PizzaPreset() { PizzaId = 6, ImageTitle = "Mushroom.png", PizzaName = "Mushroom", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasMushroom = true },
                new PizzaPreset() { PizzaId = 7, ImageTitle = "Pepperoni.png", PizzaName = "Pepperoni", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasPepperoni = true },
                new PizzaPreset() { PizzaId = 8, ImageTitle = "Seafood.png", PizzaName = "Seafood", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasTuna = true, HasPrawn = true },
                new PizzaPreset() { PizzaId = 9, ImageTitle = "Vegetarian.png", PizzaName = "Vegetarian", PizzaSauce = PizzaSauce.TomatoSauce, HasCheese = true, HasMushroom = true, HasPineapple = true }
                );
        }
    }
}
