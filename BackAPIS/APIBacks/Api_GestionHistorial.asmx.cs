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
    /// Descripción breve de Api_GestionHistorial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionHistorial : System.Web.Services.WebService
    {
        logica_historial logica = new logica_historial();

        [WebMethod]
        public List<historial_plan> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public List<historial_plan> ListarFiltro(string info)
        {
            return logica.ListarFiltro(info);
        }

        [WebMethod]
        public historial_plan LeerID(string id)
        {
            return logica.LeerID(id);
        }

        [WebMethod]
        public void Insertar(historial_plan historial_nuevo)
        {
            logica.Insertar(historial_nuevo);
        }

        [WebMethod]
        public bool Actualizar(historial_plan historial_actualizado)
        {
            return logica.Actualizar(historial_actualizado);
        }

        [WebMethod]
        public bool Eliminar(historial_plan historial_eliminado)
        {
            string parsedValue = historial_eliminado.id.ToString();
            return logica.Eliminar(parsedValue);
        }

    }
}
