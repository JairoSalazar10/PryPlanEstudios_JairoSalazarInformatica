using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("PLAN")]
    public class PLAN
    {
        [Key]
        public int PLA_ID { get; set; }
        [Display(Name = "Código")]
        [Required]
        public string PLA_CODIGO { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string PLA_NOMBRE { get; set; }
        [Display(Name = "CARRERA")]
        [Required]
        public int CAR_ID { get; set; }
        public virtual ICollection<ESTUDIANTE> ESTUDIANTE { get; set; }

        public virtual CARRERA CARRERA { get; set; }
        
        public virtual ICollection<PLAN_MATERIA> PLAN_MATERIA { get; set; }
    }
}
