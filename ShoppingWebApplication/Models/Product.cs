using System.ComponentModel.DataAnnotations;

namespace ShoppingWebApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a prdouct name.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a price for product.")]
        public double? Price { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Please enter a colour.")]
        public int ColourId { get; set; }
        public Colour? Colour { get; set; }

        [Required(ErrorMessage = "Please enter a category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please enter a brand")]
        public string? Supplier { get; set; }
        public string? ImagePath { get; set; }

        public string Slug =>
            ProductName?.Replace(' ', '-').ToLower() + '-' + CategoryId.ToString();
    }
}
