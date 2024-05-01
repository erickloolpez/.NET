using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using AccesoDatos;
using AccesoDatos.DTO;
using Logica;

namespace APIBacks
{
    /// <summary>
    /// Descripción breve de Api_GestionIntegracion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionIntegracion : System.Web.Services.WebService
    {
        logica_integracionAwita logica = new logica_integracionAwita();

        [WebMethod]
        public List<DTOAwita> tomaTransaccion(string id)
        {
            return logica.tomaTransaccion(id);
        }
    }
}
