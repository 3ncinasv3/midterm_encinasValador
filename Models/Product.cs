using System.ComponentModel.DataAnnotations;

namespace midterm_encinasValador.Models
{
    public class Product
    {
       [Key] public int Id { get; set; }
       [Required] public required string Name { get; set; }
        public string? Description { get; set; }
       [Required][Range(0.01,double.MaxValue)] public decimal Price { get; set; }
       [Required][Range(0,int.MaxValue)] public int StockQuantity { get; set; }

    }
}
