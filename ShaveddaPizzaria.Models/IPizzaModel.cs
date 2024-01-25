namespace ShaveddaPizzaria.Models
{
    public interface IPizzaModel
    {
        int PizzaId { get; set; }
        string PizzaName { get; set; }
        PizzaSize PizzaSize { get; set; }
        PizzaSauce PizzaSauce { get; set; }

        // Pizza Ingredients
        bool HasCheese { get; set; }
        bool HasPepperoni { get; set; }
        bool HasMushroom { get; set; }
        bool HasPineapple { get; set; }
        bool HasTuna { get; set; }
        bool HasPrawn { get; set; }
        bool HasHam { get; set; }
        bool HasBeef { get; set; }
    }
}
