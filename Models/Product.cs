using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace midterm_encinasValador.Models
{
    public class Product
    {
        [Key] public int Id { get; set; }
        [Required] public required string Name { get; set; }
        public string? Description { get; set; }
        [Required][Range(0.01, double.MaxValue)] public decimal Price { get; set; }
        [Required][Range(0, int.MaxValue)] public int StockQuantity { get; set; }

        [ValidateNever]
        [NotMapped]
        public IFormFile? ProductImageUpload { get; set; }

        [ValidateNever]
        [Display(Name = "Photo")]
        public string? ProductImage { get; set; }

        public string? Category { get; set; }


    }
}
