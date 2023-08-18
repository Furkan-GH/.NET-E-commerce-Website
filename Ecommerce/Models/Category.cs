using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Category
    {
        [Key] //primary key
        public int Id { get; set; }
        public string CategoryName { get; set; }


    }
    
}
