using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    [Table("TB_Student")]
    public class Student
    {
        [Key]
        [Column("S_ID")]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [ForeignKey(nameof(Grade))]
        [Column("G_ID")]
        public int GredeId { get; set; }

        public Grade Grade { get; set; }
    }
}
