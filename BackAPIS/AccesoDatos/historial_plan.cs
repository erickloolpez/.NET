//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class historial_plan
    {
    
        public int id { get; set; }
        public string suscripcion_id { get; set; }
        public string plan_id { get; set; }
        public System.DateTime fecha_comienzo { get; set; }
        public System.DateTime fecha_final { get; set; }
        public Nullable<System.DateTime> creado_en { get; set; }
    
    }
}