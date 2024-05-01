﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class IntegracionDBBEntities : DbContext
    {
        public IntegracionDBBEntities()
            : base("name=IntegracionDBBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<historial_plan> historial_plan { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<suscripcion> suscripcion { get; set; }
    
        public virtual ObjectResult<sp_IngresosPorPlan_Result> sp_IngresosPorPlan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_IngresosPorPlan_Result>("sp_IngresosPorPlan");
        }
    
        public virtual ObjectResult<sp_MostrarPagosPMA_Result> sp_MostrarPagosPMA(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("cedula", cedula) :
                new ObjectParameter("cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagosPMA_Result>("sp_MostrarPagosPMA", cedulaParameter);
        }
    
        public virtual ObjectResult<sp_SuscripcionesPorPlan_Result> sp_SuscripcionesPorPlan()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SuscripcionesPorPlan_Result>("sp_SuscripcionesPorPlan");
        }
    
        public virtual ObjectResult<sp_TestBanca_Result> sp_TestBanca(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TestBanca_Result>("sp_TestBanca", idParameter);
        }
    
        public virtual ObjectResult<string> sp_UltimoID_Suscripcion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_UltimoID_Suscripcion");
        }
    
        public virtual ObjectResult<sp_ID_Suscripcion_Result> sp_ID_Suscripcion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ID_Suscripcion_Result>("sp_ID_Suscripcion");
        }
    }
}