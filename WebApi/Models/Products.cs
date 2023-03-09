using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Pname { get; set; }
        [Required]
        public string? Company { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
