using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entities
{
    [Table("USUARIO")]
    public class USUARIO
    {
        [Key]
        public int USU_ID { get; set; }
        [Display(Name = "Nombre")]
        [Required]
        public string USU_NOMBRE { get; set; }
        [Display(Name = "Usuario")]
        [Required]
        public string USU_USUARIO { get; set; }
        [Display(Name = "Contraseña")]
        [Required]
        public string USU_CONTRASENIA { get; set; }

        [Display(Name = "Rol")]
        [Required]
        public int ROL_ID { get; set; }

        public virtual ROL ROL { get; set; }

        public ResponseModel Autenticarse()
        {
            var rm = new ResponseModel();

            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var usuario = db.USUARIO.Where(x => x.USU_USUARIO == this.USU_USUARIO && x.USU_CONTRASENIA == this.USU_CONTRASENIA).SingleOrDefault();
                    if (usuario != null)
                    {
                        SessionHelper.AddUserToSession(usuario.USU_ID.ToString());
                        rm.SetResponse(true);
                    }
                    else
                    {
                        rm.SetResponse(false, "Acceso denegado al sistema");
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return rm;
        }

        public USUARIO Obtener(int id)
        {
            var usuario = new USUARIO();

            try
            {
                using (var ctx = new ApplicationDbContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    usuario = ctx.USUARIO.Where(x => x.USU_ID == id).SingleOrDefault();
                }
            }
            catch (Exception e)
            {
                throw;
            }

            return usuario;
        }

    }
}
