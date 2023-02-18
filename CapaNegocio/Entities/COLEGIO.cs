using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("COLEGIO")]
    public class COLEGIO
    {
        [Key]
        public int COL_ID { get; set; }
        [Display(Name = "Colegio")]
        [Required]
        public string COL_NOMBRE { get; set; }
        [Display(Name = "Ciudad")]
        [Required]
        public string COL_CIUDAD { get; set; }
        [Display(Name = "Tpo_Colegio")]
        [Required]
        public int TPC_ID { get; set; }
        [Display(Name = "Email")]
        [Required]
        public string COL_EMAIL_PERSONAL { get; set; }
        [Display(Name = "Año_Grado")]
        [Required]
        public int COL_ANIO_GRADO { get; set; }
        [Display(Name = "Pensión")]
        [Required]
        public decimal COL_PENSION { get; set; }
        [Display(Name = "Puntaje")]
        [Required]
        public decimal COL_PUNTAJE { get; set; }
        [Display(Name = "Mensión")]
        [Required]
        public int MEN_ID { get; set; }
        [Display(Name = "Estudiante")]
        [Required]
        public int EST_ID { get; set; }

        public virtual ESTUDIANTE ESTUDIANTE { get; set; }
        public virtual MENSION MENSION { get; set; }
        public virtual TIPO_COLEGIO TIPO_COLEGIO { get; set; }
    }
}
