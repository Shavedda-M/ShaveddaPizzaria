using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShaveddaPizzaria.Models
{
    public class PizzaOrderDetails : IPizzaModel
    {
        // Pizza Informations
        [Key, ForeignKey("PizzaOrder")]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        [Required]
        public PizzaSize PizzaSize { get; set; }
        [Required]
        public PizzaSauce PizzaSauce { get; set; }
        public float TotalPrice { get; set; }

        // Pizza Ingredients
        public bool HasCheese { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasMushroom { get; set; }
        public bool HasPineapple { get; set; }
        public bool HasTuna { get; set; }
        public bool HasPrawn { get; set; }
        public bool HasHam { get; set; }
        public bool HasBeef { get; set; }

        public PizzaOrder PizzaOrder { get; set; }

        private float CalculateIngredientsPrice()
        {
            float componentPrice = 0;

            if (HasCheese) componentPrice += 20;
            if (HasPepperoni) componentPrice += 20;
            if (HasMushroom) componentPrice += 20;
            if (HasPineapple) componentPrice += 20;
            if (HasTuna) componentPrice += 20;
            if (HasPrawn) componentPrice += 20;
            if (HasHam) componentPrice += 20;
            if (HasBeef) componentPrice += 20;

            return componentPrice;
        }

        private float CalculateBasePrice()
        {
            float price;

            switch (PizzaSize)
            {
                case PizzaSize.Small:
                    price = 199;
                    break;
                case PizzaSize.Medium:
                    price = 299;
                    break;
                case PizzaSize.Large:
                    price = 399;
                    break;
                default:
                    price = 0;
                    break;
            }
            return price;
        }

        public float CalculateTotalPrice()
        {
            return CalculateBasePrice() + CalculateIngredientsPrice();
        }
    }
}
