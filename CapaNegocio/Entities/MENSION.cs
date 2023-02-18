using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("MENSION")]
    public class MENSION
    {
        [Key]
        public int MEN_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string MEN_NOMBRE { get; set; }
        
        public virtual ICollection<COLEGIO> COLEGIO { get; set; }
    }
}
