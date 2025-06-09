using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    [Table("TB_Grade")]
    public class Grade
    {
        public Grade()
        {
            Students = new List<Student>();
        }
        [Key]
        [Column("G_ID")]
        public int GredeId { get; set; }

        [Required]
        [MaxLength(20)]
        public string GradeName { get; set; }

        public IList<Student> Students { get; set; }
    }
}
