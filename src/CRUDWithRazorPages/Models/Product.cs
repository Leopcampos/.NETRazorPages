using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWithRazorPages.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int Qty { get; set; }
    }
}
