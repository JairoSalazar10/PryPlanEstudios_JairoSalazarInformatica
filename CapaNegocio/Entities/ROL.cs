using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("ROL")]
    public class ROL
    {
        [Key]
        public int ROL_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string ROL_NOMBRE { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
