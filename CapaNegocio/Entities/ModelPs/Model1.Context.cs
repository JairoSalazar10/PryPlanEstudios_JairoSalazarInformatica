﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaNegocio.Entities.ModelPs
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PLANESTUDIOEntities2 : DbContext
    {
        public PLANESTUDIOEntities2()
            : base("name=PLANESTUDIOEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AFICION> AFICION { get; set; }
        public virtual DbSet<ASOCIACION> ASOCIACION { get; set; }
        public virtual DbSet<CARRERA> CARRERA { get; set; }
        public virtual DbSet<COLEGIO> COLEGIO { get; set; }
        public virtual DbSet<ESTUDIANTE> ESTUDIANTE { get; set; }
        public virtual DbSet<FACULTAD> FACULTAD { get; set; }
        public virtual DbSet<LOG> LOG { get; set; }
        public virtual DbSet<MATERIA> MATERIA { get; set; }
        public virtual DbSet<MENSION> MENSION { get; set; }
        public virtual DbSet<MOTIVACION> MOTIVACION { get; set; }
        public virtual DbSet<PLAN> PLAN { get; set; }
        public virtual DbSet<PLAN_MATERIA> PLAN_MATERIA { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<TIPO_COLEGIO> TIPO_COLEGIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
