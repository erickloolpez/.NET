using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Logica;

namespace APIBacks
{
    /// <summary>
    /// Descripción breve de Api_GestionSP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionSP : System.Web.Services.WebService
    {
        logica_sp logica = new logica_sp();

        [WebMethod]
        public List<sp_SuscripcionesPorPlan_Result> SuscripcionesPorPlan()
        {
            return logica.SuscripcionesPorPlan();
        }

        [WebMethod]
        public List<sp_IngresosPorPlan_Result> IngresosPorPlan()
        {
            return logica.IngresosPorPlan();
        }

        [WebMethod]
        public List<sp_TestBanca_Result> TestBanca(string id)
        {
            return logica.TestBanca(id);
        }
    }
}
