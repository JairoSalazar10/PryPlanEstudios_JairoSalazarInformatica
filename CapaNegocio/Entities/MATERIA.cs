using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("MATERIA")]
    public class MATERIA
    {
        [Key]
        public int MAT_ID { get; set; }
        [Display(Name = "Código")]
        [Required]
        public string MAT_CODIGO { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string MAT_NOMBRE { get; set; }
        [Display(Name = "Nivel")]
        [Required]
        public int MAT_NIVEL { get; set; }

        public virtual ICollection<PLAN_MATERIA> PLAN_MATERIA { get; set; }

    }
}
