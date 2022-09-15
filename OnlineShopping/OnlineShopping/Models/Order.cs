using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name ="Order NO")]
        public string OrderNO { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public string Address { get; set; }
        public DateTime OrderDate { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
