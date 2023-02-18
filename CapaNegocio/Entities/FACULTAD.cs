using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("FACULTAD")]
    public class FACULTAD
    {
        [Key]
        public int FAC_ID { get; set; }
        [Display(Name = "Código")]
        [Required]
        public string FAC_CODIGO { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string FAC_NOMBRE { get; set; }

        public virtual ICollection<CARRERA> CARRERA { get; set; }
    }
}
