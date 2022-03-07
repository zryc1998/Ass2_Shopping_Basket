using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ass2_Shopping_Basket.Models
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The Brand name cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter a Brand name between 3 and 50 characters in length")]
        [Display(Name="Brand Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}