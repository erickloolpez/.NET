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
    
    public partial class factura
    {
        public string id { get; set; }
        public string suscripcion_id { get; set; }
        public Nullable<int> plan_historial_id { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_final { get; set; }
        public decimal total { get; set; }
        public Nullable<System.DateTime> factura_cancelada { get; set; }
    
        public virtual historial_plan historial_plan { get; set; }
        public virtual suscripcion suscripcion { get; set; }
    }
}