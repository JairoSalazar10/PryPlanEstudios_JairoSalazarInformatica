//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class PLAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLAN()
        {
            this.ESTUDIANTE = new HashSet<ESTUDIANTE>();
            this.PLAN_MATERIA = new HashSet<PLAN_MATERIA>();
        }
    
        public int PLA_ID { get; set; }
        public string PLA_CODIGO { get; set; }
        public string PLA_NOMBRE { get; set; }
        public Nullable<int> CAR_ID { get; set; }
    
        public virtual CARRERA CARRERA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ESTUDIANTE> ESTUDIANTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PLAN_MATERIA> PLAN_MATERIA { get; set; }
    }
}
