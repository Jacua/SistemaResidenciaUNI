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
    
    public partial class TBL_HIS_ESTUDIANTE_REGISTRO
    {
        public int HIS_EST_REG_ID { get; set; }
        public Nullable<int> EST_ID { get; set; }
        public Nullable<int> USU_ID { get; set; }
        public int TIP_MOT_REG_ID { get; set; }
        public System.DateTime HIS_EST_REG_FECHA_INICIAL { get; set; }
        public System.DateTime HIS_EST_REG_FECHA_FINAL { get; set; }
        public Nullable<System.DateTime> HIS_EST_REG_FECHA_ESTIMADA { get; set; }
        public bool HIS_EST_REG_ACTIVO { get; set; }
        public string HIS_EST_REG_DESCRIPCION { get; set; }
        public bool HIS_EST_REG_ESTADO { get; set; }
    
        public virtual TBL_TIPO_MOTIVO_REGISTRO TBL_TIPO_MOTIVO_REGISTRO { get; set; }
        public virtual TBL_USUARIO TBL_USUARIO { get; set; }
    }
}
