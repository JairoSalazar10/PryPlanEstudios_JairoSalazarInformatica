using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("ESTUDIANTE")]
    public class ESTUDIANTE
    {
        [Key]
        public int EST_ID { get; set; }
        [Display(Name = "Cédula")]
        [Required]
        public string EST_CEDULA { get; set; }
        [Display(Name = "Nombres")]
        [Required]
        public string EST_NOMBRES { get; set; }
        [Display(Name = "Apellidos")]
        [Required]
        public string EST_APELLIDOS { get; set; }
        [Display(Name = "F_Nacimiento")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime EST_FNACIMIENTO { get; set; }
        [Display(Name = "Sexo")]
        [Required]
        public string EST_SEXO { get; set; }

        [Display(Name = "Plan")]
        [Required]
        public int PLA_ID { get; set; }

        [Display(Name = "Correo")]
        [Required]
        public string EST_EMAIL { get; set; }

        [Display(Name = "Tel_Domicilio")]
        [Required]
        public string EST_TEL_DOMICILIO { get; set; }

        [Display(Name = "Tel_Celular")]
        [Required]
        public string EST_TEL_CELULAR { get; set; }

        [Display(Name = "Dirección")]
        [Required]
        public string EST_DIRECCION { get; set; }
        [Display(Name = "Observación")]
        public string EST_OBSERVACION { get; set; }
        [Display(Name = "Afición")]
        [Required]
        public int AFI_ID { get; set; }
        [Display(Name = "Asociación")]
        [Required]
        public int ASO_ID { get; set; }
        [Display(Name = "Motivación")]
        [Required]
        public int MOT_ID { get; set; }

        public virtual AFICION AFICION { get; set; }
        public virtual ASOCIACION ASOCIACION { get; set; }
        public virtual ICollection<COLEGIO> COLEGIO { get; set; }
        public virtual MOTIVACION MOTIVACION { get; set; }
        public virtual PLAN PLAN { get; set; }
    }
}
