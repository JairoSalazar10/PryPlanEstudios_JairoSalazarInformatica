using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("PLAN_MATERIA")]
    public class PLAN_MATERIA
    {
        [Key]
        public int PLM_ID { get; set; }
        [Display(Name = "Plan")]
        [Required]
        public int PLA_ID { get; set; }
        [Display(Name = "Materia")]
        [Required]
        public int MAT_ID { get; set; }

        public virtual MATERIA MATERIA { get; set; }
        public virtual PLAN PLAN { get; set; }
    }
}
