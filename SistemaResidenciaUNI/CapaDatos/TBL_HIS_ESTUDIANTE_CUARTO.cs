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
    
    public partial class TBL_HIS_ESTUDIANTE_CUARTO
    {
        public int HIS_EST_CUA_ID { get; set; }
        public int USU_ID { get; set; }
        public int EST_ID { get; set; }
        public int CUA_ID { get; set; }
        public System.DateTime HIS_EST_CUA_FECHA_INICIAL { get; set; }
        public Nullable<System.DateTime> HIS_EST_CUA_FECHA_FINAL { get; set; }
        public string HIS_EST_CUA_DESRIPCION { get; set; }
        public bool HIS_EST_CUA_ESTADO { get; set; }
    
        public virtual TBL_CUARTO TBL_CUARTO { get; set; }
        public virtual TBL_ESTUDIANTE TBL_ESTUDIANTE { get; set; }
        public virtual TBL_USUARIO TBL_USUARIO { get; set; }
    }
}