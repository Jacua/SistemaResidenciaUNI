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
    
    public partial class TBL_DIRECCION
    {
        public int DIR_ID { get; set; }
        public int BAR_ID { get; set; }
        public Nullable<int> PER_ID { get; set; }
        public string DIR_NO_CASA { get; set; }
        public string DIR_DESCRIPCION { get; set; }
        public bool DIR_ESTADO { get; set; }
    
        public virtual TBL_BARRIO TBL_BARRIO { get; set; }
        public virtual TBL_PERSONA TBL_PERSONA { get; set; }
    }
}
