using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("CARRERA")]
    public class CARRERA
    {
        [Key]
        public int CAR_ID { get; set; }
        [Display(Name = "Código")]
        [Required]
        public string CAR_CODIGO { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string CAR_NOMBRE { get; set; }

        [Display(Name = "FACULTAD")]
        [Required]
        public int FAC_ID { get; set; }

        public virtual FACULTAD FACULTAD { get; set; }
        public virtual ICollection<PLAN> PLAN { get; set; }
    }
}
