using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoMVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        
        //public ICollection<Product> Products { get; set; }
    }
}
