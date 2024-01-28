using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ShaveddaPizzaria.Models
{
    public class PizzaOrder
    {
        [Key]
        public int OrderId { get; set; }
		//public string? OwnerID { get; set; }
		[Required, ValidateNever]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        //public PizzaStatus Status { get; set; } = PizzaStatus.Ordered;
        public PizzaOrderDetails OrderDetails { get; set; }
    }
}
