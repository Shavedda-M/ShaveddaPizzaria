using System.ComponentModel.DataAnnotations;

namespace ShaveddaPizzaria.Models
{
    public enum PizzaSize
    {
        Small = 1,
        Medium = 2,
        Large = 3,
    }

    public enum PizzaSauce
    {
        [Display(Name = "Tomato Sauce")]
        TomatoSauce = 1,
        [Display(Name = "BBQ Sauce")]
        BBQSuace = 2,
        [Display(Name = "Alfredo Sauce")]
        AlfredoSauce = 3,
    }

	public enum PizzaStatus
	{
		Ordered = 1,
		[Display(Name = "Waiting to be delivered")]
		WaitingToBeDelivered = 2,
		Delivered = 3,
        Cancelled = 4
	}
}
