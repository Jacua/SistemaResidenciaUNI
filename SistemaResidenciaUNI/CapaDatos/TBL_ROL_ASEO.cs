//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_ROL_ASEO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_ROL_ASEO()
        {
            this.TBL_HIS_ROL_ASEO = new HashSet<TBL_HIS_ROL_ASEO>();
        }
    
        public int ROL_ASE_ID { get; set; }
        public int TIP_ASE_ID { get; set; }
        public int FRE_ID { get; set; }
        public int EST_ID { get; set; }
        public int USU_ID { get; set; }
        public System.DateTime ROL_ASE_FECHA_INICIAL { get; set; }
        public Nullable<System.DateTime> ROL_ASE_FECHA_FINAL { get; set; }
        public Nullable<System.TimeSpan> ROL_ASE_HORA { get; set; }
        public Nullable<System.DateTime> ROL_ASE_FECHA_DESHABILITADO { get; set; }
        public Nullable<int> ROL_ASE_DIA { get; set; }
        public bool ROL_ASE_ESTADO { get; set; }
    
        public virtual TBL_ESTUDIANTE TBL_ESTUDIANTE { get; set; }
        public virtual TBL_FRECUENCIA TBL_FRECUENCIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_HIS_ROL_ASEO> TBL_HIS_ROL_ASEO { get; set; }
        public virtual TBL_TIPO_ASEO TBL_TIPO_ASEO { get; set; }
        public virtual TBL_USUARIO TBL_USUARIO { get; set; }
    }
}
