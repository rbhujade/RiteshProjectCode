using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_EF_Approach.Models
{
    public class Order
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        [MaxLength(250)]
        public string? OrderName { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
