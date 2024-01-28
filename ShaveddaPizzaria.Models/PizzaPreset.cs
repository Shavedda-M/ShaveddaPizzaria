﻿using System.ComponentModel.DataAnnotations;

namespace ShaveddaPizzaria.Models
{
    public class PizzaPreset : IPizzaModel
    {
        [Key]
        public int PizzaId { get; set; }
        [Required]
        public string PizzaName { get; set; }
        public string ImageTitle { get; set; } = "Create.png";
        [Required]
        public PizzaSauce PizzaSauce { get; set; }

        // Pizza Ingredients
        public bool HasCheese { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasMushroom { get; set; }
        public bool HasPineapple { get; set; }
        public bool HasTuna { get; set; }
        public bool HasPrawn { get; set; }
        public bool HasHam { get; set; }
        public bool HasBeef { get; set; }

    }
}
