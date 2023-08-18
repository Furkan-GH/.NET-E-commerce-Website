using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class AllProducts
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    
}
