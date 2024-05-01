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
    /// Descripción breve de Api_GestionFactura
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionFactura : System.Web.Services.WebService
    {
        logica_factura logica = new logica_factura();

        [WebMethod]
        public List<factura> Listar()
        {
            return logica.Listar();
        }

        [WebMethod]
        public factura LeerID(string id)
        {
            return logica.LeerID(id);
        }

        [WebMethod]
        public List<factura> ListarFiltro(string info)
        {
            return logica.ListarFiltro(info);
        }

        [WebMethod]
        public void Insertar(factura factura_nueva)
        {
            logica.Insertar(factura_nueva);
        }

        [WebMethod]
        public bool Actualizar(factura factura_actualizada)
        {
            return logica.Actualizar(factura_actualizada);
        }

        [WebMethod]
        public bool Eliminar(factura factura_eliminada)
        {
            return logica.Eliminar(factura_eliminada.id);
        }


    }
}
