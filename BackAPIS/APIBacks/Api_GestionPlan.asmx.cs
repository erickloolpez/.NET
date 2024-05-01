using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;
using AccesoDatos;
using Logica;

namespace APIBacks
{
    /// <summary>
    /// Descripción breve de Api_GestionPlan
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionPlan : System.Web.Services.WebService
    {
        logica_plan logica = new logica_plan();

        [WebMethod]

        public List<planes> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public planes LeerID(string id)
        {
            return logica.LeerID(id);
        }

        [WebMethod]
        public List<planes> ListarFiltro(string info)
        {
            return logica.ListarFiltro(info);
        }

        [WebMethod]
        public void Insertar(planes plan_nuevo)
        {
            logica.Insertar(plan_nuevo);
        }

        [WebMethod]
        public bool Actualizar(planes plan_actualizado)
        {
            return logica.Actualizar(plan_actualizado);
        }

        [WebMethod]
        public bool Eliminar(planes plan_eliminado)
        {
            return logica.Eliminar(plan_eliminado.id);
        }
    }
}
