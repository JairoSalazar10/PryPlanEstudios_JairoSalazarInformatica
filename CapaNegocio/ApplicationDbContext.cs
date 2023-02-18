using CapaNegocio.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
              //: base("DefaultConnection", throwIfV1Schema: false)
              : base("name=DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<USUARIO> USUARIO { get; set; }
        public System.Data.Entity.DbSet<ROL> ROL { get; set; }
        public System.Data.Entity.DbSet<FACULTAD> FACULTAD { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.CARRERA> CARRERAs { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.PLAN> PLAN { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.MATERIA> MATERIA { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.TIPO_COLEGIO> TIPO_COLEGIO { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.ESTUDIANTE> ESTUDIANTEs { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.PLAN_MATERIA> PLAN_MATERIA { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.AFICION> AFICION { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.ASOCIACION> ASOCIACION { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.MOTIVACION> MOTIVACION { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.MENSION> MENSION { get; set; }
        public System.Data.Entity.DbSet<CapaNegocio.Entities.COLEGIO> COLEGIO { get; set; }
    }

}
