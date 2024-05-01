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
    /// Descripción breve de Api_GestionCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionCliente : System.Web.Services.WebService
    {
        logica_cliente logica = new logica_cliente();

        [WebMethod]
        public List<cliente> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public cliente LeerID(string id)
        {
            return logica.LeerID(id);
        }

        [WebMethod]
        public List<cliente> ListarFiltro(string info)
        {
            return logica.ListarFiltro(info);
        }

        [WebMethod]
        public void Insertar(cliente cliente_nuevo)
        {
            logica.Insertar(cliente_nuevo);
        }

        [WebMethod]
        public bool Actualizar(cliente cliente_actualizado)
        {
            return logica.Actualizar(cliente_actualizado);
        }

        [WebMethod]
        public bool Eliminar(cliente cliente)
        {
            return logica.Eliminar(cliente.id);
        }
    }
}
