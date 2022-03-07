using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ass2_Shopping_Basket.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int? BrandID { get; set; }
        public virtual Brand Brand { get; set; }
        [Required(ErrorMessage = "The Model cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a Model name between 3 and 50 characters in length")]
        [Display(Name="Model")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Product description cannot be blank")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Please enter a product description between 10 and 200 characters in length")]
        public string Description { get; set; }
        [Required(ErrorMessage = "The Product price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }

        internal static IEnumerable<object> OrderBy(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}