using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using Logica;

namespace APIBacks
{
    /// <summary>
    /// Descripción breve de Api_GestionSuscripcion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionSuscripcion : System.Web.Services.WebService
    {
        logica_suscripcion logica = new logica_suscripcion();

        [WebMethod]
        public List<suscripcion> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public suscripcion LeerID(string id)
        {
            return logica.LeerID(id);
        }

        [WebMethod]
        public List<suscripcion> ListarFiltro(string info)
        {
            return logica.ListarFiltro(info);
        }

        [WebMethod]
        public void Insertar(suscripcion suscripcion_nueva )
        {
            logica.Insertar(suscripcion_nueva);
        }

        [WebMethod]
        public bool Actualizar(suscripcion suscripcion_actualizada)
        {
            return logica.Actualizar(suscripcion_actualizada);
        }

        [WebMethod]
        public bool Eliminar(suscripcion suscripcion_eliminada)
        {
            return logica.Eliminar(suscripcion_eliminada);
        }
    }
}
