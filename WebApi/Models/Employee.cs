using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key] 
        public int Empid { get; set; }
        [Required] 
        public string? Empname { get; set; }
        [Required]
        public string? Deptname { get; set; }
        [Required]
        public decimal Salary { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
