using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OnlineShopping.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string ProductType { get; set; }

    }
}
