using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using PatronDisenio;


namespace APIBancaWeb
{
    /// <summary>
    /// Descripción breve de Api_GestionBanca
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Api_GestionBanca : System.Web.Services.WebService
    {
        logica_integracion logica = new logica_integracion();

        [WebMethod]
        public List<DTOTransacciones> listarTransacciones(string id)
        {
            return logica.listarTransacciones(id);
        }
    }
}
