using System.ComponentModel.DataAnnotations;

namespace ShaveddaPizzaria.Models
{
    public class PizzaOrder
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public PizzaOrderDetails OrderDetails { get; set; }
    }
}
