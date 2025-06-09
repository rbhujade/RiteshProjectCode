using System.ComponentModel.DataAnnotations;

namespace MVC_Core_Project.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
