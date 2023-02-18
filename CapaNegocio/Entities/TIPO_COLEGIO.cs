using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("TIPO_COLEGIO")]
    public class TIPO_COLEGIO
    {
        [Key]
        public int TPC_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string TPC_NOMBRE { get; set; }
        
    }
}
