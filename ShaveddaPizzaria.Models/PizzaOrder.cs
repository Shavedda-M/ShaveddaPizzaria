using System.ComponentModel.DataAnnotations;

namespace ShaveddaPizzaria.Models
{
    public class PizzaOrder
    {
        [Key]
        public int OrderId { get; set; }
		//public string? OwnerID { get; set; }
		[Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        //public PizzaStatus Status { get; set; } = PizzaStatus.Ordered;
        public PizzaOrderDetails OrderDetails { get; set; }
    }
}
