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
    
    public partial class TBL_USUARIO
    {
        public int USU_ID { get; set; }
        public int PER_ID { get; set; }
        public string USU_LOGIN { get; set; }
        public string USU_PASSWORD { get; set; }
        public System.DateTime USU_FECHA_INICIAL { get; set; }
        public Nullable<System.DateTime> USU_FECHA_FINAL { get; set; }
        public bool USU_ESTADO { get; set; }
    
        public virtual TBL_RESPONSABLE TBL_RESPONSABLE { get; set; }
    }
}
