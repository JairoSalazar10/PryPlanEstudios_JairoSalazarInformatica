using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("ASOCIACION")]
    public class ASOCIACION
    {
        [Key]
        public int ASO_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string ASO_NOMBRE { get; set; }

        public virtual ICollection<ESTUDIANTE> ESTUDIANTE { get; set; }
    }
}
